namespace ForestResourceManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainuiform = new MainUI("admin");
            mainuiform.FormClosed += (s, args) => this.Show();
            mainuiform.Show();
            this.Hide();

        }
    }
}
