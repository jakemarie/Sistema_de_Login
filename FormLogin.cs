using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = textUsuario.Text;
            string senha = textSenha.Text;

            if (CadastroUsuario.login(nome, senha))
            {
                this.Close();

            }
            else 
            {
                MessageBox.Show("Acesso Negado!");
                textUsuario.Text = "";
                textSenha.Text = "";
                textUsuario.Focus();
                textSenha.Focus();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
