﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class OrdemProducoes : Conexao
    {
        public int id;

        public int id_empresa;

        public int id_setor;

        public int id_cliente;

        public DateTime data_cadastro;

        public List<OrdemProducoes> GetListaOrdemProducoes()
        {
            List<OrdemProducoes> ordemProducao = new List<OrdemProducoes>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM ordem_producoes";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrdemProducoes novoOrdemProducoes = new OrdemProducoes();

                            novoOrdemProducoes.id               = Convert.ToInt32(reader.GetString("id"));
                            novoOrdemProducoes.id_empresa       = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoOrdemProducoes.id_setor         = Convert.ToInt32(reader.GetString("id_setor"));
                            novoOrdemProducoes.id_cliente       = Convert.ToInt32(reader.GetString("id_cliente"));
                            novoOrdemProducoes.data_cadastro    = DateTime.Parse(reader.GetString("data_cadastro"));

                            ordemProducao.Add(novoOrdemProducoes);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return ordemProducao;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `ordem_producoes` (`id_empresa`, `id_setor`, `id_cliente`) VALUES (@id_empresa, @id_setor, @id_cliente);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@id_setor", this.id_setor),
                new MySqlParameter("@id_cliente", this.id_cliente),
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
