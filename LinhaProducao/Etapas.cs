using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class Etapas : Conexao
    {
        public int id;

        public string nome;

        public int ordem;

        public int id_processo;

        public DateTime data_cadastro;


        public string GetEtapasInfo()
        {
            return $"ID: {this.id} \n Nome: {this.nome} \n Ordem: {this.ordem} \n ID Processo: {this.id_processo} \n Data Cadastro: {this.data_cadastro}";
        }

        public List<Etapas> GetListaEtapas()
        {
            List<Etapas> etapa = new List<Etapas>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM etapas";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Etapas novaEtapas = new Etapas();

                            novaEtapas.id               = Convert.ToInt32(reader.GetString("id"));
                            novaEtapas.nome             = reader.GetString("nome");
                            novaEtapas.ordem            = Convert.ToInt32(reader.GetString("ordem"));
                            novaEtapas.id_processo      = Convert.ToInt32(reader.GetString("id_processo"));
                            novaEtapas.data_cadastro    = DateTime.Parse(reader.GetString("data_cadastro"));

                            etapa.Add(novaEtapas);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return etapa;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `etapas` (`nome`, `ordem`, `id_processo`) VALUES (@nome, @ordem, @id_processo);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@ordem", this.ordem),
                new MySqlParameter("@id_processo", this.id_processo),
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
