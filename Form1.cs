namespace count_click
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            this.Click += Form1_Click;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = $"Кількість кліків: {count/2}";
        }
    }
}