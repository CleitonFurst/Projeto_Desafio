using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desafio
{
    public class Heroi
    {   
        
        
        public string Nome { get; set; }
        public int Experiencia { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int AtaqueBase { get; set; }
        public int Ataque { get; set; }
        public Heroi(string nome)
        {
            Random randint = new Random();
            this.Nome = nome;
            this.Experiencia = 0;
            this.Nivel = 1;
            this.Vida = 10;
            this.AtaqueBase = randint.Next(1, 11);
            this.Ataque = this.AtaqueBase;

        }

        public void ganhar()
        {

        }
        

    }
}
