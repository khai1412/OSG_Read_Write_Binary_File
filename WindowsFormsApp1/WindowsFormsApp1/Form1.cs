using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = tb_Content_File_Write.Text;
            string file_name = tb_File_Name.Text;
            if (!File.Exists(file_name))
            {
                File.Create(file_name+".bin").Dispose();
                MessageBox.Show("create success !");
            } else
            {
                MessageBox.Show("this file name has exist !");
            }
            string file_path = Path.GetFullPath(file_name+".bin");
            using (BinaryWriter binWriter =
                new BinaryWriter(File.Open(file_path, FileMode.Create)))
            {  
                binWriter.Write(text);
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            string fileName = "";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                
                fileName = dlg.FileName;
                
            }
            tb_File_Path.Text = fileName;
            BinaryReader br;
            try
            {
                br = new BinaryReader(new FileStream(fileName, FileMode.Open));
            }
            catch 
            {
                Console.WriteLine("Cannot open file.");
                return;
            }
            string read = br.ReadString();
            if (read != null)
            {
                tb_Content_File_Read.Text = br.ReadString();
            } else
            {
                MessageBox.Show("Cannot read this file");
            }
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
