using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class Insumos : Conexao
    {
        public int id;

        public int id_produto;

        public string nome;

        public double quantidade;

        public string unidade;

        public DateTime data_cadastro;

        public string GetInsumosInfo()
        {
            return $"ID: {this.id} \n ID Produto: {this.id_produto} \n Nome: {this.nome} \n Quantidade: {this.quantidade} \n Unidade: {this.unidade} \n Data Cadastro: {this.data_cadastro}";
        }

        public List<Insumos> GetListaInsumos()
        {
            List<Insumos> insumo = new List<Insumos>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM insumos";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Insumos novoInsumos = new Insumos();

                            novoInsumos.id              = Convert.ToInt32(reader.GetString("id"));
                            novoInsumos.id_produto      = Convert.ToInt32(reader.GetString("id_produto"));
                            novoInsumos.nome            = reader.GetString("nome");
                            novoInsumos.quantidade      = Convert.ToDouble(reader.GetString("quantidade"));
                            novoInsumos.unidade         = reader.GetString("unidade");
                            novoInsumos.data_cadastro   = DateTime.Parse(reader.GetString("data_cadastro"));

                            insumo.Add(novoInsumos);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return insumo;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `insumos` (`id_produto`, `nome`, `quantidade`, `unidade`) VALUES (@id_produto, @nome, @quantidade, @unidade);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_produto", this.id_produto),
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@quantidade", this.quantidade),
                new MySqlParameter("@unidade", this.unidade),
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
