using System.Text;

namespace VigenereWFApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

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
                //string result = (arr == null) ? null : arr.Skip(1).Aggregate(arr[0].ToString(), (s, i) => s + "," + i.ToString());
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
                //string result = (arr == null) ? null : arr.Skip(1).Aggregate(arr[0].ToString(), (s, i) => s + "," + i.ToString());
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
    }
}