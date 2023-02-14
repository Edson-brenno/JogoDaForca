using System;

namespace jogoDaForca.FuncionalidadesJogo{

    public class Mensagem{
        
        //attributes
        //atributos

        private string username;

        //Constructor
        //Construtor

        public Mensagem(string username){

            this.username = username;
        }
        
        //Methods
        //Metodos

        
        public void Ganhou(string username){ //Will be used only if the player win the game; Vai ser utilizada se o jogador ganhar o jogo

            Console.WriteLine("====================================================");
            Console.WriteLine($"          Parabéns {username}, você ganhou         ");
            Console.WriteLine("====================================================");
            
        }

        public void Perdeu(string username){ // Will be executed when the Player lost the game; Vai ser mostrada quando o jogador perder o jogo

            Console.WriteLine("====================================================");
            Console.WriteLine($"          {username}, você acabou perdendo :(      ");
            Console.WriteLine("====================================================");
            
        }
    }
}