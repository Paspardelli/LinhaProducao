using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class OrdemProducoesTemProdutos : Conexao
    {
        public int id;

        public int id_ordem;

        public int id_produto;

        public int quantidade;

        public DateTime data_cadastro;

        public string GetOrdemProducoesTemProdutoInfo()
        {
            return $"ID: {this.id} \n ID Ordem: {this.id_ordem} \n ID Produto: {this.id_produto} \n Quantidade: {this.quantidade} \n Data Cadastro: {this.data_cadastro}";
        }

        public List<OrdemProducoesTemProdutos> GetListaOrdemProducoesTemProduto()
        {
            List<OrdemProducoesTemProdutos> ordemProducaoTemProduto = new List<OrdemProducoesTemProdutos>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM ordem_producoes_tem_produtos";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrdemProducoesTemProdutos novoOrdemProducoesTemProduto = new OrdemProducoesTemProdutos();

                            novoOrdemProducoesTemProduto.id             = Convert.ToInt32(reader.GetString("id"));
                            novoOrdemProducoesTemProduto.id_ordem       = Convert.ToInt32(reader.GetString("id_ordem"));
                            novoOrdemProducoesTemProduto.id_produto     = Convert.ToInt32(reader.GetString("id_produto"));
                            novoOrdemProducoesTemProduto.quantidade     = Convert.ToInt32(reader.GetString("quantidade"));
                            novoOrdemProducoesTemProduto.data_cadastro  = DateTime.Parse(reader.GetString("data_cadastro"));

                            ordemProducaoTemProduto.Add(novoOrdemProducoesTemProduto);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return ordemProducaoTemProduto;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `ordem_producoes_tem_produtos` (`id_ordem`, `id_produto`, `quantidade`) VALUES (@id_ordem, @id_produto, @quantidade);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_ordem", this.id_ordem),
                new MySqlParameter("@id_produto", this.id_produto),
                new MySqlParameter("@quantidade", this.quantidade),
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
