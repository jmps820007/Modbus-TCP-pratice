
namespace Modbus_TCP_pratice
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tbx_serverIP = new System.Windows.Forms.TextBox();
            this.tbx_serverPort = new System.Windows.Forms.TextBox();
            this.timer_send = new System.Windows.Forms.Timer(this.components);
            this.btn_send01 = new System.Windows.Forms.Button();
            this.tbx_receiveMsg01 = new System.Windows.Forms.TextBox();
            this.tbx_receiveMsg02 = new System.Windows.Forms.TextBox();
            this.btn_send02 = new System.Windows.Forms.Button();
            this.tbx_receiveMsg03 = new System.Windows.Forms.TextBox();
            this.btn_send03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(300, 470);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 34);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(179, 470);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(89, 34);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tbx_serverIP
            // 
            this.tbx_serverIP.Location = new System.Drawing.Point(12, 23);
            this.tbx_serverIP.Name = "tbx_serverIP";
            this.tbx_serverIP.Size = new System.Drawing.Size(100, 22);
            this.tbx_serverIP.TabIndex = 2;
            this.tbx_serverIP.Text = "192.168.0.44";
            // 
            // tbx_serverPort
            // 
            this.tbx_serverPort.Location = new System.Drawing.Point(138, 23);
            this.tbx_serverPort.Name = "tbx_serverPort";
            this.tbx_serverPort.Size = new System.Drawing.Size(100, 22);
            this.tbx_serverPort.TabIndex = 3;
            this.tbx_serverPort.Text = "502";
            // 
            // timer_send
            // 
            this.timer_send.Tick += new System.EventHandler(this.timer_send_Tick);
            // 
            // btn_send01
            // 
            this.btn_send01.Location = new System.Drawing.Point(277, 113);
            this.btn_send01.Name = "btn_send01";
            this.btn_send01.Size = new System.Drawing.Size(106, 25);
            this.btn_send01.TabIndex = 4;
            this.btn_send01.Text = "Send";
            this.btn_send01.UseVisualStyleBackColor = true;
            this.btn_send01.Click += new System.EventHandler(this.btn_send01_Click);
            // 
            // tbx_receiveMsg01
            // 
            this.tbx_receiveMsg01.Location = new System.Drawing.Point(13, 144);
            this.tbx_receiveMsg01.Multiline = true;
            this.tbx_receiveMsg01.Name = "tbx_receiveMsg01";
            this.tbx_receiveMsg01.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_receiveMsg01.Size = new System.Drawing.Size(370, 42);
            this.tbx_receiveMsg01.TabIndex = 5;
            // 
            // tbx_receiveMsg02
            // 
            this.tbx_receiveMsg02.Location = new System.Drawing.Point(13, 249);
            this.tbx_receiveMsg02.Multiline = true;
            this.tbx_receiveMsg02.Name = "tbx_receiveMsg02";
            this.tbx_receiveMsg02.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_receiveMsg02.Size = new System.Drawing.Size(370, 42);
            this.tbx_receiveMsg02.TabIndex = 7;
            // 
            // btn_send02
            // 
            this.btn_send02.Location = new System.Drawing.Point(277, 218);
            this.btn_send02.Name = "btn_send02";
            this.btn_send02.Size = new System.Drawing.Size(106, 25);
            this.btn_send02.TabIndex = 6;
            this.btn_send02.Text = "Send";
            this.btn_send02.UseVisualStyleBackColor = true;
            this.btn_send02.Click += new System.EventHandler(this.btn_send02_Click);
            // 
            // tbx_receiveMsg03
            // 
            this.tbx_receiveMsg03.Location = new System.Drawing.Point(13, 355);
            this.tbx_receiveMsg03.Multiline = true;
            this.tbx_receiveMsg03.Name = "tbx_receiveMsg03";
            this.tbx_receiveMsg03.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_receiveMsg03.Size = new System.Drawing.Size(370, 42);
            this.tbx_receiveMsg03.TabIndex = 9;
            // 
            // btn_send03
            // 
            this.btn_send03.Location = new System.Drawing.Point(277, 324);
            this.btn_send03.Name = "btn_send03";
            this.btn_send03.Size = new System.Drawing.Size(106, 25);
            this.btn_send03.TabIndex = 8;
            this.btn_send03.Text = "Send";
            this.btn_send03.UseVisualStyleBackColor = true;
            this.btn_send03.Click += new System.EventHandler(this.btn_send03_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(408, 516);
            this.Controls.Add(this.tbx_receiveMsg03);
            this.Controls.Add(this.btn_send03);
            this.Controls.Add(this.tbx_receiveMsg02);
            this.Controls.Add(this.btn_send02);
            this.Controls.Add(this.tbx_receiveMsg01);
            this.Controls.Add(this.btn_send01);
            this.Controls.Add(this.tbx_serverPort);
            this.Controls.Add(this.tbx_serverIP);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tbx_serverIP;
        private System.Windows.Forms.TextBox tbx_serverPort;
        private System.Windows.Forms.Timer timer_send;
        private System.Windows.Forms.Button btn_send01;
        private System.Windows.Forms.TextBox tbx_receiveMsg01;
        private System.Windows.Forms.TextBox tbx_receiveMsg02;
        private System.Windows.Forms.Button btn_send02;
        private System.Windows.Forms.TextBox tbx_receiveMsg03;
        private System.Windows.Forms.Button btn_send03;
    }
}

