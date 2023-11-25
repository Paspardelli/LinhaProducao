using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class Empresas : Conexao
    {
        public int id;

        public string nome;

        public string cnpj;

        public string email;

        public DateTime data_cadastro;

        public string GetEmpresasInfo()
        {
            return $"ID: {this.id} \n Nome: {this.nome} \n CNPJ: {this.cnpj} \n EMAIL: {this.email} \n Data Cadastro: {this.data_cadastro}";
        }

        public List<Empresas> GetListaEmpresas()
        {
            List<Empresas> empresa = new List<Empresas>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM empresas";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empresas novoEmpresas = new Empresas();

                            novoEmpresas.id             = Convert.ToInt32(reader.GetString("id"));
                            novoEmpresas.nome           = reader.GetString("nome");
                            novoEmpresas.cnpj           = reader.GetString("cnpj");
                            novoEmpresas.email          = reader.GetString("email");
                            novoEmpresas.data_cadastro  = DateTime.Parse(reader.GetString("data_cadastro"));

                            empresa.Add(novoEmpresas);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return empresa;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `empresas` (`nome`, `cnpj`, `email`) VALUES (@nome, @cnpj, @email);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@cnpj", this.cnpj),
                new MySqlParameter("@email", this.email),
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
