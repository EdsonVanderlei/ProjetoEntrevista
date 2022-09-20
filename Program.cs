
using RH.Entities;
using RH.Entities.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int n = Validar.ValidarInteiro("Quantos Funcionários ?");
              


            for (int i = 0; i < n; i++)
            {


                int codigo = Validar.ValidarInteiro("Digite o Codigo: ");

                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                string email = Validar.ValidarEmail();
                string numero = Validar.ValidarNumero();



                Funcionario x = new Funcionario(codigo, nome, email, numero);


                




                n = Validar.ValidarInteiro("Quantos Contatos ?");
                for (int j = 0; j < n; j++)
                {
                    codigo = Validar.ValidarInteiro("Digite o Codigo: ");
                    Console.Write("Digite o nome: ");
                    nome = Console.ReadLine();
                    numero = Validar.ValidarNumero();

                    Relacao relacao = Validar.ValidarRelacao();

                    x.AdicionarContato(codigo,nome,numero,relacao);

                }



                Console.WriteLine(x.ToString());
             

            }

        }

    }
}

