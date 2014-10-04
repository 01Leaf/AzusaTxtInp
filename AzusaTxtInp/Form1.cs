using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AzusaTxtInp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //configurate global hotkeys
            int id = 0;     // The id of shift space 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Shift, Keys.Space.GetHashCode());
           

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("INPUT(\""+ System.Web.HttpUtility.UrlEncode(textBox1.Text)+"\")");
                textBox1.Text = "";
                this.Hide();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                textBox1.Text = "";
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.Hide();
        }


    }
}
