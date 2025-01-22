namespace MachKalkulatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string torlonyomas = textBox1.Text;
            string statikusNyomas =textBox2.Text;

            double torlo, statikus;

            double.TryParse(torlonyomas, out torlo);
            double.TryParse(statikusNyomas, out statikus);

            listBox1.Text = torlonyomas;
            listBox1.Text = statikusNyomas;
            
        }
    }
}
