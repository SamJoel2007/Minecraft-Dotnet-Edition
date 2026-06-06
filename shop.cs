using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft
{
    public partial class shop : Form
    {
        public shop()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This product is coming soon!!!");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int player_balance = mcData.coins;
            label2.Text = "My Balance: " + player_balance.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mcData.coins += 10;
            label2.Text = "My Balance: " + mcData.coins.ToString();
        }
    }
}
