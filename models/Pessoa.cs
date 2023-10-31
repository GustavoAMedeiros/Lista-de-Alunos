using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propsMetEConstructor.models
{
    public class Pessoa
    {

        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Name = nome;
            Sobrenome = sobrenome;
        }
        private string _name;
        private int _idade;

        public string Name 
        { 
            //body expression para dar return do valor em caixa alta
            get => _name.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _name = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Name} {Sobrenome}".ToUpper();

        public int Idade 
        { 
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não válida.");
                }

                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} tenho {Idade} anos.");
        }
    }
}