using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquamarIDE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            OpenFileDialog fileDialoge = new OpenFileDialog();
            if (fileDialoge.ShowDialog() == DialogResult.OK)
            {
               
                webBrowser1.Navigate(fileDialoge.FileName);


            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
