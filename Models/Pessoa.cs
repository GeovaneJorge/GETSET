using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public string  Nome 
        {
           get
           {
            return _nome.ToUpper();
           }

           set
           {
            if (value == "")
            {
                //Tratamento se o usuario deixar o nome em branco  o progrma fecha
                throw new ArgumentException("O nome não pode ser vazio .");
            }

            _nome = value;  
           } 

        }

        

        public int Idade
        {
           get =>_idade;

            set
            {
               if (value < 0)
               {
                    //Tratamento se o usuario colocar uma idade menor que 0 o progrma fecha
                    throw new ArgumentException("Idade não pode ser menor que 0");

               } 

               _idade = value;
            }

        }
         


        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

    }
}