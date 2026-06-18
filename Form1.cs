namespace Lock_X
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool izinVer = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ESC ile şifre girme menüsü açılır. Varsayılan şifre 123456'dır.", "Lock X - Kullanım");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                izinVer = true;
                this.Hide();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!izinVer && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
