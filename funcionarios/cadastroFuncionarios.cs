using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace funcionarios
{
    internal class cadastroFuncionarios
    {
        private int id;
        private string nome = string.Empty;
        private string email = string.Empty;
        private string cpf = string.Empty;
        private string endereco = string.Empty;


        public int Id
            { 
            get { return id; } 
            set {  id = value; }                
        }
        public string Nome
            { get { return nome; } set { nome = value; } }
        public string Email
            { get { return email; } set { email = value; } }
        public string Cpf
            { get { return cpf; } set { cpf = value; } }
        public string Endereco
            { get { return endereco; }  set { endereco = value; } }


        public bool cadastrarFuncionarios()


        {

            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string insert = $" insert into funcionarios (nome,email,cpf,Endereco) values ('{Nome}','{Email}','{Cpf}','{Endereco}')";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no banco de dados, Metados cadastrar usuario" + ex.Message);
                return false;
            }
        }
      
        public MySqlDataReader localizarFuncionario()
        {
            try
            {
               
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select id, nome, email, cpf, endereco from funcionarios where cpf = '{Cpf}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar Funcionario" + ex.Message);
                return null;
                
            }

        }
    }
}
