using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCurriculoAlexandreSantos.Models
{
    public class Curriculo
    {
        //Infromações Pessoais
        public int CurriculoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Sexo Sexo { get; set; }

        // Endereço
        public string Endereco { get; set; }
        public string CEP { get; set; }

        //Contato
        public string Telefone { get; set; }
        public string Celular { get; set; }

        //Conhecimentos
        public bool HTML { get; set; }
        public bool CSS { get; set; }
        public bool JavaScript { get; set; }
        public string MaisConhecimentos { get; set; }

    }
}
