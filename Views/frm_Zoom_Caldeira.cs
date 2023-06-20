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
    public partial class frm_Zoom_Caldeira : Form
    {
        public frm_Zoom_Caldeira()
        {
            InitializeComponent();
        }
        public void MontarCaldeira(string NomCaldeira,int NumCaldeira)
        {
            Caldeira.GerarCaldeiraColunas(chart, NomCaldeira, NumCaldeira);
        }
    }
}
