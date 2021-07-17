using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desafio
{
    public class Monstros
    {

        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Experiencia { get; set; }
        public int Ataque { get; set; }
        public Monstros(string nome, int vida, int ataque)
        {
            this.Nome = nome;
            this.Vida = vida;
            this.Experiencia = vida + ataque;
            this.Ataque = ataque;

        }
        
    }
}
