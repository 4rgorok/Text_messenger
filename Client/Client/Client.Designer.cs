namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.lPort = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.wbChat = new System.Windows.Forms.WebBrowser();
            this.btSend = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.bwReading = new System.ComponentModel.BackgroundWorker();
            this.btBold = new System.Windows.Forms.Button();
            this.btItalic = new System.Windows.Forms.Button();
            this.btUnderline = new System.Windows.Forms.Button();
            this.btLike = new System.Windows.Forms.Button();
            this.btBic = new System.Windows.Forms.Button();
            this.btLove = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(192, 12);
            this.btConnect.Name = "btConnect";
            this.btConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btConnect.Size = new System.Drawing.Size(70, 70);
            this.btConnect.TabIndex = 0;
            this.btConnect.TabStop = false;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Location = new System.Drawing.Point(268, 12);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(70, 70);
            this.btDisconnect.TabIndex = 1;
            this.btDisconnect.TabStop = false;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(63, 39);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(100, 20);
            this.nudPort.TabIndex = 2;
            this.nudPort.Value = new decimal(new int[] {
            98,
            0,
            0,
            0});
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(21, 41);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 3;
            this.lPort.Text = "Port";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(63, 12);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 4;
            this.tbAddress.Text = "192.168.0.14";
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(12, 99);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(446, 43);
            this.lbInfo.TabIndex = 5;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(12, 15);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(45, 13);
            this.lAddress.TabIndex = 6;
            this.lAddress.Text = "Address";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(15, 377);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(270, 100);
            this.tbMessage.TabIndex = 7;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // wbChat
            // 
            this.wbChat.Location = new System.Drawing.Point(12, 148);
            this.wbChat.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbChat.Name = "wbChat";
            this.wbChat.Size = new System.Drawing.Size(527, 223);
            this.wbChat.TabIndex = 8;
            this.wbChat.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbChat_DocumentCompleted);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(113, 483);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 25);
            this.btSend.TabIndex = 9;
            this.btSend.TabStop = false;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(63, 65);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 10;
            this.tbName.Text = "Jakub";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(14, 68);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(40, 13);
            this.lName.TabIndex = 11;
            this.lName.Text = "Nazwa";
            // 
            // bwReading
            // 
            this.bwReading.WorkerSupportsCancellation = true;
            this.bwReading.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwReading_DoWork);
            // 
            // btBold
            // 
            this.btBold.BackgroundImage = global::Client.Properties.Resources.b;
            this.btBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btBold.Location = new System.Drawing.Point(290, 377);
            this.btBold.Margin = new System.Windows.Forms.Padding(2);
            this.btBold.Name = "btBold";
            this.btBold.Size = new System.Drawing.Size(38, 41);
            this.btBold.TabIndex = 12;
            this.btBold.TabStop = false;
            this.btBold.UseVisualStyleBackColor = true;
            this.btBold.Click += new System.EventHandler(this.btBold_Click);
            // 
            // btItalic
            // 
            this.btItalic.BackgroundImage = global::Client.Properties.Resources.i;
            this.btItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btItalic.Location = new System.Drawing.Point(332, 377);
            this.btItalic.Margin = new System.Windows.Forms.Padding(2);
            this.btItalic.Name = "btItalic";
            this.btItalic.Size = new System.Drawing.Size(38, 41);
            this.btItalic.TabIndex = 13;
            this.btItalic.TabStop = false;
            this.btItalic.UseVisualStyleBackColor = true;
            this.btItalic.Click += new System.EventHandler(this.btItalic_Click);
            // 
            // btUnderline
            // 
            this.btUnderline.BackgroundImage = global::Client.Properties.Resources.u;
            this.btUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btUnderline.Location = new System.Drawing.Point(374, 377);
            this.btUnderline.Margin = new System.Windows.Forms.Padding(2);
            this.btUnderline.Name = "btUnderline";
            this.btUnderline.Size = new System.Drawing.Size(38, 41);
            this.btUnderline.TabIndex = 14;
            this.btUnderline.TabStop = false;
            this.btUnderline.UseVisualStyleBackColor = true;
            this.btUnderline.Click += new System.EventHandler(this.btUnderline_Click);
            // 
            // btLike
            // 
            this.btLike.Location = new System.Drawing.Point(290, 452);
            this.btLike.Margin = new System.Windows.Forms.Padding(2);
            this.btLike.Name = "btLike";
            this.btLike.Size = new System.Drawing.Size(22, 24);
            this.btLike.TabIndex = 15;
            this.btLike.TabStop = false;
            this.btLike.Text = "👍";
            this.btLike.UseVisualStyleBackColor = true;
            this.btLike.Click += new System.EventHandler(this.btLike_Click);
            // 
            // btBic
            // 
            this.btBic.Location = new System.Drawing.Point(316, 452);
            this.btBic.Margin = new System.Windows.Forms.Padding(2);
            this.btBic.Name = "btBic";
            this.btBic.Size = new System.Drawing.Size(22, 24);
            this.btBic.TabIndex = 16;
            this.btBic.TabStop = false;
            this.btBic.Text = "💪";
            this.btBic.UseVisualStyleBackColor = true;
            this.btBic.Click += new System.EventHandler(this.btBic_Click);
            // 
            // btLove
            // 
            this.btLove.Location = new System.Drawing.Point(344, 452);
            this.btLove.Margin = new System.Windows.Forms.Padding(2);
            this.btLove.Name = "btLove";
            this.btLove.Size = new System.Drawing.Size(22, 24);
            this.btLove.TabIndex = 17;
            this.btLove.TabStop = false;
            this.btLove.Text = "❤";
            this.btLove.UseVisualStyleBackColor = true;
            this.btLove.Click += new System.EventHandler(this.btLove_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(464, 99);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 43);
            this.btClear.TabIndex = 18;
            this.btClear.Text = "Clear Browser\r\n";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "/priv name message";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btLove);
            this.Controls.Add(this.btBic);
            this.Controls.Add(this.btLike);
            this.Controls.Add(this.btUnderline);
            this.Controls.Add(this.btItalic);
            this.Controls.Add(this.btBold);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.wbChat);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.WebBrowser wbChat;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.ComponentModel.BackgroundWorker bwReading;
        private System.Windows.Forms.Button btBold;
        private System.Windows.Forms.Button btItalic;
        private System.Windows.Forms.Button btUnderline;
        private System.Windows.Forms.Button btLike;
        private System.Windows.Forms.Button btBic;
        private System.Windows.Forms.Button btLove;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label1;
    }
}

