using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensyu0513
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            savana.Visible = false;
            oct.Visible = false;
        }

        private void redbutton_Click(object sender, EventArgs e)
        {
            heart.Text = "リドル・ローズハート";
            savana.Visible = true;
        }

        private void savana_Click(object sender, EventArgs e)
        {
            savana.Text = "レオナ・キングスカラー";
            oct.Visible = true;
        }

        private void oct_Click(object sender, EventArgs e)
        {
            oct.Text = "アズール・アーシェングロット";
        }
    }
}
