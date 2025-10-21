using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1GroupBox
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario = txtUsuario.Text;
            senha = Convert.ToInt32(txtSenha.Text);

            if(usuario=="admin" & senha == 123)
            {
                frmCliente abrir = new frmCliente();
                abrir.Show();
                this.Hide();
            }
            else{
                MessageBox.Show("Usuario ou Senha incorretos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }
    }
}
