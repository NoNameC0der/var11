// Разработал студент группы 143 - Александр Здойма.
namespace _11Var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 1.1
        {
            double Y = 0, N = 0, D = 0;
            Y = Convert.ToDouble(textBox1.Text);
            N = Convert.ToDouble(textBox2.Text);
            D = Math.Pow(Y, 2) + ((0.5 * N) + 4.8) / Math.Sin(Y);
            textBox3.Clear();
            textBox3.Text += D;
        }
        private void button2_Click(object sender, EventArgs e) // 1.2
        {
            double BC = 0, AD = 0, H = 0, S = 0, P = 0, D = 0, C = 0;
            BC = Convert.ToDouble(textBox4.Text);
            AD = Convert.ToDouble(textBox5.Text);
            H = Convert.ToDouble(textBox6.Text);
            D = (BC - AD) / 2;
            C = Math.Sqrt(Math.Pow(H, 2) + Math.Pow(D, 2));
            P = BC + AD + 2 * C;
            S = 0.5 * (BC + AD) * H;
            textBox7.Clear();
            textBox7.Text += S;
            textBox8.Clear();
            textBox8.Text += P;
        }
        private void button3_Click(object sender, EventArgs e) // 1.3
        {
            int Number = 0, a = 0, b = 0, sum = 0;
            Number = Convert.ToInt32(textBox9.Text);
            a = Number / 1000 % 10;
            b = Number / 10 % 10;
            sum = a + b;
            textBox10.Clear();
            textBox10.Text += sum;
        }
    }
}