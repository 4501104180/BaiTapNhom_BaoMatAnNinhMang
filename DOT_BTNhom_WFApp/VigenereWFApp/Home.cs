using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using Microsoft.VisualBasic;

namespace VigenereWFApp
{
    public partial class Home : Form
    {
        private delegate void btnEncryptDecrypt();
        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        private string pathKeysXML = "";
        private bool isEncryptFile = true;
        public Home()
        {
            InitializeComponent();
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        // ---------------------Vigenere---------------------------------------------------
        #region Vigenere 
        //hàm kiếm tra Mã hoá
        public bool KiemTraNhapLieuMaHoa()
        {
            bool res = false;
            if(string.IsNullOrEmpty(txtMess1.Text) || string.IsNullOrEmpty(txtKey1.Text))
            {
                res = false;
                MessageBox.Show("Chưa nhập Message hoặc Key mã hoá !!!", "Thông báo");
            }
            else res = true;
            return res;
        }
        //Hàm kiểm tra Giải mã
        public bool KiemTraNhapLieuGiaiMa()
        {
            bool res = false;
            if (string.IsNullOrEmpty(txtEnc2.Text) || string.IsNullOrEmpty(txtKey2.Text))
            {
                res = false;
                MessageBox.Show("Chưa nhập Encrypted hoặc Key giải mã !!!", "Thông báo");
            }
            else res = true;
            return res;
        }
        // Hàm Kiểm tra Start
        public bool KiemTraStart(string s)
        {
            bool res = false;
            if (string.IsNullOrEmpty(s))
            {
                res = false;
                MessageBox.Show("Chưa có được dữ liệu để lưu !!!", "Thông báo");
            }
            else res = true;
            return res;
        }
        //Start Mã hoá
        public void btnStart1_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieuMaHoa())
            {
                int[] arc = Vigenere.chuyenmakey(txtKey1.Text);
                int[] dongkhoa = Vigenere.taokhoa(txtMess1.Text, arc);
                txtEnc1.Text = Vigenere.Mahoa(txtMess1.Text, dongkhoa);
                Clipboard.SetText(txtEnc1.Text);
            }
        }
        //Reset Mã hoá
        private void btnReset1_Click(object sender, EventArgs e)
        {
            txtMess1.Clear();
            txtKey1.Clear();
            txtEnc1.Clear();
        }
        //Start Giải mã 
        private void btnStart2_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieuGiaiMa())
            {
                int[] arc = Vigenere.chuyenmakey(txtKey2.Text);
                int[] dongkhoa = Vigenere.taokhoa(txtEnc2.Text, arc);
                txtMess2.Text = Vigenere.Giaima(txtEnc2.Text, dongkhoa);
                Clipboard.SetText(txtMess2.Text);
            }
        }
        //Reset Giải mã
        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtMess2.Clear();
            txtKey2.Clear();
            txtEnc2.Clear();
        }

        private void tsmiGoiThieu_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.Show();
        }
        /*
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        */
        //In Mã hoá
        private void btnPrint1_Click(object sender, EventArgs e)
        {
            if (KiemTraStart(txtEnc1.Text))
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(save.FileName);
                    file.WriteLineAsync("Mã hoá Vigenere\n");
                    file.Write("Message: ");
                    file.Write(txtMess1.Text + "\n");
                    file.Write("Key: ");
                    file.Write(txtKey1.Text + "\n");
                    file.Write("Encrypted: ");
                    file.Write(txtEnc1.Text + "\n");
                    MessageBox.Show("Lưu kết quả thành công !!!", "Thông báo");
                    file.Close();
                }
            }
        }
        //In Giải mã
        private void btnPrint2_Click(object sender, EventArgs e)
        {
            if (KiemTraStart(txtMess2.Text))
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(save.FileName);
                    file.WriteLineAsync("Giải mã Vigenere\n");
                    file.Write("Encrypted: ");
                    file.Write(txtEnc2.Text + "\n");
                    file.Write("Key: ");
                    file.Write(txtKey2.Text + "\n");
                    file.Write("Message: ");
                    file.Write(txtMess2.Text + "\n");
                    MessageBox.Show("Lưu kết quả thành công !!!", "Thông báo");
                    file.Close();
                }
            }
        }
        //Đọc File Mã hoá
        private void btnMess1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);
                txtMess1.Text = file.ReadToEnd();
                file.Close();
            }
        }
        //Xuất File Mã hoá
        private void btnEnc1_Click(object sender, EventArgs e)
        {
            if (txtEnc1.Text != "")
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(save.FileName);
                    file.Write(txtEnc1.Text);
                    MessageBox.Show("Xuất File mã hoá thành công !!!", "Thông báo");
                    file.Close();
                }
            }
            else MessageBox.Show("Chưa có được dữ liệu để xuất !!!", "Thông báo");
        }
        //Đọc File Giải mã
        private void btnEnc2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);
                txtEnc2.Text = file.ReadToEnd();
                file.Close();
            }
        }
        //Xuất File Giải mã
        private void btnMess2_Click(object sender, EventArgs e)
        {
            if (txtMess2.Text != "")
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(save.FileName);
                    file.Write(txtMess2.Text);
                    MessageBox.Show("Xuất File giải mã thành công !!!", "Thông báo");
                    file.Close();
                }
            }
            else MessageBox.Show("Chưa có được dữ liệu để xuất !!!", "Thông báo");
        }
        #endregion
        //----------------------RSA--------------------------------------------------------
        #region RSA
        
        private void enabledOrDisableButtons(bool isEnable)
        {
            this.btnOpenFolderOutput.Enabled = isEnable;
            this.tbOutput.Enabled = isEnable;
            this.btnEncrypt.Enabled = isEnable;
            this.btnDecrypt.Enabled = isEnable;
            this.btnGenerateKey.Enabled = isEnable;
            this.btnOpenFileIn.Enabled = isEnable;
            this.btnOpenFileKeys.Enabled = isEnable;
            this.btnOpenFolderIn.Enabled = isEnable;
            this.btnSelectOutput.Enabled = isEnable;


        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            this.comboBoxLengKey.Items.Add("512 bits");
            this.comboBoxLengKey.Items.Add("1024 bits");
            this.comboBoxLengKey.Items.Add("2048 bits");
            this.comboBoxLengKey.Items.Add("4096 bits");
            this.tbN.Enabled = false;
            this.tbD.Enabled = false;
            this.tbE.Enabled = false;
            this.comboBoxLengKey.Text = "1024 bits";
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            // Tạo file chứa key
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "Xml File|*.xml|All File|*.*";
            saveFileDialog1.Title = "Chọn tên file";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            int lengthKey = 0;
            if (this.comboBoxLengKey.Text == "1024 bits") lengthKey = 1024;
            else if (this.comboBoxLengKey.Text == "512 bits") lengthKey = 512;
            else if (this.comboBoxLengKey.Text == "2048 bits") lengthKey = 2048;
            else if (this.comboBoxLengKey.Text == "4096 bits") lengthKey = 4096;
            saveFileDialog1.RestoreDirectory = true;
            String pathPrivateKey = saveFileDialog1.FileName;
            //tạo key có độ dài lengthKey
            RSA = new RSACryptoServiceProvider(lengthKey); //tạo key có độ dài lengtheKey


            File.WriteAllText(pathPrivateKey, RSA.ToXmlString(true));  // Private Key

            pathKeysXML = pathPrivateKey;
            tbPathKeys.Text = pathPrivateKey; //Hiển thị đường dẫn key

            if (File.Exists(pathKeysXML))
            {
                if (Path.GetExtension(pathKeysXML) == ".xml") //kiểm tra định dạng
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeysXML)); //đọc RSA Key
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        tbN.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        tbE.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        tbD.Text = xnList.InnerText;
                        tbN.Enabled = true;
                        tbE.Enabled = true;
                        tbD.Enabled = true;
                    }
                    catch (Exception ix)
                    {
                        MessageBox.Show(ix.Message);
                    }
                }
            }
            MessageBox.Show("Tạo key có độ dài " + lengthKey.ToString() + " bits thành công.");
        }

        private void btnOpenFileKeys_Click(object sender, EventArgs e)
        {
            this.tbD.Clear(); this.tbE.Clear(); this.tbN.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pathKeysXML = op.FileName;
                tbPathKeys.Text = op.FileName;
            }

            if (File.Exists(pathKeysXML))
            {
                if (Path.GetExtension(pathKeysXML) == ".xml")
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeysXML));
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        tbN.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        tbE.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        tbD.Text = xnList.InnerText;
                        tbN.Enabled = true;
                        tbE.Enabled = true;
                        tbD.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed: " + ex.Message);
                    }
                }
            }
        }

        private void btnOpenFileIn_Click(object sender, EventArgs e)
        {
            isEncryptFile = true;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                tbInput.Text = op.FileName;
        }

        private void btnOpenFolderIn_Click(object sender, EventArgs e)
        {
            isEncryptFile = false;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                this.tbInput.Text = folderBrowserDialog1.SelectedPath;
        }
        // Lỗi không mở được file - bó tay
        private void btnOpenFolderOutput_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length > 0)
            {
                try
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = tbOutput.Text;
                    prc.Start();
                }
                catch (Exception ioex)
                {
                    MessageBox.Show("Failed: " + ioex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đường dẫn !");
            }
        }

        private void RSA_Algorithm(string inputFile, string outputFile, RSAParameters RSAKeyInfo, bool isEncrypt)
        {
            try
            {
                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read); //Đọc file input
                FileStream fsCiperText = new FileStream(outputFile, FileMode.Create, FileAccess.Write); //Tạo file output
                fsCiperText.SetLength(0);
                byte[] bin, encryptedData;
                long rdlen = 0;
                long totlen = fsInput.Length;
                int len;
                this.progressBar1.Minimum = 0;
                this.progressBar1.Maximum = 100;

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.ImportParameters(RSAKeyInfo); //Nhập thông tin khoá RSA (bao gồm khoá riêng)

                int maxBytesCanEncrypted;
                //RSA chỉ có thể mã hóa các khối dữ liệu ngắn hơn độ dài khóa, chia dữ liệu cho một số khối và sau đó mã hóa từng khối và sau đó hợp nhất chúng
                if (isEncrypt)
                    maxBytesCanEncrypted = ((RSA.KeySize - 384) / 8) + 37;// + 7: OAEP - Đệm mã hóa bất đối xứng tối ưu

                else
                    maxBytesCanEncrypted = (RSA.KeySize / 8);
                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    if (totlen - rdlen < maxBytesCanEncrypted) maxBytesCanEncrypted = (int)(totlen - rdlen);
                    bin = new byte[maxBytesCanEncrypted];
                    len = fsInput.Read(bin, 0, maxBytesCanEncrypted);

                    if (isEncrypt) encryptedData = RSA.Encrypt(bin, false); //Mã Hoá
                    else encryptedData = RSA.Decrypt(bin, false); //Giải mã

                    fsCiperText.Write(encryptedData, 0, encryptedData.Length);
                    rdlen = rdlen + len;

                    this.label1f.Text = "Tên tệp xử lý : " + Path.GetFileName(inputFile) + "\t Thành công: " + ((long)(rdlen * 100) / totlen).ToString() + " %";
                    this.label1f.Update();
                    this.label1f.Refresh();

                    this.progressBar1.Value = (int)((rdlen * 100) / totlen);//thanh tiến trình
                }

                fsCiperText.Close(); //save file
                fsInput.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
        }
        private void btnEncryptClick()
        {
            enabledOrDisableButtons(false);
            if (this.tbPathKeys.Text.Length == 0 || this.tbN.Text.Length == 0 || this.tbD.Text.Length == 0 || this.tbE.Text.Length == 0)
            {
                MessageBox.Show("Key không hợp lệ!");
                enabledOrDisableButtons(true);
                return;
            }

            try
            {
                if (tbInput.Text.Length != 0 &&
                tbPathKeys.Text.Length != 0 &&
                tbN.Text.Length != 0)
                {

                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    string inputFileName = tbInput.Text, outputFileName = "";

                    if (isEncryptFile)
                    {
                        outputFileName = tbOutput.Text + "\\" + Path.GetFileName(tbInput.Text) + ".lhde";
                    }
                    //get Keys.
                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(File.ReadAllText(this.pathKeysXML));
                    if (isEncryptFile)
                        RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(true), true);
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*");

                        if (filePaths.Length == 0 || (filePaths.Length == 1 && (Path.GetFileName(filePaths[0]) == "Thumbs.db")))
                        {
                            MessageBox.Show("Thư mục rỗng!");
                            enabledOrDisableButtons(true);
                            return;
                        }



                        // tbt.Text = Path.GetDirectoryName(outputFileName);
                        for (int i = 0; i < filePaths.Length; i++)
                        {
                            outputFileName = tbOutput.Text + "\\" + Path.GetFileName(filePaths[i]);
                            if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                                RSA_Algorithm(filePaths[i], outputFileName + ".lhde", RSA.ExportParameters(true), true);
                        }
                    }
                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Thời gian thực thi " + elapsedMs.ToString() + "s");
                }
                else
                {
                    enabledOrDisableButtons(true);
                    MessageBox.Show("Dữ liệu không đủ để mã hóa!");
                }
            }
            catch (Exception ex)
            {
                enabledOrDisableButtons(true);
                MessageBox.Show("Failed: " + ex.Message);
            }
            enabledOrDisableButtons(true);
        }
        
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output");
                return;
            }
            if (tbPathKeys.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến Key!");
                return;
            }
            btnEncryptDecrypt s = new btnEncryptDecrypt(btnEncryptClick);
            s.BeginInvoke(null, null);
        }
        
        private void btnDecryptClick()
        {
            enabledOrDisableButtons(false);

            try
            {
                if (tbInput.Text.Length != 0 &&
                   tbPathKeys.Text.Length != 0 &&
                   tbN.Text.Length != 0)
                {
                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();

                    string inputFileName = tbInput.Text, outputFileName = "";

                    if (isEncryptFile && Path.GetExtension(inputFileName) != ".lhde")
                    {
                        MessageBox.Show("Tệp tin này không được hỗ trợ đển giải mã!");
                        enabledOrDisableButtons(true);
                        return;
                    }

                    if (isEncryptFile)
                    {

                        outputFileName = tbOutput.Text + "\\" + Path.GetFileName(inputFileName.Substring(0, inputFileName.Length - 5));


                    }

                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(File.ReadAllText(this.pathKeysXML));

                    if (isEncryptFile)
                        RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(true), false);
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*.lhde", SearchOption.AllDirectories);
                        if (filePaths.Length == 0 || (filePaths.Length == 1 && (Path.GetFileName(filePaths[0]) == "Thumbs.db")))
                        {
                            MessageBox.Show("Thư mục rỗng!");
                            enabledOrDisableButtons(true);
                            return;
                        }

                        for (int i = 0; i < filePaths.Length; i++)
                            if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                            {
                                outputFileName = tbOutput.Text + "\\" + Path.GetFileName(filePaths[i].Substring(0, filePaths[i].Length - 5));
                                RSA_Algorithm(filePaths[i], outputFileName, RSA.ExportParameters(true), false);

                            }

                    }
                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Tổng thời gian thực thi: " + elapsedMs.ToString() + "s");
                }
                else
                {
                    MessageBox.Show("Không đủ điều kiện để giải mã !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
            enabledOrDisableButtons(true);
        }
        
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output");
                return;
            }
            btnEncryptDecrypt s = new btnEncryptDecrypt(btnDecryptClick);
            s.BeginInvoke(null, null);
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                this.tbOutput.Text = f1.SelectedPath;
            }
        }

        #endregion

    }
}