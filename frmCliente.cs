using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projeto1GroupBox
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            desabilitarcampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mst_CPF.Clear();
            mst_RG.Clear();
            mst_CEP.Clear();
            txt_logradouro.Clear();
            txt_numero.Clear();
            txt_cidade.Clear();
            cbb_estado.ResetText();
            cbb_uf.ResetText();
            txt_complemento.Clear();
            txt_bairro.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            habilitarcampos();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
           
        }
        private void desabilitarcampos()
        {
          
            txtNome.Enabled = false;
            mst_CPF.Enabled = false;
            mst_RG.Enabled = false;
            mst_CEP.Enabled = false;
            txt_logradouro.Enabled = false;
            txt_numero.Enabled = false;
            txt_cidade.Enabled = false;
            cbb_estado.Enabled = false;
            cbb_uf.Enabled = false;
            txt_complemento.Enabled = false;
            txt_bairro.Enabled = false;
        }
        private void habilitarcampos()
        {
            txtNome.Enabled = true;
            mst_CPF.Enabled = true;
            mst_RG.Enabled = true;
            mst_CEP.Enabled = true;
            txt_logradouro.Enabled = true;
            txt_numero.Enabled = true;
            txt_cidade.Enabled = true;
            cbb_estado.Enabled = true;
            cbb_uf.Enabled = true;
            txt_complemento.Enabled = true;
            txt_bairro.Enabled = true;


        }
    }
}
