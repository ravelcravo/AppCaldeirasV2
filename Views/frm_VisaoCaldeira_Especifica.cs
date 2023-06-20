using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCaldeirasV2.Views
{
    public partial class frm_VisaoCaldeira_Especifica : Form
    {
        public string NomCaldeira;
        public int NumCaldeira;
        
        public frm_VisaoCaldeira_Especifica()
        {
            InitializeComponent();
        }

        private string ReplaceCaldeira(string Texto)
        {
            switch (Texto)
            {
                case "caldeira01":
                    Texto = "Caldeira01";
                    break;
                case "caldeira02":
                    Texto = "Caldeira02";
                    break;
                case "caldeira03":
                    Texto = "Caldeira03";
                    break;
                case "caldeira04":
                    Texto = "Caldeira04";
                    break;

            }

            return Texto;
        }
        public void MontarGrafico(string _Caldeira,int NumCaldeira)
        {
            lblTitulo.Text = "Wallboard de Acompanhamento - " + ReplaceCaldeira(_Caldeira);
            Caldeira.GerarMediaIndicadores(ch_Media, _Caldeira, NumCaldeira);
            Caldeira.GerarTimeLine(ch_Temperatura, _Caldeira, NumCaldeira, "Temperatura", Color.FromArgb(192, 57, 43));
            Caldeira.GerarTimeLine(ch_Agua, _Caldeira, NumCaldeira, "NivelAgua", Color.FromArgb(41, 128, 185));
            Caldeira.GerarTimeLine(ch_Combustivel, _Caldeira, NumCaldeira, "NivelCombustivel", Color.FromArgb(211, 84, 0));
            Caldeira.GerarTimeLine(ch_pressao, _Caldeira, NumCaldeira, "Pressao", Color.FromArgb(52, 73, 94));
        }

        private void frm_VisaoCaldeira_Especifica_Load(object sender, EventArgs e)
        {
            MontarGrafico(NomCaldeira, NumCaldeira);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MontarGrafico(NomCaldeira, NumCaldeira);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.ExportarParaExcel(NomCaldeira);
        }
    }
}
