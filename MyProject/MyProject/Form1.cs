namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int count = 100;

        private void button1_Click(object sender, EventArgs e)
        {
            count /= 2;
            label1.Text = "Idk: " + count;
        }

        private int counter2 = 100;
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int sub = int.Parse(txtSubtract.Text);
            counter2 -= sub;
            lblSubtract.Text = "Subtract: " + counter2; ;
        }
    }
}