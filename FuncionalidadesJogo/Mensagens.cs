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

        
        public void Ganhou(){ //Will be used only if the player win the game; Vai ser utilizada se o jogador ganhar o jogo

            Console.WriteLine("====================================================");
            Console.WriteLine($"          Parabéns {this.username}, você ganhou         ");
            Console.WriteLine("====================================================");
            
        }

        public void Perdeu(){ // Will be executed when the Player lost the game; Vai ser mostrada quando o jogador perder o jogo

            Console.WriteLine("====================================================");
            Console.WriteLine($"          {this.username}, você acabou perdendo :(      ");
            Console.WriteLine("====================================================");
            
        }
    }
}