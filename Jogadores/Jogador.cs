using System;

namespace jogoDaForca.Jogadores{

    public class Jogador{

        // Attributes
        // Atributos
        public string Nickname {get; private set;} // Will achieve the player Nickname

        // Method
        // Metodos:
        
        public Jogador(string nickname){

            this.Nickname = nickname;
        }
        
    }
}