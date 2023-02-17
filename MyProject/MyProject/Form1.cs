namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int count = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            count *= 2;
            label1.Text = "Idk: " + count;     
        }
    }
}