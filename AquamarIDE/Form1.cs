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


namespace AquamarIDE
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

                }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fileDialog.FileName;
                MessageBox.Show(fileDialog.SafeFileName + " has been loaded");
                ReadTextFile(textBox1.Text);
            }
    
            



        }
        public void ReadTextFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                {
                    string line;
                    StringBuilder builder = new StringBuilder();
                    while ((line = reader.ReadLine()) != null)
                    {
                        builder.Append(line);
                    }
                    reader.Close();
                    textBox1.Text = builder.ToString();
                    
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveFileDialog1.FileName;
            File.WriteAllText(fileName, textBox1.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

                Form2 newForm = new Form2();
                newForm.Show();

        }





        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
            pictureBox1.BackColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            textBox1.BackColor = colorDialog2.Color;
        }
    }
}