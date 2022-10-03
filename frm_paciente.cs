using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //inserir esta linha

namespace CRUD_Paciente
{
    public partial class frm_paciente : Form
    {
        private Endereco endereco = new Endereco();
        private Paciente paciente = new Paciente();
        private ConexaoBanco banco = new ConexaoBanco();

        string sexo = "";
        string id_endereco = "";
        public frm_paciente()
        {
            InitializeComponent();
            atualizarDataGrid();
            limparCampos();
        }
        private void frm_paciente_Load(object sender, EventArgs e)
        {
            atualizarDataGrid();
            limparCampos();
        }
        private void atualizarDataGrid()
        {
            MySqlDataReader temp = paciente.listarPaciente();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtv_paciente.DataSource = dt;
        }
        private void limparCampos()
        {
            txt_id_paciente.Clear();
            txt_nome.Text = "";
            mtb_data.Text = "";
            rbt_feminino.Checked = false;
            rbt_masculino.Checked = false;
            this.sexo = "";
            mtb_cpf.Text = "";
            mtb_celular.Text = "";
            txt_email.Text = "";
            
            txt_logradouro.Text = "";
            txt_numero.Text = "";
            txt_complemento.Text = "";
            txt_bairro.Text = "";
            mtb_cep.Text = "";
            txt_municipio.Text = "";
            txt_uf.Text = "";
            txt_filtro.Text = "";
            this.id_endereco = "";
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && mtb_data.Text != "" && mtb_cpf.Text != "" 
                && mtb_cep.Text != "")
            {
                //ENDERECO
                this.endereco.setLogradouro(txt_logradouro.Text);
                this.endereco.setNumero(txt_numero.Text);
                this.endereco.setComplemento(txt_complemento.Text);
                this.endereco.setBairro(txt_bairro.Text);
                this.endereco.setMunicipio(txt_municipio.Text);
                this.endereco.setUf(txt_uf.Text);
                this.endereco.setCep(mtb_cep.Text);
                this.endereco.cadastrarEndereco();

                //PACIENTE                
                this.paciente.setNome(txt_nome.Text);
                this.paciente.setDt_nasc(mtb_data.Text);
                this.paciente.setSexo(this.sexo);
                this.paciente.setCpf(mtb_cpf.Text);
                this.paciente.setCelular(mtb_celular.Text);
                this.paciente.setEmail(txt_email.Text);
                this.paciente.setId_endereco(this.endereco.getId_endereco());
                this.paciente.cadastrarPaciente();

                MessageBox.Show("Cadastro realizado com sucesso!");
                limparCampos();
            }
            else
            {
                MessageBox.Show("Preencha os campos obrigtórios.");
            }
            atualizarDataGrid();
            limparCampos();
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
            limparCampos();
        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //PACIENTE
            this.paciente.setId_paciente(int.Parse(txt_id_paciente.Text));
            this.paciente.setNome(txt_nome.Text);
            this.paciente.setDt_nasc(mtb_data.Text);
            this.paciente.setSexo(this.sexo);
            this.paciente.setCpf(mtb_cpf.Text);
            this.paciente.setCelular(mtb_celular.Text);
            this.paciente.setEmail(txt_email.Text);
            this.paciente.alterarPaciente();

            //ENDEREÇO
            this.endereco.setId_endereco(int.Parse(this.id_endereco));
            this.endereco.setLogradouro(txt_logradouro.Text);
            this.endereco.setNumero(txt_numero.Text);
            this.endereco.setComplemento(txt_complemento.Text);
            this.endereco.setBairro(txt_bairro.Text);
            this.endereco.setMunicipio(txt_municipio.Text);
            this.endereco.setUf(txt_uf.Text);
            this.endereco.setCep(mtb_cep.Text);
            this.endereco.alterarEndereco();

            MessageBox.Show("Alteração realizada com sucesso!");
            limparCampos();
            atualizarDataGrid();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            String filtro = txt_filtro.Text;
            MySqlDataReader temp = this.paciente.listarPacientePorOk(filtro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtv_paciente.DataSource = dt;
        }

        private void dtv_paciente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int linhaAtual = 0;
            linhaAtual = dtv_paciente.CurrentRow.Index;
            try
            {
                txt_id_paciente.Text = dtv_paciente[0, linhaAtual].Value.ToString();
                txt_nome.Text = dtv_paciente[1, linhaAtual].Value.ToString();
                mtb_data.Text = dtv_paciente[2, linhaAtual].Value.ToString();
                this.sexo = dtv_paciente[3, linhaAtual].Value.ToString();
                if (this.sexo == "F")
                {
                    rbt_feminino.Checked = true;
                }
                else
                {
                    if (this.sexo == "M")
                    {
                        rbt_masculino.Checked = true;
                    }
                    else
                    {
                        rbt_feminino.Checked = false;
                        rbt_masculino.Checked = false;
                    }
                }
                mtb_cpf.Text = dtv_paciente[4, linhaAtual].Value.ToString();
                mtb_celular.Text = dtv_paciente[5, linhaAtual].Value.ToString();
                txt_email.Text = dtv_paciente[6, linhaAtual].Value.ToString();
                this.id_endereco = dtv_paciente[7, linhaAtual].Value.ToString();
                txt_logradouro.Text = dtv_paciente[8, linhaAtual].Value.ToString();
                txt_numero.Text = dtv_paciente[9, linhaAtual].Value.ToString();
                txt_complemento.Text = dtv_paciente[10, linhaAtual].Value.ToString();
                txt_bairro.Text = dtv_paciente[11, linhaAtual].Value.ToString();
                txt_municipio.Text = dtv_paciente[12, linhaAtual].Value.ToString();
                txt_uf.Text = dtv_paciente[13, linhaAtual].Value.ToString();
                mtb_cep.Text = dtv_paciente[14, linhaAtual].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ERRO no preenchimento dos dados.");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover Cliente?", "Confirmar", MessageBoxButtons.
                YesNoCancel) == DialogResult.Yes)
            {
                if (txt_id_paciente.Text != "")
                {
                    this.endereco.setId_endereco(int.Parse(this.id_endereco));
                    this.paciente.setId_paciente(int.Parse(txt_id_paciente.Text));

                    this.endereco.excluirEndereco();
                    this.paciente.excluirPaciente();
                    atualizarDataGrid();
                    limparCampos();
                }
            }
        }
        private void rbt_feminino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "F";
        }
        private void rbt_masculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "M";
        }
    }
}
