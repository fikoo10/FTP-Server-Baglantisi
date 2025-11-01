namespace Ftp_Server_Bağlantısı
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHost = new TextBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            numPort = new NumericUpDown();
            btnConnect = new Button();
            lstFiles = new ListBox();
            btnDownload = new Button();
            btnUpload = new Button();
            rtbLogs = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            SuspendLayout();
            // 
            // txtHost
            // 
            txtHost.Location = new Point(132, 42);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(192, 31);
            txtHost.TabIndex = 0;
            txtHost.Text = "localhost";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(132, 79);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(192, 31);
            txtUser.TabIndex = 1;
            txtUser.Text = "anonymous";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(132, 116);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(192, 31);
            txtPass.TabIndex = 2;
            // 
            // numPort
            // 
            numPort.Location = new Point(132, 153);
            numPort.Name = "numPort";
            numPort.Size = new Size(110, 31);
            numPort.TabIndex = 3;
            numPort.Value = new decimal(new int[] { 21, 0, 0, 0 });
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(130, 190);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(112, 34);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Bağlan";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 25;
            lstFiles.Location = new Point(369, 42);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(230, 129);
            lstFiles.TabIndex = 5;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(369, 190);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(112, 34);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "İndir";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(487, 190);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(112, 34);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Yükle";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // rtbLogs
            // 
            rtbLogs.Location = new Point(655, 42);
            rtbLogs.Name = "rtbLogs";
            rtbLogs.ReadOnly = true;
            rtbLogs.Size = new Size(312, 182);
            rtbLogs.TabIndex = 8;
            rtbLogs.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 9;
            label1.Text = "Host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 82);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 10;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 116);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 153);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 12;
            label4.Text = "Port No";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 264);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbLogs);
            Controls.Add(btnUpload);
            Controls.Add(btnDownload);
            Controls.Add(lstFiles);
            Controls.Add(btnConnect);
            Controls.Add(numPort);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(txtHost);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHost;
        private TextBox txtUser;
        private TextBox txtPass;
        private NumericUpDown numPort;
        private Button btnConnect;
        private ListBox lstFiles;
        private Button btnDownload;
        private Button btnUpload;
        private RichTextBox rtbLogs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
