﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaProducao
{
    internal class Clientes : Conexao
    {
        public int id;

        public int id_empresa;

        public string nome;

        public string telefone;

        private string documento;

        public string email;

        public DateTime data_cadastro;

        public void SetDocumento(string documento)
        {
            this.documento = documento;
        }

        public string GetDocumento()
        {
            return this.documento;
        }

        public string GetClientesInfo()
        {
            return $"ID: {this.id} \n ID Empresa: {this.id_empresa} \n Nome: {this.nome} \n Telefone: {this.telefone} \n Documento: {this.documento} \n EMAIL: {this.email} \n Data Cadastro: {this.data_cadastro}";
        }

        public List<Clientes> GetListaClientes()
        {
            List<Clientes> cliente = new List<Clientes>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM clientes";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clientes novoCliente = new Clientes();

                            novoCliente.id = Convert.ToInt32(reader.GetString("id"));
                            novoCliente.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoCliente.nome = reader.GetString("nome");
                            novoCliente.telefone = reader.GetString("telefone");
                            novoCliente.email = reader.GetString("email");
                            novoCliente.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            novoCliente.SetDocumento(reader.GetString("documento"));

                            cliente.Add(novoCliente);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return cliente;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `clientes` (`id_empresa`, `nome`, `telefone`, `documento`, `email`) VALUES (@id_empresa, @nome, @telefone, @documento, @email);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@telefone", this.telefone),
                new MySqlParameter("@documento", this.documento),
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