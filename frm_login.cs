using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Paciente
{
    public partial class Frm_login : Form
    {
        FazerLogin entrada = new FazerLogin();
        public Frm_login()
        {
            InitializeComponent();
        }
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            entrada.login = txt_usuario.Text;
            entrada.senha = txt_senha.Text;

            if (entrada.verificarLogin() == "aceito")
            {
                frm_menu form = new frm_menu();
                this.Hide();      //esconde o formulario de login
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos", "Erro ao Entrar no Sistema");
            }
        }
    }
}
