using FluentFTP;
using Microsoft.VisualBasic.Logging;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Ftp_Server_Bağlantısı
{
    public partial class Form1 : Form
    {
        private FtpClient _client;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (_client != null && _client.IsConnected)
            {
                _client.Disconnect();
                _client.Dispose();
                _client = null;
                btnConnect.Text = "Bağlan";
                lstFiles.Items.Clear();
                btnDownload.Enabled = false;
                btnUpload.Enabled = false;
                Log("Bağlantı Kesildi.");
                return;
            }

            Log("Bağlanılıyor....");

            _client = new FtpClient(txtHost.Text, txtUser.Text, txtPass.Text, (int)numPort.Value);
            _client.Config.EncryptionMode = FtpEncryptionMode.Auto;
            _client.Config.ValidateAnyCertificate = true;

            try
            {
                _client.Connect();
                Log("Bağlantı Başarılı");

                DosyaListesiniGuncelle();

                btnConnect.Text = "Bağlantıyı Kes";
                btnDownload.Enabled = true;
                btnUpload.Enabled = true;
            }
            catch (Exception ex)
            {
                Log($"Hata: {ex.Message}");
                if (_client.IsConnected)
                {
                    _client.Disconnect();
                }
                _client.Dispose();
                _client = null;
            }
        }
        private async Task DosyaListesiniGuncelle()
        {
            Log("Dosya Listesi alınıyor.....");
            lstFiles.Items.Clear();

            foreach (FtpListItem item in _client.GetListing("/"))
            {
                lstFiles.Items.Add(item.FullName);
            }
            Log("Liste Güncellendi.");
        }
        //indirme
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItems == null)
            {
                MessageBox.Show("Lütfen İndirmek için dosya seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string remotePath = lstFiles.SelectedItem.ToString();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = Path.GetFileName(remotePath);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localPath = sfd.FileName;
                Log($"İndiriliyor: {remotePath} -> {localPath}");

                try
                {
                    _client.DownloadFile(localPath, remotePath, FtpLocalExists.Overwrite);
                    Log("İndirme Tamamlandı.");
                }
                catch (Exception ex)
                {
                    Log($"İndirme Hatası: {ex.Message}");
                }

            }
        }
        //yükleme
        private async void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Yüklenecek Dosyayı Seçin:";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string localPath = ofd.FileName;
                string remotePath = "/" + Path.GetFileName(localPath);

                Log($"Yükleniyor: {localPath} -> {remotePath}");

                try
                {
                    _client.UploadFile(localPath, remotePath, FtpRemoteExists.Overwrite);
                    Log("Yükleme Tamamlandı.");

                    DosyaListesiniGuncelle();
                }
                catch (Exception ex)
                {
                    Log($"Yükleme Hatası: {ex.Message}");
                }
            }
        }
        private void Log(string mesaj)
        {
            if (rtbLogs.InvokeRequired)
            {
                rtbLogs.Invoke(new Action(() => Log(mesaj)));
                return;
            }
            rtbLogs.AppendText($"[{DateTime.Now:HH:mm:ss}] {mesaj}\n");
            rtbLogs.ScrollToCaret();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_client != null && _client.IsConnected)
            {
                _client.Disconnect();
            }
            _client?.Dispose();
        }

      

    }
}
