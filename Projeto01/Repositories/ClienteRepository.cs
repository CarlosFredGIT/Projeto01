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
        public void ExportarDados(Cliente cliente)
        {
            var path = $"c:\\temp\\cliente_{cliente.IdCliente}.txt";

            using (var streamWriter = new StreamWriter(path))
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
