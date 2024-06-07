using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arraylist_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Bilişim");
            liste.Add('b');
            liste.Add(100);
            liste.Remove('b');
            foreach (object i in liste)
            {
                listBox1.Items.Add(i);
            }
            {

            }
        }
    }
}
