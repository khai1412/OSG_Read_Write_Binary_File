using System;
using System.Collections;
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
            BinaryWriter binWriter = new BinaryWriter(new FileStream(file_path, FileMode.Create, FileAccess.Write));
              
            binWriter.Write(text);
            binWriter.Close();
               
            

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

            try
            {
                byte[] bytes;
                using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    bytes = new byte[file.Length];
                    file.Read(bytes, 0, (int)file.Length);
                }
                BitArray bits = new BitArray(bytes);
                BinaryReader br;
                var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                string read = br.ReadString();
                if (read != null)
                {
                    tb_Content_File_Read.Text = read;
                }
                else
                {
                    MessageBox.Show("cannot open this file because this file is empty");
                }
                fs.Close();
                br.Close();

            }
            catch
            {
                MessageBox.Show("error cannot open this file");

            }
   
               
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (BinaryWriter biwriter = new BinaryWriter(new FileStream(tb_File_Path.Text, FileMode.Open, FileAccess.Write)))
                {
                    biwriter.Write(tb_Content_File_Read.Text);
                }
                MessageBox.Show("update successful!");
            }
            catch
            {
                MessageBox.Show("cannot update this file");
            }
           
        }
    }
}
