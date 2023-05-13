using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smackdown_vs_Raw_2009_Save_Editer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "SAVE.DAT";

        public void Read(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                sr.BaseStream.Position = 0x2716A;
                textBox1.Text = sr.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BLUS30194_SAVE|SAVE.DAT";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));
                var decrypted = br.BaseStream.Position = 0x004319D0;  // decrypted save
                var encrypted = br.BaseStream.Position = 0x39F7C002;  // Encrypted Save 

                
            }
        }
    }
}
