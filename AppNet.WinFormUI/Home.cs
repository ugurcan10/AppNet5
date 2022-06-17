namespace AppNet.WinFormUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings St = new Settings();
            St.Show();

        }
    }
}