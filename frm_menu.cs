using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //inserir esta linha

namespace CRUD_Paciente
{
    public partial class frm_menu : Form
    {
        //código que permite o efeito de marcação e captura por onde o mouse passar nos botões da tela.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frm_menu()
        {
            InitializeComponent();
        }
        //método generico para abrir formulários no panel de conteúdo
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = pnl_conteudo.Controls.OfType<Forms>().FirstOrDefault();
            {
                if (formulario == null)
                {
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    pnl_conteudo.Controls.Add(formulario);
                    pnl_conteudo.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                }
                else
                {
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }
                    formulario.BringToFront();
                }
            }
        }
        private void btn_sair_menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restaurar.Visible = true;
        }
        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }
        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btn_paciente_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frm_paciente>();
        }
        private void btn_relatorios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frm_relatorios>();
        }
    }
}
