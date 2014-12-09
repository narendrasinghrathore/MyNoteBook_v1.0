using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNoteBook_v1._0
{
    public partial class ForTestingOutputValues : Form
    {
        public ForTestingOutputValues()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Getting Time in AM/PM format 
            //label1.Text = System.DateTime.Now.ToString("HH:mm:ss tt");
            label1.Text = System.DateTime.Now.ToLongDateString();
        }
    }
}
