using System;
using System.Collections.Generic;
using System.Text;

//Localização da classe no projeto
namespace Projeto01.Entities
{
    //Declaração da classe
    public class Endereco
    {
        //Atributos
        public Guid IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
