using System.Drawing.Text;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Clientes
{
    public partial class RegisterBtn : Form
    {

        public RegisterBtn()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!nameBox.Text.Equals("") && !emailBox.Text.Equals("") && !cpfBox.Text.Equals("") && !adressBox.Text.Equals(""))
                {

                    CustomerRegister regCustomer = new()
                    {
                        Name = nameBox.Text,
                        Email = emailBox.Text,
                        Cpf = cpfBox.Text,
                        Adress = adressBox.Text
                    };

                    if (regCustomer.CpfVerify())
                    {
                        if (emailBox.Text.Contains('@'))
                        {
                            if (!Regex.IsMatch(nameBox.Text, @"[^a-zA-Z ]") && regCustomer.RegisterCustomer())
                            {
                                MessageBox.Show("Cliente cadastrado com sucesso!");
                                CleanFields();
                                nameBox.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Digite um nome valido");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Digite um email Valido");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Este cliente já existe");
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos corretamente para concluir o cadastro.");
                    CleanFields();
                    nameBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: ({ex.Message})");
            }
        }

        private void SearchBtt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cpfBox.Text.Equals(""))
                {
                    CustomerRegister regCustomer = new()
                    {
                        Cpf = cpfBox.Text
                    };

                    MySqlDataReader reader = regCustomer.SearchCustomer();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            IdBox.Text = reader["id"].ToString();
                            nameBox.Text = reader["nome"].ToString();
                            emailBox.Text = reader["email"].ToString();
                            adressBox.Text = reader["endereco"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado");
                            CleanFields();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado");
                        CleanFields();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha o CPF corretamente para continuar a pesquisa");
                    CleanFields();
                    cpfBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao encontrar o cliente: ({ex.Message})");
            }
        }

        private void UpdateBtt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!nameBox.Text.Equals("") && !emailBox.Text.Equals("") && !cpfBox.Text.Equals("") && !adressBox.Text.Equals(""))
                {

                    CustomerRegister regCustomer = new()
                    {
                        Id = int.Parse(IdBox.Text),
                        Name = nameBox.Text,
                        Email = emailBox.Text,
                        Cpf = cpfBox.Text,
                        Adress = adressBox.Text

                    };
                    string currentName = string.Empty;
                    string currentCpf = string.Empty;

                    using MySqlDataReader reader = regCustomer.SearchCustomer();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            currentName = reader["nome"].ToString();
                            currentCpf = reader["cpf"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dados necessarios não encontrados");
                    }

                    if (!cpfBox.Text.Equals(currentCpf) || !nameBox.Text.Equals(currentName))
                    {
                        MessageBox.Show("Nome e CPF não podem ser alterados");
                    }

                    else if (emailBox.Text.Contains('@'))
                    {
                        if (regCustomer.UpdateCustomer())
                        {
                            MessageBox.Show("Os dados foram atualizados!");
                            CleanFields();
                        }

                        else
                        {
                            MessageBox.Show("Não foi possivel atualizar as informações do cliente");
                            CleanFields();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Digite um email valido");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, especifique o cliente antes de atualizar suas informações");
                    CleanFields();
                    cpfBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar dados do cliente: ({ex.Message})");
            }
        }

        private void DeleteBtt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cpfBox.Text.Equals("") && !emailBox.Text.Equals("") && !adressBox.Text.Equals("") && !nameBox.Text.Equals(""))
                {
                    CustomerRegister regCustomer = new()
                    {
                        Id = int.Parse(IdBox.Text)
                    };

                    if (regCustomer.DeleteCustomer())
                    {
                        MessageBox.Show("Os dados do cliente foram deletados com sucesso");
                        CleanFields();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel exluir os dados do cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, especifique qual cliente deseja excluir");
                    CleanFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar os dados do cliente: ({ex.Message})");
            }
        }
        private void CleanFields()
        {
            IdBox.Text = "";
            nameBox.Clear();
            emailBox.Clear();
            cpfBox.Clear();
            adressBox.Clear();
        }
    }
}