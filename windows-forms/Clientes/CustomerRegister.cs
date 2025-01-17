using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clientes
{
    internal class CustomerRegister
    {
        private int id;
        private string name;
        private string email;
        private string cpf;
        private string adress;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public bool RegisterCustomer()
        {
            try
            {
                using MySqlConnection mysqlConnection = new(BaseConnect.dbConnect);
                mysqlConnection.Open();

                string insert = "INSERT INTO clientes (nome, email, cpf, endereco) VALUES (@name, @email, @cpf, @adress)";
                using MySqlCommand sqlCommand = mysqlConnection.CreateCommand();
                {
                    sqlCommand.CommandText = insert;
                    sqlCommand.Parameters.AddWithValue(@"name", name);
                    sqlCommand.Parameters.AddWithValue(@"email", email);
                    sqlCommand.Parameters.AddWithValue(@"cpf", cpf);
                    sqlCommand.Parameters.AddWithValue(@"adress", adress);
                    sqlCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados - metodo registerCustomer: ({ex.Message})");
                return false;
            }
        } 
    

        public MySqlDataReader SearchCustomer()
        {
            try
            {
                MySqlConnection mySqlConnection = new(BaseConnect.dbConnect);
                mySqlConnection.Open();

                string select = "select id, nome, email, cpf, endereco from clientes where cpf = @cpf;";

                MySqlCommand sqlCommand = mySqlConnection.CreateCommand();
                sqlCommand.Parameters.AddWithValue(@"cpf", cpf);

                sqlCommand.CommandText = select;
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados - metodo SearchCustomer: ({ex.Message})");
                return null;
            }
        }

        public bool UpdateCustomer()
        {
            try
            {
                using MySqlConnection mySqlConnection = new(BaseConnect.dbConnect);
                mySqlConnection.Open();

                string update = "update clientes set email = @email, endereco = @adress where id = @id;";
                using MySqlCommand sqlCommand = mySqlConnection.CreateCommand();
                {
                    sqlCommand.CommandText = update;
                    sqlCommand.Parameters.AddWithValue(@"email", email);
                    sqlCommand.Parameters.AddWithValue(@"adress", adress);
                    sqlCommand.Parameters.AddWithValue(@"id", id);
                    sqlCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados - metodo UpdateCustomer: ({ex.Message})");
                return false;
            }
        }

        public bool DeleteCustomer()
        {
            try
            {
                using MySqlConnection mySqlConnection = new(BaseConnect.dbConnect);
                mySqlConnection.Open();

                string delete = "delete from clientes where id = @Id;";
                using MySqlCommand sqlCommand = mySqlConnection.CreateCommand();
                {
                    sqlCommand.CommandText = delete;
                    sqlCommand.Parameters.AddWithValue(@"Id", Id);
                    sqlCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados - metodo DeleteCustomer: ({ex.Message})");
                return false;
            }
        }

        public bool CpfVerify()
        {
            try
            {
                using MySqlConnection mySqlConnection = new(BaseConnect.dbConnect);
                mySqlConnection.Open();

                string query = "SELECT COUNT(*) FROM clientes where cpf = @cpf;";
                using MySqlCommand sqlCommand = new(query, mySqlConnection);
                {
                    sqlCommand.Parameters.AddWithValue(@"cpf", cpf);
                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    return count == 0;
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados - metodo CpfVerify: ({ex.Message})");
                return false;
            }
        }
        
    }
}
