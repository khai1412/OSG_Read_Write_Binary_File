
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_file_name_create = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_file_path_read = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_content_file_read = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_content_file_create = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE FILE TEXT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "CREATE FILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_file_name_create
            // 
            this.tb_file_name_create.Location = new System.Drawing.Point(146, 75);
            this.tb_file_name_create.Name = "tb_file_name_create";
            this.tb_file_name_create.Size = new System.Drawing.Size(100, 22);
            this.tb_file_name_create.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "OPEN FILE TEXT";
            // 
            // tb_file_path_read
            // 
            this.tb_file_path_read.Location = new System.Drawing.Point(428, 126);
            this.tb_file_path_read.Name = "tb_file_path_read";
            this.tb_file_path_read.Size = new System.Drawing.Size(206, 22);
            this.tb_file_path_read.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "OPEN FILE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_content_file_read
            // 
            this.tb_content_file_read.Location = new System.Drawing.Point(338, 178);
            this.tb_content_file_read.Multiline = true;
            this.tb_content_file_read.Name = "tb_content_file_read";
            this.tb_content_file_read.Size = new System.Drawing.Size(296, 208);
            this.tb_content_file_read.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "FILE NAME";
            // 
            // tb_content_file_create
            // 
            this.tb_content_file_create.Location = new System.Drawing.Point(12, 154);
            this.tb_content_file_create.Multiline = true;
            this.tb_content_file_create.Name = "tb_content_file_create";
            this.tb_content_file_create.Size = new System.Drawing.Size(288, 232);
            this.tb_content_file_create.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ENTER CONTENT FILE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "FILE PATH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "EDIT FILE";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "UPDATE THIS FILE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ".doc",
            ".txt",
            ".docx"});
            this.comboBox1.Location = new System.Drawing.Point(252, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_content_file_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_content_file_read);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_file_path_read);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_file_name_create);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_file_name_create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_file_path_read;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_content_file_read;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_content_file_create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}