using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class LinhaProducoes : Conexao
    {
        public int id;

        public string nome;
        
        public int id_empresa;

        public int id_setor;

        public int id_responsavel;

        public DateTime data_cadastro;

        public string GetLinhaProducoesInfo()
        {
            return $"ID: {this.id} \n  \n Nome: {this.nome} \n ID Empresa: {this.id_empresa} ID Setor: {this.id_setor} \n ID Responsavel: {this.id_responsavel} \n Data Cadastro: {this.data_cadastro}";
        }

        public List<LinhaProducoes> GetListaLinhaProducoes()
        {
            List<LinhaProducoes> linhaProducao = new List<LinhaProducoes>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM linha_producoes";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LinhaProducoes novoLinhaProducoes = new LinhaProducoes();

                            novoLinhaProducoes.id               = Convert.ToInt32(reader.GetString("id"));
                            novoLinhaProducoes.nome             = reader.GetString("nome");
                            novoLinhaProducoes.id_empresa       = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoLinhaProducoes.id_setor         = Convert.ToInt32(reader.GetString("id_setor"));
                            novoLinhaProducoes.id_responsavel   = Convert.ToInt32(reader.GetString("id_responsavel"));
                            novoLinhaProducoes.data_cadastro    = DateTime.Parse(reader.GetString("data_cadastro"));

                            linhaProducao.Add(novoLinhaProducoes);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return linhaProducao;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `linha_producoes` (`nome`, `id_empresa`, `id_setor`, `id_responsavel`) VALUES (@nome, @id_empresa, @id_setor, @id_responsavel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@id_setor", this.id_setor),
                new MySqlParameter("@id_responsavel", this.id_responsavel),
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
