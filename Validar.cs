using RH.Entities.Enum;
using System;

using System.Text.RegularExpressions;

namespace RH
{
    internal class Validar
    {
        private static Regex _email = new Regex("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$");
        private static Regex _numero = new Regex("^\\(?(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])\\)? ?(?:[2-8]|9[1-9])[0-9]{3}\\-?[0-9]{4}$");

       
        public static string ValidarEmail()
        {
            
            string email;
            while (true)
            {
                Console.Write("Digite seu email Modelo(email@domain.com) ");
                email = Console.ReadLine();

                if (_email.IsMatch(email))
                {
                    return email;
                }
                Console.Write("Email Inválido !");

            }
        }

        public static string ValidarNumero()
        {

            string numero;
            while (true)
            {

                Console.Write("Digite seu Numero Modelo (11 99999-9999) ");
                numero = Console.ReadLine();

                if (_numero.IsMatch(numero))
                {
                    return numero;
                }
                Console.Write("Número Inválido !");

            }
        }

        public static int ValidarInteiro(string mensagem)
        {
            while (true)
            {
                try
                {
                    Console.Write(mensagem);
                    int codigo = int.Parse(Console.ReadLine());
                    return codigo;
                }
                catch (Exception e)
                {
                    Console.Write("Ocorreu um Erro" + e.Message);
                }

            
            }
        }

        public static Relacao ValidarRelacao()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite seu parentesco: ");
                    return Enum.Parse<Relacao>(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um Erro" + e.Message);
                }


            }
        }



    }
}
