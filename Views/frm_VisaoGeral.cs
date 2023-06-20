using AppCaldeirasV2.Views;
using System;
using System.Windows.Forms;

namespace AppCaldeirasV2
{
    public partial class frm_VisaoGeral : Form
    {
        Banco banco = new Banco();
        public frm_VisaoGeral()
        {
            InitializeComponent();

        }

        private void Frm_Metricas_Load(object sender, EventArgs e)
        {
            GeraGraficos();
            timer_Atualizao.Start();
            timer_HoraAtual.Start();
            lblAtualizacao.Visible = false;
            label2.Visible = false;
        }

        public void GeraGraficos()
        {
            try
            {
                Caldeira.GerarCaldeiraColunas(caldeira01, "caldeira01",01);
                Caldeira.GerarCaldeiraColunas(caldeira02, "caldeira02",02);
                Caldeira.GerarCaldeiraColunas(caldeira03, "caldeira03",03);
                Caldeira.GerarCaldeiraColunas(caldeira04, "caldeira04",04);

                lblAtualizacao.Text = DateTime.Now.ToString().Substring(0, 16);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:: " + ex);
            }

        }

        private void timer_HoraAtual_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString().Substring(0, 19);


        }

        private void timer_Atualizao_Tick(object sender, EventArgs e)
        {
            lblAtualizacao.Text = DateTime.Now.ToString().Substring(0, 16);
            GeraGraficos();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void caldeira01_Click(object sender, EventArgs e)
        {
            frm_Zoom_Caldeira frm = new frm_Zoom_Caldeira();
            frm.MontarCaldeira("caldeira01",01);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void caldeira02_Click(object sender, EventArgs e)
        {
            frm_Zoom_Caldeira frm = new frm_Zoom_Caldeira();
            frm.MontarCaldeira("caldeira02",02);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void caldeira03_Click(object sender, EventArgs e)
        {
            frm_Zoom_Caldeira frm = new frm_Zoom_Caldeira();
            frm.MontarCaldeira("caldeira03",03);
            frm.Dock = DockStyle.Fill;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            
        }

        private void caldeira04_Click(object sender, EventArgs e)
        {
            frm_Zoom_Caldeira frm = new frm_Zoom_Caldeira();
            frm.MontarCaldeira("caldeira04",04);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
