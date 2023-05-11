using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhao
{
    class Caminhao
    {   
        private string cpf;
        public string CPF
        {
            get { return cpf; }
            set
            {
                if (value.Length == 11)
                    cpf = value;
                else
                    throw new Exception("O CPF deve possuir 11 dígitos");
            }
        }
        public string Nome 
        {
            get { return Nome; }
            set
            {
                if (value.Length > 0)
                    Nome = value;
                else
                    throw new Exception("Nome Inválido");
            }
        }
        public string Sobrenome
        {
            get { return Sobrenome; }
            set
            {
                if (value.Length > 0)
                    Sobrenome = value;
                else
                    throw new Exception("Sobrenome Inválido");
            }
        }
        public string Placa
        {

            get { return Placa; }
            set
            {
                bool placaValida = false;

                if (Placa.Length == 8)
                {
                    if (Char.IsLetter(Placa[0]) && Char.IsLetter(Placa[1]) && Char.IsLetter(Placa[2]) &&
                        Char.IsDigit(Placa[3]) && Char.IsLetter(Placa[4]) && Char.IsLetter(Placa[5]) &&
                        Char.IsDigit(Placa[6]) && Char.IsDigit(Placa[7]))
                    {
                        placaValida = true; 
                    }
                }
                if (placaValida)
                {
                    Console.WriteLine("A placa é válida.");
                }
                else
                {
                    Console.WriteLine("A placa é inválida.");
                }
            }
        }
        public Caminhao(string cpf, string nome, string sobrenome, string placa)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Placa = placa;

        }

    }
}
