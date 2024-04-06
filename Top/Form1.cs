using System.Windows.Forms;

namespace Top
{
    public partial class Form1 : Form
    {
        int menu = 0;
        int mn1=0, mn2=0, mn3 = 0;

        public Form1()
        {
            InitializeComponent();
            panelCalculo.Visible = false;
            btCalcular.Enabled = false;
            numEntrada1.ValueChanged += numEntrada1_ValueChanged;
            numEntrada2.ValueChanged += numEntrada2_ValueChanged;
            numEntrada3.ValueChanged += numEntrada3_ValueChanged;
        }

        private void btVelocidadeMedia_Click(object sender, EventArgs e)
        {
            panelCalculo.Visible = true;
            lblEntrada3.Visible = false;
            numEntrada3.Visible = false;
            lblResultado.Visible = false;
            lblEntrada1.Text = "Deslocamento(m):";
            lblEntrada2.Text = "Tempo(s):";
            lblNomeResultado.Text = "Velocidade média:";
            menu = 1;
            mn3 = 1;
        }
        private void numEntrada1_ValueChanged(object sender, EventArgs e)
        {
            if (numEntrada1.Value == 0)
            {
                btCalcular.Enabled = false;
                mn1 = 0;
            }
            else
            {
                mn1 = 1;
                if (mn1 == 1 && mn2 == 1 && mn3 == 1)
                    btCalcular.Enabled = true;
            }
        }

        private void numEntrada2_ValueChanged(object sender, EventArgs e)
        {
            if (numEntrada2.Value == 0)
            {
                btCalcular.Enabled = false;
                mn2 = 0;
            }
            else
            {
                mn2 = 1;
                if (mn1 == 1 && mn2 == 1 && mn3 == 1)
                    btCalcular.Enabled = true;
            }
        }

        private void numEntrada3_ValueChanged(object sender, EventArgs e)
        {
            if (numEntrada3.Value == 0)
            {
                btCalcular.Enabled = false;
                mn3 = 0;
            }
            else
            {
                mn3 = 1;
                if (mn1 == 1 && mn2 == 1 && mn3 == 1)
                    btCalcular.Enabled = true;
            }
        }

        private void btAceleracao_Click(object sender, EventArgs e)
        {
            panelCalculo.Visible = true;
            lblEntrada3.Visible = false;
            numEntrada3.Visible = false;
            lblResultado.Visible = false;
            lblEntrada1.Text = "Velocidade(m/s):";
            lblEntrada2.Text = "Tempo(s):";
            lblNomeResultado.Text = "Aceleração:";
            menu = 2;
            mn3 = 1;
        }

        private void btMovimentoUniforme_Click(object sender, EventArgs e)
        {
            panelCalculo.Visible = true;
            lblEntrada3.Visible = true;
            numEntrada3.Visible = true;
            lblResultado.Visible = false;
            lblEntrada1.Text = "Posição inicial(m):";
            lblEntrada2.Text = "Velocidade(m/s):";
            lblEntrada3.Text = "Tempo(s):";
            lblNomeResultado.Text = "Posição final:";
            menu = 3;
        }

        private void btTorricelli_Click(object sender, EventArgs e)
        {
            panelCalculo.Visible = true;
            lblEntrada3.Visible = true;
            numEntrada3.Visible = true;
            lblResultado.Visible = false;
            lblEntrada1.Text = "Velocidade inicial(m/s):";
            lblEntrada2.Text = "Aceleração(m/s^2):";
            lblEntrada3.Text = "Deslocamento(m):";
            lblNomeResultado.Text = "Velocidade final:";
            menu = 4;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            switch (menu)
            {
                case 1:
                    double deslocamento = (double)numEntrada1.Value;
                    double tempo = (double)numEntrada2.Value;
                    double vel = deslocamento / tempo;
                    lblResultado.Visible = true;
                    lblResultado.Text = vel.ToString() + " m/s";
                    break;
                case 2:
                    double velocidade = (double)numEntrada1.Value;
                    double temp = (double)numEntrada2.Value;
                    double aceleracao = velocidade / temp;
                    lblResultado.Visible = true;
                    lblResultado.Text = aceleracao.ToString() + " m/s^2";
                    break;
                case 3:
                    double velo = (double)numEntrada2.Value;
                    double pi = (double)numEntrada1.Value;
                    double tem = (double)numEntrada3.Value;
                    double pf = (velo*tem) +pi;
                    lblResultado.Visible = true;
                    lblResultado.Text = pf.ToString() + " m";
                    break;
                case 4:
                    double vi = (double)numEntrada1.Value;
                    double a = (double)numEntrada2.Value;
                    double desloc = (double)numEntrada3.Value;
                    double vf = Math.Sqrt(Math.Pow(vi, 2) + 2 * a * desloc);
                    lblResultado.Visible = true;
                    lblResultado.Text = vf.ToString() + " m/s";
                    break;
            }
        }
    }
}
