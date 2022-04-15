namespace VigenereWFApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMess1 = new System.Windows.Forms.TextBox();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.txtEnc2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnc1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMess2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint1 = new System.Windows.Forms.Button();
            this.btnPrint2 = new System.Windows.Forms.Button();
            this.btnMess1 = new System.Windows.Forms.Button();
            this.btnEnc1 = new System.Windows.Forms.Button();
            this.btnEnc2 = new System.Windows.Forms.Button();
            this.btnMess2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpVigenere = new System.Windows.Forms.TabPage();
            this.tpRsa = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnOpenFolderOutput = new System.Windows.Forms.Button();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.btnOpenFolderIn = new System.Windows.Forms.Button();
            this.btnOpenFileIn = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpenFileKeys = new System.Windows.Forms.Button();
            this.comboBoxLengKey = new System.Windows.Forms.ComboBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.tbPathKeys = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1f = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpVigenere.SuspendLayout();
            this.tpRsa.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(340, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá Vigenere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encrypted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(537, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Key";
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(276, 192);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(94, 29);
            this.btnStart1.TabIndex = 4;
            this.btnStart1.Text = "Start";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // txtMess1
            // 
            this.txtMess1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMess1.Location = new System.Drawing.Point(143, 80);
            this.txtMess1.Name = "txtMess1";
            this.txtMess1.Size = new System.Drawing.Size(299, 31);
            this.txtMess1.TabIndex = 1;
            // 
            // txtKey1
            // 
            this.txtKey1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKey1.Location = new System.Drawing.Point(618, 80);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(279, 31);
            this.txtKey1.TabIndex = 2;
            // 
            // txtEnc2
            // 
            this.txtEnc2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnc2.Location = new System.Drawing.Point(143, 87);
            this.txtEnc2.Name = "txtEnc2";
            this.txtEnc2.Size = new System.Drawing.Size(299, 31);
            this.txtEnc2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(339, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giải mã Vigenere";
            // 
            // txtKey2
            // 
            this.txtKey2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKey2.Location = new System.Drawing.Point(618, 83);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(279, 31);
            this.txtKey2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(537, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Key";
            // 
            // txtEnc1
            // 
            this.txtEnc1.Enabled = false;
            this.txtEnc1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnc1.Location = new System.Drawing.Point(143, 144);
            this.txtEnc1.Name = "txtEnc1";
            this.txtEnc1.Size = new System.Drawing.Size(754, 31);
            this.txtEnc1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Encrypted";
            // 
            // txtMess2
            // 
            this.txtMess2.Enabled = false;
            this.txtMess2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMess2.Location = new System.Drawing.Point(143, 154);
            this.txtMess2.Name = "txtMess2";
            this.txtMess2.Size = new System.Drawing.Size(754, 31);
            this.txtMess2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Message";
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(434, 211);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(94, 29);
            this.btnReset2.TabIndex = 11;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(276, 211);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(94, 29);
            this.btnStart2.TabIndex = 10;
            this.btnStart2.Text = "Start";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(91, 24);
            this.tsmiHelp.Text = "Giới thiệu ";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiGoiThieu_Click);
            // 
            // btnPrint1
            // 
            this.btnPrint1.Location = new System.Drawing.Point(594, 192);
            this.btnPrint1.Name = "btnPrint1";
            this.btnPrint1.Size = new System.Drawing.Size(94, 29);
            this.btnPrint1.TabIndex = 6;
            this.btnPrint1.Text = "Print";
            this.btnPrint1.UseVisualStyleBackColor = true;
            this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
            // 
            // btnPrint2
            // 
            this.btnPrint2.Location = new System.Drawing.Point(594, 211);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(94, 29);
            this.btnPrint2.TabIndex = 12;
            this.btnPrint2.Text = "Print";
            this.btnPrint2.UseVisualStyleBackColor = true;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // btnMess1
            // 
            this.btnMess1.Location = new System.Drawing.Point(455, 81);
            this.btnMess1.Name = "btnMess1";
            this.btnMess1.Size = new System.Drawing.Size(51, 29);
            this.btnMess1.TabIndex = 16;
            this.btnMess1.Text = "File";
            this.btnMess1.UseVisualStyleBackColor = true;
            this.btnMess1.Click += new System.EventHandler(this.btnMess1_Click);
            // 
            // btnEnc1
            // 
            this.btnEnc1.Location = new System.Drawing.Point(903, 147);
            this.btnEnc1.Name = "btnEnc1";
            this.btnEnc1.Size = new System.Drawing.Size(72, 29);
            this.btnEnc1.TabIndex = 17;
            this.btnEnc1.Text = "Export";
            this.btnEnc1.UseVisualStyleBackColor = true;
            this.btnEnc1.Click += new System.EventHandler(this.btnEnc1_Click);
            // 
            // btnEnc2
            // 
            this.btnEnc2.Location = new System.Drawing.Point(455, 90);
            this.btnEnc2.Name = "btnEnc2";
            this.btnEnc2.Size = new System.Drawing.Size(51, 29);
            this.btnEnc2.TabIndex = 18;
            this.btnEnc2.Text = "File";
            this.btnEnc2.UseVisualStyleBackColor = true;
            this.btnEnc2.Click += new System.EventHandler(this.btnEnc2_Click);
            // 
            // btnMess2
            // 
            this.btnMess2.Location = new System.Drawing.Point(903, 156);
            this.btnMess2.Name = "btnMess2";
            this.btnMess2.Size = new System.Drawing.Size(72, 29);
            this.btnMess2.TabIndex = 19;
            this.btnMess2.Text = "Export";
            this.btnMess2.UseVisualStyleBackColor = true;
            this.btnMess2.Click += new System.EventHandler(this.btnMess2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStart1);
            this.groupBox1.Controls.Add(this.btnEnc1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnMess1);
            this.groupBox1.Controls.Add(this.txtMess1);
            this.groupBox1.Controls.Add(this.txtKey1);
            this.groupBox1.Controls.Add(this.btnPrint1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEnc1);
            this.groupBox1.Location = new System.Drawing.Point(77, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 231);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hoá";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnMess2);
            this.groupBox2.Controls.Add(this.txtEnc2);
            this.groupBox2.Controls.Add(this.btnEnc2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnPrint2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Controls.Add(this.txtKey2);
            this.groupBox2.Controls.Add(this.btnStart2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMess2);
            this.groupBox2.Location = new System.Drawing.Point(77, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 250);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giải mã";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpVigenere);
            this.tabControl.Controls.Add(this.tpRsa);
            this.tabControl.Location = new System.Drawing.Point(12, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1137, 569);
            this.tabControl.TabIndex = 21;
            // 
            // tpVigenere
            // 
            this.tpVigenere.Controls.Add(this.groupBox1);
            this.tpVigenere.Controls.Add(this.groupBox2);
            this.tpVigenere.Location = new System.Drawing.Point(4, 29);
            this.tpVigenere.Name = "tpVigenere";
            this.tpVigenere.Padding = new System.Windows.Forms.Padding(3);
            this.tpVigenere.Size = new System.Drawing.Size(1129, 536);
            this.tpVigenere.TabIndex = 0;
            this.tpVigenere.Text = "Vigenere";
            this.tpVigenere.UseVisualStyleBackColor = true;
            // 
            // tpRsa
            // 
            this.tpRsa.Controls.Add(this.groupBox5);
            this.tpRsa.Controls.Add(this.groupBox4);
            this.tpRsa.Controls.Add(this.groupBox3);
            this.tpRsa.Controls.Add(this.label9);
            this.tpRsa.Location = new System.Drawing.Point(4, 29);
            this.tpRsa.Name = "tpRsa";
            this.tpRsa.Padding = new System.Windows.Forms.Padding(3);
            this.tpRsa.Size = new System.Drawing.Size(1129, 536);
            this.tpRsa.TabIndex = 1;
            this.tpRsa.Text = "RSA";
            this.tpRsa.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1f);
            this.groupBox5.Controls.Add(this.btnDecrypt);
            this.groupBox5.Controls.Add(this.btnEncrypt);
            this.groupBox5.Controls.Add(this.btnOpenFolderOutput);
            this.groupBox5.Controls.Add(this.btnSelectOutput);
            this.groupBox5.Controls.Add(this.btnOpenFolderIn);
            this.groupBox5.Controls.Add(this.btnOpenFileIn);
            this.groupBox5.Controls.Add(this.tbOutput);
            this.groupBox5.Controls.Add(this.tbInput);
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(495, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(607, 432);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mã hoá và Giải mã";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(340, 227);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 29);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(214, 227);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(94, 29);
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "Mã hoá";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnOpenFolderOutput
            // 
            this.btnOpenFolderOutput.Location = new System.Drawing.Point(467, 166);
            this.btnOpenFolderOutput.Name = "btnOpenFolderOutput";
            this.btnOpenFolderOutput.Size = new System.Drawing.Size(115, 29);
            this.btnOpenFolderOutput.TabIndex = 10;
            this.btnOpenFolderOutput.Text = "Open Folder";
            this.btnOpenFolderOutput.UseVisualStyleBackColor = true;
            this.btnOpenFolderOutput.Click += new System.EventHandler(this.btnOpenFolderOutput_Click);
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Location = new System.Drawing.Point(467, 131);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(115, 29);
            this.btnSelectOutput.TabIndex = 9;
            this.btnSelectOutput.Text = "Select File";
            this.btnSelectOutput.UseVisualStyleBackColor = true;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // btnOpenFolderIn
            // 
            this.btnOpenFolderIn.Location = new System.Drawing.Point(467, 72);
            this.btnOpenFolderIn.Name = "btnOpenFolderIn";
            this.btnOpenFolderIn.Size = new System.Drawing.Size(115, 29);
            this.btnOpenFolderIn.TabIndex = 8;
            this.btnOpenFolderIn.Text = "Select Folder";
            this.btnOpenFolderIn.UseVisualStyleBackColor = true;
            this.btnOpenFolderIn.Click += new System.EventHandler(this.btnOpenFolderIn_Click);
            // 
            // btnOpenFileIn
            // 
            this.btnOpenFileIn.Location = new System.Drawing.Point(467, 37);
            this.btnOpenFileIn.Name = "btnOpenFileIn";
            this.btnOpenFileIn.Size = new System.Drawing.Size(115, 29);
            this.btnOpenFileIn.TabIndex = 7;
            this.btnOpenFileIn.Text = "Select File";
            this.btnOpenFileIn.UseVisualStyleBackColor = true;
            this.btnOpenFileIn.Click += new System.EventHandler(this.btnOpenFileIn_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(79, 152);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(371, 27);
            this.tbOutput.TabIndex = 5;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(79, 59);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(371, 27);
            this.tbInput.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(118, 310);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(393, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Xuất";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Nhập";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbD);
            this.groupBox4.Controls.Add(this.tbE);
            this.groupBox4.Controls.Add(this.tbN);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(48, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 247);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin khoá";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(146, 144);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(213, 27);
            this.tbD.TabIndex = 5;
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(146, 97);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(213, 27);
            this.tbE.TabIndex = 4;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(146, 48);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(213, 27);
            this.tbN.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Mũ giải mã (D)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mũ mã hoá (E)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Module (N)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOpenFileKeys);
            this.groupBox3.Controls.Add(this.comboBoxLengKey);
            this.groupBox3.Controls.Add(this.btnGenerateKey);
            this.groupBox3.Controls.Add(this.tbPathKeys);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(48, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tạo khoá";
            // 
            // btnOpenFileKeys
            // 
            this.btnOpenFileKeys.Location = new System.Drawing.Point(286, 94);
            this.btnOpenFileKeys.Name = "btnOpenFileKeys";
            this.btnOpenFileKeys.Size = new System.Drawing.Size(94, 29);
            this.btnOpenFileKeys.TabIndex = 7;
            this.btnOpenFileKeys.Text = "Open";
            this.btnOpenFileKeys.UseVisualStyleBackColor = true;
            this.btnOpenFileKeys.Click += new System.EventHandler(this.btnOpenFileKeys_Click);
            // 
            // comboBoxLengKey
            // 
            this.comboBoxLengKey.FormattingEnabled = true;
            this.comboBoxLengKey.Location = new System.Drawing.Point(106, 34);
            this.comboBoxLengKey.Name = "comboBoxLengKey";
            this.comboBoxLengKey.Size = new System.Drawing.Size(174, 28);
            this.comboBoxLengKey.TabIndex = 3;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(286, 33);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(94, 29);
            this.btnGenerateKey.TabIndex = 6;
            this.btnGenerateKey.Text = "Tạo";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // tbPathKeys
            // 
            this.tbPathKeys.Location = new System.Drawing.Point(106, 94);
            this.tbPathKeys.Name = "tbPathKeys";
            this.tbPathKeys.Size = new System.Drawing.Size(174, 27);
            this.tbPathKeys.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Key";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Độ dài Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(466, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 43);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã hoá RSA";
            // 
            // label1f
            // 
            this.label1f.AutoSize = true;
            this.label1f.Location = new System.Drawing.Point(119, 356);
            this.label1f.Name = "label1f";
            this.label1f.Size = new System.Drawing.Size(13, 20);
            this.label1f.TabIndex = 13;
            this.label1f.Text = " ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 612);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Bài tập nhóm DOT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpVigenere.ResumeLayout(false);
            this.tpRsa.ResumeLayout(false);
            this.tpRsa.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnStart1;
        private Button button2;
        private TextBox txtMess1;
        private TextBox txtKey1;
        private TextBox txtEnc2;
        private Label label5;
        private TextBox txtKey2;
        private Label label6;
        private TextBox txtEnc1;
        private Label label7;
        private TextBox txtMess2;
        private Label label8;
        private Button btnReset2;
        private Button btnStart2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiHelp;
        private Button btnPrint1;
        private Button btnPrint2;
        private Button btnMess1;
        private Button btnEnc1;
        private Button btnEnc2;
        private Button btnMess2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabControl tabControl;
        private TabPage tpVigenere;
        private TabPage tpRsa;
        private GroupBox groupBox5;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Button btnOpenFolderOutput;
        private Button btnSelectOutput;
        private Button btnOpenFolderIn;
        private Button btnOpenFileIn;
        private TextBox tbOutput;
        private TextBox tbInput;
        private ProgressBar progressBar1;
        private Label label16;
        private Label label15;
        private GroupBox groupBox4;
        private TextBox tbD;
        private TextBox tbE;
        private TextBox tbN;
        private Label label14;
        private Label label13;
        private Label label12;
        private GroupBox groupBox3;
        private Button btnOpenFileKeys;
        private ComboBox comboBoxLengKey;
        private Button btnGenerateKey;
        private TextBox tbPathKeys;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label1f;
    }
}