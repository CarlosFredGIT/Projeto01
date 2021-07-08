using Projeto01.Controllers;
using Projeto01.Entities;
using Projeto01.Repositories;
using System;

namespace Projeto01
{
    class Program
    {
        //Metodo que executa o projeto
        static void Main(string[] args)
        {
            var cliente = new Cliente(); //É uma variável com a instancia da classe.
            cliente.Endereco = new Endereco();
            var clienteController = new ClienteController();

            clienteController.InserirDados(cliente);
            clienteController.ImprimirDados(cliente);
            
            //Tentativas
            try
            {
                var clienteRepository = new ClienteRepository();
                clienteRepository.ExportarDados(cliente);

                Console.WriteLine("Arquivo TXT gerado com sucesso!");
            }
            //Printa o erro.
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //pausa o prompt
            Console.ReadKey();
        }
    }
}
