using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;               //使用於網路通訊協定, IPEndPoint
using System.Net.Sockets;       //控制網路存取, Socket

namespace Modbus_TCP_pratice
{
    public partial class Form1 : Form
    {
        public Socket newclient;
        public bool Connected;
        public Thread myThread;                             //新的執行緒，用於接收伺服器訊息
        public delegate void MyInvoke(string str);          //要呼叫別的執行緒就必須透過委派
        public delegate void AddListItem();
        public AddListItem myDelegate;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Connect()
        {
            string ipadd = tbx_serverIP.Text.Trim();                    //要連接的伺服器IP位置存放字串區域變數ipadd
            int port = Convert.ToInt32(tbx_serverPort.Text.Trim());     //將端口號強制為32位元整數，存放在port

            //建立一個socket

            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(ipadd), port);
            newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //嘗試與遠端伺服器建立連線
            try
            {
                newclient.Connect(EP);
                btn_connect.Enabled = false;    //關閉連線按鈕
                Connected = true;               //已連線旗標 True
            }
            catch (SocketException e)
            {
                MessageBox.Show("連線失敗!! " + e.Message);
                return;
            }

            
            ThreadStart myThreaddelagate = new ThreadStart(ReceiveMsg);     //指定委派物件 ReceiveMsg
            myThread = new Thread(myThreaddelagate);                        //建立ReceiveMsg任務執行緒
            myThread.IsBackground = true;                                   //設為背景執行緒，避免關閉主執行緒時，沒關到這個
            myThread.Start();
            //timer_send.Enabled = true;                                      //啟用定時發送
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        //為避免與伺服器連線因超時而中斷，定時發送指令
        private void timer_send_Tick(object sender, EventArgs e)
        {
            int isecond = 5000;             //1ms * 5000 = 5s
            timer_send.Interval = isecond;  //5s觸發一次
            //Function Code 04 : Read Input Register (PLC WL,LD)
            byte[] data = new byte[] { 0x00, 0x0f, 0x00, 0x00, 0x00, 0x06, 0x01, 0x04, 0x00, 0x00, 0x00, 0x01 };
            newclient.Send(data);
        }

        //Function Code 01 : Read Coils (PLC Y,R)
        private void btn_send01_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x01, 0x00, 0x00, 0x00, 0x04 };
            newclient.Send(data);
        }

        //Function Code 02 : Read Discrete Inputs (PLC X)
        private void btn_send02_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x02, 0x00, 0xC5, 0x00, 0x16 };
            newclient.Send(data);
        }
        private void btn_send03_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x6B, 0x00, 0x03 };
            newclient.Send(data);
        }
        public void ReceiveMsg()
        {
            while (true)
            {
                byte[] data = new byte[1024];               //用於接收伺服器response資料
                newclient.Receive(data);                    //接收數據到data
                int length = data[5];                       //數據長度
                byte[] datashow = new byte[6 + length];     //全部資料長度
                for (int i = 0; i <= length + 5; i++)       //把要顯示的數字存到datashow
                {
                    datashow[i] = data[i];
                }
                string stringdata = BitConverter.ToString(datashow);        //將位元組轉換為16位元字串
                if (data[7] == 0x01) { showMsg01(stringdata + "\r\n"); };
                if (data[7] == 0x02) { showMsg02(stringdata + "\r\n"); };
                if (data[7] == 0x03) { showMsg03(stringdata + "\r\n"); };

            }
        }
        public void showMsg01(string msg)
        {
            //判斷這個textbox的物件是否在同一個執行緒上
            if (tbx_receiveMsg01.InvokeRequired)
            {
                //當InvokeRequired為true時，表示在不同的執行緒上面，所以進行委派動作
                MyInvoke _myinvoke = new MyInvoke(showMsg01);
                tbx_receiveMsg01.Invoke(_myinvoke, new object[] { msg });
            }
            else
            {
                //表示在同一個執行緒上，所以可以正常的呼叫這個TextBox物件
                tbx_receiveMsg01.AppendText(msg);
            }
        }
        public void showMsg02(string msg)
        {
            if (tbx_receiveMsg02.InvokeRequired)
            {
                MyInvoke _myinvoke = new MyInvoke(showMsg02);
                tbx_receiveMsg02.Invoke(_myinvoke, new object[] { msg });
            }
            else
            {
                tbx_receiveMsg02.AppendText(msg);
            }
        }
        public void showMsg03(string msg)
        {
            if (tbx_receiveMsg03.InvokeRequired)
            {
                MyInvoke _myInvoke = new MyInvoke(showMsg03);
                tbx_receiveMsg03.Invoke(_myInvoke, new object[] { msg });
            }
            else
            {
                tbx_receiveMsg03.AppendText(msg);
            }
        }


    }
}
