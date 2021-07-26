using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myToDoListProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                Form1.Frm2Title = textBox1.Text;
                Form1.Frm2Desc = textBox2.Text;
                Form1.Frm2DT = dateTimePicker1.Value;
                Form1.RefreshDB = true;
                Hide();
            }
            else
            {
                MessageBox.Show("Fill both Title and Description fields!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
