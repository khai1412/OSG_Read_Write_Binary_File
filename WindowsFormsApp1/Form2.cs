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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = tb_file_name_create.Text;
            if (!File.Exists(fileName))
            {
                File.Create(fileName+comboBox1.Text).Dispose();
                string content = tb_content_file_create.Text;
                File.WriteAllText(Path.GetFullPath(fileName+comboBox1.Text), content);
                MessageBox.Show("create success!");

            } else
            {
                MessageBox.Show("this file has been exists");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            string fileName = "";
            if (f.ShowDialog() == DialogResult.OK)
            {
                fileName = f.FileName;
            }
            tb_file_path_read.Text = fileName;
            //FileStream f1= new FileStream(fileName, FileMode.Open, FileAccess.Read);
            tb_content_file_read.Text = File.ReadAllText(fileName);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string content = tb_content_file_read.Text;
            //@"C:\Users\admin\OneDrive\Desktop\Ghi chú\export file.txt"
            File.WriteAllText(tb_file_path_read.Text,content);
            MessageBox.Show("update success");
        }
    }
}
