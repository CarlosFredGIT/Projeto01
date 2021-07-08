using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//Localização da classe no projeto
namespace Projeto01.Repositories
{
    //Declaração da classe
    public class ClienteRepository
    {
        //Metodo que recebe informação do usuário
        public void InserirDados(Cliente cliente)
        {
            cliente.IdCliente = Guid.NewGuid();//Gera um ID hexadecimal 
            
            Console.Write("Informe o nome do cliente...................: ");
            cliente.Nome = Console.ReadLine();
            
            Console.Write("Informe o e-mail do cliente.................: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Informe o CPF do cliente....................: ");
            cliente.Cpf = Console.ReadLine();
            
            Console.Write("Informe a data de nascimento do cliente.....: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            cliente.Endereco.IdEndereco = Guid.NewGuid();
            
            Console.Write("Informe o logradouro do cliente.............: ");
            cliente.Endereco.Logradouro = Console.ReadLine();

            Console.Write("Informe o numero do cliente.................: ");
            cliente.Endereco.Numero = Console.ReadLine();

            Console.Write("Informe o bairro do cliente.................: ");
            cliente.Endereco.Bairro = Console.ReadLine();

            Console.Write("Informe o cidade do cliente.................: ");
            cliente.Endereco.Cidade = Console.ReadLine();

            Console.Write("Informe o estado do cliente.................: ");
            cliente.Endereco.Estado = Console.ReadLine();

            Console.Write("Informe o cep do cliente....................: ");
            cliente.Endereco.Cep = Console.ReadLine();
        }

        //Metodo de imprimir no prompt
        public void ImprimirDados(Cliente cliente)
        {
            Console.WriteLine("\n ******** DADOS DO CLIENTE ******** \n");

            Console.WriteLine("ID do cliente....................: " + cliente.IdCliente);
            Console.WriteLine("Nome do cliente..................: " + cliente.Nome);
            Console.WriteLine("E-mail do cliente................: " + cliente.Email);
            Console.WriteLine("CPF do cliente...................: " + cliente.Cpf);
            Console.WriteLine("Data de nascimento do cliente....: " + cliente.DataNascimento);

            Console.WriteLine("\n ******** DADOS DO ENDERECO ******** \n");
            Console.WriteLine("\tID do endereco.................: " + cliente.Endereco.IdEndereco);
            Console.WriteLine("\tLogradouro do cliente..........: " + cliente.Endereco.Logradouro);
            Console.WriteLine("\tNumero do cliente..............: " + cliente.Endereco.Numero);
            Console.WriteLine("\tBairro do cliente..............: " + cliente.Endereco.Bairro);
            Console.WriteLine("\tCidade do cliente..............: " + cliente.Endereco.Cidade);
            Console.WriteLine("\tEstado do cliente..............: " + cliente.Endereco.Estado);
            Console.WriteLine("\tCep do cliente.................: " + cliente.Endereco.Cep);
            Console.WriteLine("\n");

            Console.WriteLine("\n");
        }

        //Metodo para gerar um doc TXT com as infomrações do cliente
        public void ExportarDados(Cliente cliente)
        {
            using (var streamWriter = new StreamWriter("c:\\temp\\cliente.txt"))
            {
                streamWriter.WriteLine("********* DADOS DO CLIENTE *********");
                streamWriter.WriteLine("ID do cliente....................: " + cliente.IdCliente);
                streamWriter.WriteLine("Nome do cliente..................: " + cliente.Nome);
                streamWriter.WriteLine("E-mail do cliente................: " + cliente.Email);
                streamWriter.WriteLine("CPF do cliente...................: " + cliente.Cpf);
                streamWriter.WriteLine("Data de nascimento do cliente....: " + cliente.DataNascimento);
                streamWriter.WriteLine("\n");
                streamWriter.WriteLine("\t********* DADOS DO ENDERECO DO CLIENTE *********");
                streamWriter.WriteLine("\tID do endereco.................: " + cliente.Endereco.IdEndereco);
                streamWriter.WriteLine("\tLogradouro do cliente..........: " + cliente.Endereco.Logradouro);
                streamWriter.WriteLine("\tNumero do cliente..............: " + cliente.Endereco.Numero);
                streamWriter.WriteLine("\tBairro do cliente..............: " + cliente.Endereco.Bairro);
                streamWriter.WriteLine("\tCidade do cliente..............: " + cliente.Endereco.Cidade);
                streamWriter.WriteLine("\tEstado do cliente..............: " + cliente.Endereco.Estado);
                streamWriter.WriteLine("\tCep do cliente.................: " + cliente.Endereco.Cep);

                streamWriter.Close();
            }
        }
    }
}
