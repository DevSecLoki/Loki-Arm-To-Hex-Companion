using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HexCopier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        } // drag and drop form

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) // bool combo box

        {
            if (boolComboBox.Text == "True")
            {
                selectedHexValues.Text = "01 00 A0 E3 1E FF 2F E1";
            }
            if (boolComboBox.Text == "False")
            {
                selectedHexValues.Text = "00 00 A0 E3 1E FF 2F E1";
            }
        }

        private void clearButton_Click(object sender, EventArgs e) //clear button
        {
            selectedHexValues.Text = "--   --   --   --   --   --   --   --";
            selectedHexValues1.Text = "";
            arm32ComboBox.Text = "";
            arm64ComboBox.Text = "";
            floatComboBox.Text = "";
            integerComboBox.Text = "";
            boolComboBox.Text = "";
            arm32ComboBox.Text = "";
            arm64ComboBox.Text = "";
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e) //copy to clipboard
        {
            if (arm32ComboBox.Text == "INT")
            {
                Clipboard.SetText(selectedHexValues1.Text  + "\n" +  selectedHexValues.Text);
            }
            else if (arm32ComboBox.Text == "FLOAT")
            {
                Clipboard.SetText(selectedHexValues1.Text + "\n" + selectedHexValues.Text);
            }
            else if (arm32ComboBox.Text == "NEGATIVE INT")
            {
                Clipboard.SetText(selectedHexValues1.Text + "\n" + selectedHexValues.Text);
            }
            else
            {
                Clipboard.SetText(selectedHexValues.Text);
            }
           
        }

        private void integerComboBox_SelectedIndexChanged_1(object sender, EventArgs e)  //int combo box
        {
            if (integerComboBox.Text == "0 (or false)")
            {
                selectedHexValues.Text = "00 00 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "1 (or true)")
            {
                selectedHexValues.Text = "01 00 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "2")
            {
                selectedHexValues.Text = "02 00 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "7")
            {
                selectedHexValues.Text = "07 00 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "10")
            {
                selectedHexValues.Text = "0A 00 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "15")
            {
                selectedHexValues.Text = "0F 00 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "16")
            {
                selectedHexValues.Text = "10 00 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "17")
            {
                selectedHexValues.Text = "11 00 A0 E3 1E FF 2F E1";

            }
            if (integerComboBox.Text == "999")
            {
                selectedHexValues.Text = "E0 7C 80 D2 C0 03 5F D6";
            }
            if (integerComboBox.Text == "1,000")
            {
                selectedHexValues.Text = "0E 00 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "1,147")
            {
                selectedHexValues.Text = "F6 03 00 AA E1 23 00 91";
            }
            if (integerComboBox.Text == "4,060")
            {
                selectedHexValues.Text = "DC 0F 00 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "10,000")
            {
                selectedHexValues.Text = "01 08 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "120,000")
            {
                selectedHexValues.Text = "DC OF OF E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "1 million")
            {
                selectedHexValues.Text = "01 04 A0 E3 1E FF 2F E1";
            }
            if (integerComboBox.Text == "10 million")
            {
                selectedHexValues.Text = "01 02 A0 E3 1E FF 2F E1";

            }
            if (integerComboBox.Text == "12 million")
            {
                selectedHexValues.Text = "12 07 80 E3 1E FF 2F E1";

            }
        }

        private void integerComboBox_Click(object sender, EventArgs e)
        {
            floatComboBox.Text = "";
            integerComboBox.Text = "";
            boolComboBox.Text = "";
            arm32ComboBox.Text = "";
            arm64ComboBox.Text = "";
            selectedHexValues1.Text = "";
            selectedHexValues.Text = "--   --   --   --   --   --   --   --";
        }

        private void boolComboBox_Click(object sender, EventArgs e)
        {
            floatComboBox.Text = "";
            integerComboBox.Text = "";
            boolComboBox.Text = "";
            arm32ComboBox.Text = "";
            arm64ComboBox.Text = "";
            selectedHexValues1.Text = "";
            selectedHexValues.Text = "--   --   --   --   --   --   --   --";
        }

        private void floatComboBox_Click(object sender, EventArgs e)
        {
            floatComboBox.Text = "";
            integerComboBox.Text = "";
            boolComboBox.Text = "";
            arm32ComboBox.Text = "";
            arm64ComboBox.Text = "";
            selectedHexValues1.Text = "";
            selectedHexValues.Text = "--   --   --   --   --   --   --   --";
        }
        private void arm32ComboBox_Click(object sender, EventArgs e)
        {
            floatComboBox.Text = "";
            integerComboBox.Text = "";
            boolComboBox.Text = "";
            arm32ComboBox.Text = "";
            arm64ComboBox.Text = "";
            selectedHexValues1.Text = "";
            selectedHexValues.Text = "--   --   --   --   --   --   --   --";
        }

        private void arm64ComboBox_Click(object sender, EventArgs e)
        {
            floatComboBox.Text = "";
            integerComboBox.Text = "";
            boolComboBox.Text = "";
            arm32ComboBox.Text = "";
            arm64ComboBox.Text = "";
            selectedHexValues1.Text = "";
            selectedHexValues.Text = "--   --   --   --   --   --   --   --";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("open armconverter.com and under assembly code paste copied code. (it's already copied to your clipboard) \n add your desired number after the '#' symbol like so...  \n Example 1 \n mov r0, #17\n bx lr \n now search under " +"Arm" +" and you you will see the following \n Results in hex code for 17 "+"1100A0E31EFF2FE1"+" \n Example 2 \n mov r0, #47 \n bx lr \n now search under "+"Arm"+" and you you will see the following\n Results hex code for 17 or "+"2F00A0E31EFF2FE1");
            Process.Start("https://armconverter.com/");
            Clipboard.SetText("mov r0, # \n bx lr");

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void floatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (floatComboBox.Text == "1.50")
            {
                selectedHexValues.Text = "C0 0F 43 E3 1E FF 2F E1";
            }
            if (floatComboBox.Text == "1.85")
            {
                selectedHexValues.Text = "EC 0F 43 E3 1E FF 2F E1";
            }
            if (floatComboBox.Text == "40")
            {
                selectedHexValues.Text = "20 02 44 E3 1E FF 2F E1";
            }
            if (floatComboBox.Text == "99")
            {
                selectedHexValues.Text = "C6 02 44 E3 1E FF 2F E1";
            }
            if (floatComboBox.Text == "100")
            {
                selectedHexValues.Text = "C8 02 44 E3 1E FF 2F E1";
            }
            if (floatComboBox.Text == "999/FREEZE")
            {
                selectedHexValues.Text = "7A 04 04 E3 1E FF 2F E1";
            }
            if (floatComboBox.Text == "1000")
            {
                selectedHexValues.Text = "7A 04 44 E3 1E FF 2F E1";
            }
            if (floatComboBox.Text == "2000")
            {
                selectedHexValues.Text = "FA 04 44 E3 1E FF 2F E1";
            }
            if (floatComboBox.Text == "131072.0")
            {
                selectedHexValues.Text = "12 03 A0 E3";
            }
        }

        private void arm32ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (arm32ComboBox.Text == "int 65000")
            {
               selectedHexValues.Text = "mov r0, #65000";
            }
            if (arm32ComboBox.Text == "int 1")
            {
                 selectedHexValues.Text = "mov r0, #1";
            }
            if (arm32ComboBox.Text == "float 131072.0")
            { 
                selectedHexValues.Text = "mov r0, #0x48000000";
            }
            if (arm32ComboBox.Text == "INT")
            {
                selectedHexValues1.Text = "MOV R0,# INT";
                selectedHexValues.Text = "BX LR";
            }
            if (arm32ComboBox.Text == "FLOAT")
            {
                selectedHexValues1.Text = "MOV R0,# FLOAT";
                selectedHexValues.Text = "BX LR";
            }
            if (arm32ComboBox.Text == "NEGATIVE INT")
            {
                selectedHexValues1.Text = "MOV R0,# NEGATIVE INT";
                selectedHexValues.Text = "BX LR";
            }
        }

        private void arm64ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (arm64ComboBox.Text == "RET")
            {
                selectedHexValues.Text = "C0 03 5F D6";
            }
            if (arm64ComboBox.Text == "0 INT/False BOOL")
            {
               selectedHexValues.Text = "20 00 80 D2 C0 03 5F D6";
            }
            if (arm64ComboBox.Text == "1 INT/False BOOL")
            {
               selectedHexValues.Text = "00 00 80 D2 C0 03 5F D6";
            }
            if (arm64ComboBox.Text == "5000 INT")
            {
                selectedHexValues.Text = "00 71 82 D2 C0 03 5F D6";
            }
            if (arm64ComboBox.Text == "0 FLOAT")
            {
                selectedHexValues.Text = "E0 03 27 1E C0 03 5F D6";
            }
            if (arm64ComboBox.Text == "1 FLOAT")
            {
                selectedHexValues.Text = "00 10 2E 1E C0 03 5F D6";
            }
            if (arm64ComboBox.Text == "31 FLOAT")
            {
                selectedHexValues.Text = "00 F0 27 1E C0 03 5F D6";
            }
            if (arm64ComboBox.Text == "NOP CODE")
            {
                selectedHexValues.Text = "C0 03 5F D6";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Credits >>")
            {
                Size = new Size(493, 284);
                button2.Text = "Credits <<";
            }
            else
            {
                Size = new Size(493, 264);
                button2.Text = "Credits >>";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/SliceCast/Game-Guardian-Il2cpp-Script-/blob/main/File/Arm%20Hex%20Values");
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void selectedHexValues_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
