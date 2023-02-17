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
            int add = int.Parse(txtAddBox.Text);
            count += add;
            label1.Text = "Sum: " + count;     
        }
    }
}