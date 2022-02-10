
namespace HexCopier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.integerComboBox = new System.Windows.Forms.ComboBox();
            this.floatComboBox = new System.Windows.Forms.ComboBox();
            this.boolComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedHexValues = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.arm32ComboBox = new System.Windows.Forms.ComboBox();
            this.arm64ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selectedHexValues1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // integerComboBox
            // 
            this.integerComboBox.FormattingEnabled = true;
            this.integerComboBox.Items.AddRange(new object[] {
            "0 (or false)",
            "1 (or true)",
            "2",
            "7",
            "10",
            "15",
            "16",
            "17",
            "999",
            "1,000",
            "1,147",
            "4,060",
            "10,000",
            "120,000",
            "1 million",
            "10 million",
            "12 million"});
            this.integerComboBox.Location = new System.Drawing.Point(23, 66);
            this.integerComboBox.Name = "integerComboBox";
            this.integerComboBox.Size = new System.Drawing.Size(101, 21);
            this.integerComboBox.TabIndex = 0;
            this.integerComboBox.SelectedIndexChanged += new System.EventHandler(this.integerComboBox_SelectedIndexChanged_1);
            this.integerComboBox.Click += new System.EventHandler(this.integerComboBox_Click);
            // 
            // floatComboBox
            // 
            this.floatComboBox.FormattingEnabled = true;
            this.floatComboBox.Items.AddRange(new object[] {
            "1.85",
            "1.50",
            "40",
            "99",
            "100",
            "999/FREEZE",
            "1000",
            "2000",
            "131072.0"});
            this.floatComboBox.Location = new System.Drawing.Point(26, 127);
            this.floatComboBox.Name = "floatComboBox";
            this.floatComboBox.Size = new System.Drawing.Size(101, 21);
            this.floatComboBox.TabIndex = 1;
            this.floatComboBox.SelectedIndexChanged += new System.EventHandler(this.floatComboBox_SelectedIndexChanged);
            this.floatComboBox.Click += new System.EventHandler(this.floatComboBox_Click);
            // 
            // boolComboBox
            // 
            this.boolComboBox.FormattingEnabled = true;
            this.boolComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.boolComboBox.Location = new System.Drawing.Point(176, 66);
            this.boolComboBox.Name = "boolComboBox";
            this.boolComboBox.Size = new System.Drawing.Size(101, 21);
            this.boolComboBox.TabIndex = 2;
            this.boolComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.boolComboBox.Click += new System.EventHandler(this.boolComboBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Integers (Int)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Float (0.00f)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "bool (True/False";
            // 
            // selectedHexValues
            // 
            this.selectedHexValues.AutoSize = true;
            this.selectedHexValues.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedHexValues.ForeColor = System.Drawing.Color.LimeGreen;
            this.selectedHexValues.Location = new System.Drawing.Point(136, 180);
            this.selectedHexValues.Name = "selectedHexValues";
            this.selectedHexValues.Size = new System.Drawing.Size(209, 29);
            this.selectedHexValues.TabIndex = 6;
            this.selectedHexValues.Text = "--   --   --   --   --   --   --   --";
            this.selectedHexValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selectedHexValues_MouseDown);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(192, 96);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Location = new System.Drawing.Point(171, 126);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(116, 23);
            this.copyToClipboardButton.TabIndex = 8;
            this.copyToClipboardButton.Text = "Copy to Clipboard";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Take me to ArmConverter.com";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Can\'t find a Value you want? click below...";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(115, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "LOKI\'s Arm To Hex Companion";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(465, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 39);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Arm Conversion 32bit";
            // 
            // arm32ComboBox
            // 
            this.arm32ComboBox.FormattingEnabled = true;
            this.arm32ComboBox.Items.AddRange(new object[] {
            "int 65000",
            "int 1",
            "float 131072.0",
            "INT",
            "FLOAT",
            "NEGATIVE INT"});
            this.arm32ComboBox.Location = new System.Drawing.Point(322, 66);
            this.arm32ComboBox.Name = "arm32ComboBox";
            this.arm32ComboBox.Size = new System.Drawing.Size(147, 21);
            this.arm32ComboBox.TabIndex = 15;
            this.arm32ComboBox.SelectedIndexChanged += new System.EventHandler(this.arm32ComboBox_SelectedIndexChanged);
            this.arm32ComboBox.Click += new System.EventHandler(this.arm32ComboBox_Click);
            // 
            // arm64ComboBox
            // 
            this.arm64ComboBox.FormattingEnabled = true;
            this.arm64ComboBox.Items.AddRange(new object[] {
            "0 INT/False BOOL",
            "1 INT/True BOOL",
            "5000 INT",
            "0 FLOAT",
            "1 FLOAT",
            "31 FLOAT",
            "NOP CODE"});
            this.arm64ComboBox.Location = new System.Drawing.Point(321, 127);
            this.arm64ComboBox.Name = "arm64ComboBox";
            this.arm64ComboBox.Size = new System.Drawing.Size(147, 21);
            this.arm64ComboBox.TabIndex = 17;
            this.arm64ComboBox.SelectedIndexChanged += new System.EventHandler(this.arm64ComboBox_SelectedIndexChanged);
            this.arm64ComboBox.Click += new System.EventHandler(this.arm64ComboBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Arm Conversion 64bit";
            // 
            // selectedHexValues1
            // 
            this.selectedHexValues1.AutoSize = true;
            this.selectedHexValues1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedHexValues1.ForeColor = System.Drawing.Color.LimeGreen;
            this.selectedHexValues1.Location = new System.Drawing.Point(136, 154);
            this.selectedHexValues1.Name = "selectedHexValues1";
            this.selectedHexValues1.Size = new System.Drawing.Size(0, 29);
            this.selectedHexValues1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Credits >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(2, 266);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Game-Guardian-Il2cpp-Script";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(493, 264);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.selectedHexValues1);
            this.Controls.Add(this.arm64ComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.arm32ComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.selectedHexValues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boolComboBox);
            this.Controls.Add(this.floatComboBox);
            this.Controls.Add(this.integerComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox integerComboBox;
        private System.Windows.Forms.ComboBox floatComboBox;
        private System.Windows.Forms.ComboBox boolComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedHexValues;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button copyToClipboardButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox arm32ComboBox;
        private System.Windows.Forms.ComboBox arm64ComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label selectedHexValues1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

