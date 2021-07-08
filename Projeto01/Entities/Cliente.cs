using System;
using System.Collections.Generic;
using System.Text;

//Localização da classe no projeto
namespace Projeto01.Entities
{
    //Declaração da classe
    public class Cliente
    {
        //Atributos
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        #region Associação
            public Endereco Endereco { get; set; }
        #endregion
    }
}
