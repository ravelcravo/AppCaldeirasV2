using AppCaldeirasV2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCaldeirasV2
{
    public partial class frm_Home : MetroFramework.Forms.MetroForm
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void btMonitoramento_Click(object sender, EventArgs e)
        {
            frm_VisaoGeral f = new frm_VisaoGeral();
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btCaldeira01_Click(object sender, EventArgs e)
        {
            frm_VisaoCaldeira_Especifica f = new frm_VisaoCaldeira_Especifica();
            f.NumCaldeira = 01;
            f.NomCaldeira = "caldeira01";
            f.Dock = DockStyle.Fill;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
            Cursor.Current = Cursors.Default;
        }

        private void btCaldeira02_Click_1(object sender, EventArgs e)
        {
            frm_VisaoCaldeira_Especifica f = new frm_VisaoCaldeira_Especifica();
            f.NumCaldeira = 02;
            f.NomCaldeira = "caldeira02";
            f.Dock = DockStyle.Fill;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
            Cursor.Current = Cursors.Default;
        }

        private void btCaldeira03_Click_1(object sender, EventArgs e)
        {
            frm_VisaoCaldeira_Especifica f = new frm_VisaoCaldeira_Especifica();
            f.NumCaldeira = 03;
            f.NomCaldeira = "caldeira03";
            f.Dock = DockStyle.Fill;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
            Cursor.Current = Cursors.Default;
        }

        private void btCaldeira04_Click_1(object sender, EventArgs e)
        {
            frm_VisaoCaldeira_Especifica f = new frm_VisaoCaldeira_Especifica();
            f.NumCaldeira = 04;
            f.NomCaldeira = "caldeira04";
            f.Dock = DockStyle.Fill;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
            Cursor.Current = Cursors.Default;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento.", "Nova Caldeira", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento.", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
