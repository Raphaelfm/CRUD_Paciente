using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // inserir esta linha

namespace CRUD_Paciente
{
    internal class FazerLogin
    {
        public string login { get; set; }
        public string senha { get; set; }

        public ConexaoBanco banco = new ConexaoBanco();

        public string verificarLogin()
        {
            this.banco.conectar();
            try
            {
                MySqlDataReader reader = this.banco.Query("SELECT * FROM login WHERE usuario='" + this.login + "' AND senha='" + this.senha + "'");

                if (reader.Read())
                {
                    return "aceito";
                }
                else
                {
                    return "negado";
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("ERRO ao fazer a verificação na base da dados");
            }
            this.banco.close();
            return "negado";
        }
    }
}
