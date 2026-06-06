namespace Minecraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            play play_mc = new play();
            play_mc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shop marketplace = new shop();
            marketplace.Show();
            this.Hide();
        }
    }
}
