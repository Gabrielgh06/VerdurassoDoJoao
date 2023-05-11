using System;
using System.Text;

namespace Produtos
{
    class Produto
    {
        private string nome;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Length > 1)
                    nome = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Nome do produto deve ter pelo menos 2 caracteres.");
                }
            }
        }

        public double Preco { get; set; } // Propriedade automática

        public int Estoque { get; private set; } // Fora dessa classe o atributo Estoque só pode ser lido e não modificado = lido em qualquer lugar, escrito dentro da classe 

        public Produto(string nome, double preco) // Criação de um contrutor BOLADO
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Estoque = 0;
        }

        public int Vender(int qtde)
        {
            if (this.Estoque - qtde >= 0)
                this.Estoque -= qtde;
            return this.Estoque;
        }
        public int Comprar(int qtde)
        {
            this.Estoque += qtde;
            return this.Estoque;
        }

        public string DetalhesProduto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nNome: {this.Nome}\n");
            sb.Append($"Preço: {this.Preco}\n");
            sb.Append($"Estoque: {this.Estoque}\n");
            return sb.ToString();
        }
    }


    // Código de validação de CPF -- melhorar -->  só aceitar números
    //string _cpf;
    //public string CPF
    //{
    //    get
    //    {
    //        return this._cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
    //    }
    //    set
    //    {
    //        string temp = value.Replace(".", "").Replace("-", "").Trim();
    //        if (temp.Length == 11)
    //            this._cpf = temp;
    //        else
    //            Console.WriteLine("CPF inválido");
    //    }
    //}

}
