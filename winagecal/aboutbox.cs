using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winagecal
{
    public partial class aboutbox : Form
    {
        public aboutbox()
        {
            InitializeComponent();
        }

        private void ok_button(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
