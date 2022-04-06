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
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá Vigenere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encrypted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(527, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Key";
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(266, 141);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(94, 29);
            this.btnStart1.TabIndex = 4;
            this.btnStart1.Text = "Start";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 141);
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
            this.txtMess1.Location = new System.Drawing.Point(133, 29);
            this.txtMess1.Name = "txtMess1";
            this.txtMess1.Size = new System.Drawing.Size(299, 31);
            this.txtMess1.TabIndex = 1;
            // 
            // txtKey1
            // 
            this.txtKey1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKey1.Location = new System.Drawing.Point(608, 29);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(279, 31);
            this.txtKey1.TabIndex = 2;
            // 
            // txtEnc2
            // 
            this.txtEnc2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnc2.Location = new System.Drawing.Point(133, 112);
            this.txtEnc2.Name = "txtEnc2";
            this.txtEnc2.Size = new System.Drawing.Size(299, 31);
            this.txtEnc2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(314, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giải mã Vigenere";
            // 
            // txtKey2
            // 
            this.txtKey2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKey2.Location = new System.Drawing.Point(608, 108);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(279, 31);
            this.txtKey2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(527, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Key";
            // 
            // txtEnc1
            // 
            this.txtEnc1.Enabled = false;
            this.txtEnc1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnc1.Location = new System.Drawing.Point(133, 93);
            this.txtEnc1.Name = "txtEnc1";
            this.txtEnc1.Size = new System.Drawing.Size(754, 31);
            this.txtEnc1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Encrypted";
            // 
            // txtMess2
            // 
            this.txtMess2.Enabled = false;
            this.txtMess2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMess2.Location = new System.Drawing.Point(133, 179);
            this.txtMess2.Name = "txtMess2";
            this.txtMess2.Size = new System.Drawing.Size(754, 31);
            this.txtMess2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Message";
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(424, 236);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(94, 29);
            this.btnReset2.TabIndex = 11;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(266, 236);
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
            this.menuStrip1.Size = new System.Drawing.Size(1027, 28);
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
            this.btnPrint1.Location = new System.Drawing.Point(584, 141);
            this.btnPrint1.Name = "btnPrint1";
            this.btnPrint1.Size = new System.Drawing.Size(94, 29);
            this.btnPrint1.TabIndex = 6;
            this.btnPrint1.Text = "Print";
            this.btnPrint1.UseVisualStyleBackColor = true;
            this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
            // 
            // btnPrint2
            // 
            this.btnPrint2.Location = new System.Drawing.Point(584, 236);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(94, 29);
            this.btnPrint2.TabIndex = 12;
            this.btnPrint2.Text = "Print";
            this.btnPrint2.UseVisualStyleBackColor = true;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // btnMess1
            // 
            this.btnMess1.Location = new System.Drawing.Point(445, 30);
            this.btnMess1.Name = "btnMess1";
            this.btnMess1.Size = new System.Drawing.Size(51, 29);
            this.btnMess1.TabIndex = 16;
            this.btnMess1.Text = "File";
            this.btnMess1.UseVisualStyleBackColor = true;
            this.btnMess1.Click += new System.EventHandler(this.btnMess1_Click);
            // 
            // btnEnc1
            // 
            this.btnEnc1.Location = new System.Drawing.Point(893, 96);
            this.btnEnc1.Name = "btnEnc1";
            this.btnEnc1.Size = new System.Drawing.Size(72, 29);
            this.btnEnc1.TabIndex = 17;
            this.btnEnc1.Text = "Export";
            this.btnEnc1.UseVisualStyleBackColor = true;
            this.btnEnc1.Click += new System.EventHandler(this.btnEnc1_Click);
            // 
            // btnEnc2
            // 
            this.btnEnc2.Location = new System.Drawing.Point(445, 115);
            this.btnEnc2.Name = "btnEnc2";
            this.btnEnc2.Size = new System.Drawing.Size(51, 29);
            this.btnEnc2.TabIndex = 18;
            this.btnEnc2.Text = "File";
            this.btnEnc2.UseVisualStyleBackColor = true;
            this.btnEnc2.Click += new System.EventHandler(this.btnEnc2_Click);
            // 
            // btnMess2
            // 
            this.btnMess2.Location = new System.Drawing.Point(893, 181);
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
            this.groupBox1.Controls.Add(this.btnStart1);
            this.groupBox1.Controls.Add(this.btnEnc1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnMess1);
            this.groupBox1.Controls.Add(this.txtMess1);
            this.groupBox1.Controls.Add(this.txtKey1);
            this.groupBox1.Controls.Add(this.btnPrint1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEnc1);
            this.groupBox1.Location = new System.Drawing.Point(21, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 200);
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
            this.groupBox2.Location = new System.Drawing.Point(21, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 284);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giải mã";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Vigenere";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}