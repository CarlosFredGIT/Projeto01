using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto01.Controllers
{
    public class ClienteController
    {
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
    }
}
