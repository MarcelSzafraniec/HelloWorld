namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMain.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelMain.Text = (Convert.ToInt32(labelMain.Text) + 1).ToString();
        }
    }
}