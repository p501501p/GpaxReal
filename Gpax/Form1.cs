namespace Gpax
{
    public partial class Form1 : Form
    {
        Gpaxcalculator gpaxCalculator;
        public Form1()
        {
            InitializeComponent();
            gpaxCalculator = new Gpaxcalculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(this.TBGpa.Text);
                gpaxCalculator.setGPA(input);
                this.TBGpax.Text = gpaxCalculator.getGPAX().ToString();
                this.TBMax.Text = gpaxCalculator.getmax().ToString();
                this.TBMin.Text = gpaxCalculator.getmin().ToString();
            }
            catch
            {
                MessageBox.Show("pls enter Number");
                this.TBGpa.Text = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
