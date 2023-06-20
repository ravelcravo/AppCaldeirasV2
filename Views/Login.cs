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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "admin" && txtUsuario.Text == "admin")
            {
                frm_Home f = new frm_Home();
                f.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos","Acesso negado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
