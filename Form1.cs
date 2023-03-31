namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateG_Click(object sender, EventArgs e)
        {
            decimal Q, G, T, t1, t2;
            if (!decimal.TryParse(txtQ.Text, out Q))
            {
                MessageBox.Show("Invalid value for Q.");
                return;
            }
            if (!decimal.TryParse(txtT1G.Text, out t1))
            {
                MessageBox.Show("Invalid value for t1.");
                return;
            }
            if (!decimal.TryParse(txtT2G.Text, out t2))
            {
                MessageBox.Show("Invalid value for t2.");
                return;
            }
            T = t1 - t2;
            G = Q / (1.163m * T);
            decimal L = G * 1000;
            for (int i = 1; i <= 100; i++)
            {
                progressBar1.Value = i;
            }
            txtResultG.Text = "G = " + G.ToString() + " м3/ч";
            txtGLitres.Text = "G = " + L.ToString() + " л/ч";
        }

        private void btnCalculateQ_Click(object sender, EventArgs e)
        {
            decimal Q, G, T, t1, t2;
            if (!decimal.TryParse(txtG.Text, out G))
            {
                MessageBox.Show("Invalid value for G.");
                return;
            }
            if (!decimal.TryParse(txtT1Q.Text, out t1))
            {
                MessageBox.Show("Invalid value for t1.");
                return;
            }
            if (!decimal.TryParse(txtT2Q.Text, out t2))
            {
                MessageBox.Show("Invalid value for t2.");
                return;
            }
            T = t1 - t2;
            Q = G * (1.163m * T);
            decimal Qgkal = Q / 1163;
            for (int i = 1; i <= 100; i++)
            {
                progressBar2.Value = i;
            }
            txtResultQ.Text = "Q = " + Q.ToString() + " к¬т";
            txtQGkal.Text = "Q = " + Qgkal.ToString() + " √кал/ч";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}