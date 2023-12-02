using LinhaProducao.Views;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaginaLogin());



            /*Clientes cliente = new Clientes();

            foreach (Clientes clientes in cliente.GetListaClientes())
            {
                Console.WriteLine(cliente.GetClientesInfo());
                Console.WriteLine("---------------------------");
            }


            Funcionarios funcionario = new Funcionarios();

            foreach (Funcionarios funcionarios in funcionario.GetListaFuncionarios())
            {
                Console.WriteLine(funcionarios.GetFuncionariosInfo());
                Console.WriteLine("---------------------------");
            }


            Empresas empresa = new Empresas();

            foreach (Empresas empresas in empresa.GetListaEmpresas())
            {
                Console.WriteLine(empresa.GetEmpresasInfo());
                Console.WriteLine("---------------------------");
            }

            
            Etapas etapa = new Etapas();

            foreach (Etapas etapas in etapa.GetListaEtapas())
            {
                Console.WriteLine(etapa.GetEtapasInfo());
                Console.WriteLine("---------------------------");
            }


            Insumos insumo = new Insumos();

            foreach (Insumos insumos in insumo.GetListaInsumos())
            {
                Console.WriteLine(insumo.GetInsumosInfo());
                Console.WriteLine("---------------------------");
            }


            LinhaProducoes linhaProducao = new LinhaProducoes();

            foreach (LinhaProducoes linhaProducoes in linhaProducao.GetListaLinhaProducoes())
            {
                Console.WriteLine(linhaProducao.GetLinhaProducoesInfo());
                Console.WriteLine("---------------------------");
            }


            OrdemProducoes ordemProducao = new OrdemProducoes();

            foreach (OrdemProducoes ordemProducoes in ordemProducao.GetListaOrdemProducoes())
            {
                Console.WriteLine(ordemProducao.GetOrdemProducoesInfo());
                Console.WriteLine("---------------------------");
            }


            OrdemProducoesTemProduto ordemProducaoTemProduto = new OrdemProducoesTemProduto();

            foreach (OrdemProducoesTemProduto ordemProducoesTemProduto in ordemProducaoTemProduto.GetListaOrdemProducoesTemProduto())
            {
                Console.WriteLine(ordemProducaoTemProduto.GetOrdemProducoesTemProdutoInfo());
                Console.WriteLine("---------------------------");
            }


            Processos processo = new Processos();

            foreach (Processos processos in processo.GetListaProcessos())
            {
                Console.WriteLine(processo.GetProcessosInfo());
                Console.WriteLine("---------------------------");
            }


            Produtos produto = new Produtos();

            foreach (Produtos produtos in produto.GetListaProdutos())
            {
                Console.WriteLine(produto.GetProdutosInfo());
                Console.WriteLine("---------------------------");
            }


           Setores setor = new Setores();

            foreach (Setores setores in setor.GetListaSetores())
            {
                Console.WriteLine(setor.GetSetoresInfo());
                Console.WriteLine("---------------------------");
            }*/

            //MessageBox.Show("certo");
        }
    }
}
