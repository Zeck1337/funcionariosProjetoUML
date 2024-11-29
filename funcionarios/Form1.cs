using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace funcionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonCadasrtrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!textNome.Text.Equals("") && !textEmail.Text.Equals("") && !textEndereco.Text.Equals("") && !textCpf.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Nome = textNome.Text;
                    cadFuncionarios.Email = textEmail.Text;
                    cadFuncionarios.Endereco = textEndereco.Text;
                    cadFuncionarios.Cpf = textCpf.Text;
                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O Funcionario {cadFuncionarios.Nome} foi cadastro com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("favor preencher todos os campos corretamente");
                        textNome.Clear();
                        textEndereco.Clear();
                        textEmail.Clear();
                        textCpf.Clear();
                        textNome.Focus();
                    }


                }
                else
                {
                    MessageBox.Show("favor preencher todos os campos corretamente");
                    textNome.Clear();
                    textEndereco.Clear();
                    textEmail.Clear();
                    textCpf.Clear();
                    textNome.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar usuario funcionario:  " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!textCpf.Equals(""))
                {
                    cadastroFuncionarios cadFuncionario = new cadastroFuncionarios();
                    cadFuncionario.Cpf = textCpf.Text;

                    MySqlDataReader reader = cadFuncionario.localizarFuncionario();
                    if (reader != null) {
                        if(reader.HasRows) {
                            reader.Read();
                            showID.Text = reader["id"].ToString();
                            textNome.Text = reader["nome"].ToString();
                            textEndereco.Text = reader["endereco"].ToString();
                            textEmail.Text = reader["email"].ToString();                      


                        }

                        else {
                            MessageBox.Show("funcionario nao encontrado");
                            textNome.Clear();
                            textEndereco.Clear();
                            textEmail.Clear();
                            textCpf.Clear();
                            textCpf.Focus();
                            showID.Text = "";
                        }
                    }
                    else {
                        MessageBox.Show("funcionario nao encontrado");
                        textNome.Clear();
                        textEndereco.Clear();
                        textEmail.Clear();
                        textCpf.Clear();
                        textCpf.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher Campo CPF para realizar Pesquisa");
                    textNome.Clear();
                    textEndereco.Clear();
                    textEmail.Clear();
                    textCpf.Clear();
                    textCpf.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar funcionario" + ex.Message);
            }
        }
    }
}
