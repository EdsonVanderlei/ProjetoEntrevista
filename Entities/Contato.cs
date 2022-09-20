using System;
using System.Collections.Generic;
using System.Text;
using RH.Entities.Enum;

namespace RH.Entities
{
    internal class Contato
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Relacao Relacao { get; set; }

        public Contato(int codigo, string nome, string telefone, Relacao relacao)
        {
            Codigo = codigo;
            Nome = nome;
            Telefone = telefone;
            Relacao = relacao;
        }


        public override string ToString()
        {
            return $"{Codigo} {Nome} {Telefone} {Relacao}\n";
        }

    }
}
