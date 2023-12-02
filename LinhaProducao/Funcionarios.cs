using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class Funcionarios : Conexao
    {
        public int id;

        public int id_empresa;

        public string nome;

        public string email;

        private string senha;

        private int nivel;

        public bool logado = false;

        public DateTime data_cadastro;

        public void SetSenha(string senha)
        {
            //this.senha = BCrypt.Net.BCrypt.HashPassword(senha, BCrypt.Net.BCrypt.GenerateSalt());
            this.senha = senha;
        }

        public string GetSenha()
        {
            return this.senha;
        }
        public void SetNivel(int nivel)
        {
            this.nivel = nivel;
        }

        public int GetNivel()
        {
            return this.nivel;
        }

       /* public string GetFuncionariosInfo()
        {
            return $"ID: {this.id} \n ID Empresa: {this.id_empresa} \n Nome: {this.nome} \n EMAIL: {this.email} \n Senha: {this.senha} \n Nível: {this.nivel} \n Data Cadastro: {this.data_cadastro}";
        }*/

        public Funcionarios getFuncionariosPorEmailESenha() 
        {

            try
            {
                OpenConnection();

                string query = "SELECT * FROM funcionarios WHERE email = '"+ this.email + "' AND senha = '"+ this.senha +"';";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.id     = Convert.ToInt32(reader.GetString("id"));
                            this.nome   = reader.GetString("nome");
                            this.email  = reader.GetString("email");
                            this.SetNivel(Convert.ToInt32(reader.GetString("nivel")));

                            this.logado = true;
                            
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return this;
        }

        public List<Funcionarios> GetListaFuncionarios()
        {
            List<Funcionarios> funcionario = new List<Funcionarios>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM funcionarios";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcionarios novoFuncionarios = new Funcionarios();

                            novoFuncionarios.id             = Convert.ToInt32(reader.GetString("id"));
                            novoFuncionarios.id_empresa     = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoFuncionarios.nome           = reader.GetString("nome");
                            novoFuncionarios.email          = reader.GetString("email");
                            novoFuncionarios.data_cadastro  = DateTime.Parse(reader.GetString("data_cadastro"));

                            novoFuncionarios.SetSenha(reader.GetString("senha"));
                            novoFuncionarios.SetNivel(reader.GetInt32("nivel"));

                            funcionario.Add(novoFuncionarios);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return funcionario;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `funcionarios` (`id_empresa`, `nome`, `email`, `senha`, `nivel`) VALUES (@id_empresa, @nome, @email, @senha, @nivel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@email", this.email),
                new MySqlParameter("@senha", this.senha),
                new MySqlParameter("@nivel", this.nivel),
                };

                this.ExecuteQueryWithParameters(query, param);

                return true;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
    }
}
