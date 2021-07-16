using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desafio
{
    class Jogo
    {
        Heroi heroi;//inicia a criação do objeto
        public void Iniciar()
        {
            Console.WriteLine("Digite o nome para seu personagem :");
            heroi = new(Console.ReadLine());//cria um novo objeto passando direto o nome como parametro 
            Menu();
        }

        public void Menu()
        {
            Console.Clear();
            MostrarInfo();
            Console.WriteLine("Deseja lutar com qual monstro ?");
            Console.WriteLine("1-> Orc");
            Console.WriteLine("2-> Troll");
            Console.WriteLine("3-> Goblin");
            Console.WriteLine("");
            Console.WriteLine("Digite 0 para sair do jogo");

            switch (Console.ReadLine().ToUpper())
            {
                case "1":
                case "orc":
                    Batalhar(new Monstros("Orc", heroi.Nivel * 2, heroi.Nivel));
                    break;
                case "2":
                case "Troll":
                    Batalhar(new Monstros("Troll", heroi.Nivel * 5, heroi.Nivel));
                    break;
                case "3":
                case "Goblin":
                    Batalhar(new Monstros("Goblin", heroi.Nivel * 10, heroi.Nivel));
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
                
            }
            Console.WriteLine("Pressione qualquer tecla para continuar ...");

        }
         public void Batalhar(Monstros monstro)
        {
            Console.Clear();
            MostrarInfo();
            Console.WriteLine($"Monstro encontrado : {monstro.nome} - Ataque");
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Olá {heroi.Nome}");
            Console.WriteLine($"Seu nível é: {heroi.Nivel}");
            Console.WriteLine($"Sua Experiencia é: {heroi.Experiencia}");
            Console.WriteLine($"Seu ataque é:  {heroi.Ataque}");
            Console.WriteLine($"Seu ataque base é: {heroi.AtaqueBase}");
            Console.WriteLine($"Sua vida é: {heroi.Vida}");
           
        }
    }
}
