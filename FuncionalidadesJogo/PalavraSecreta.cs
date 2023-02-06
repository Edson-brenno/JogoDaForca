using System;

namespace jogoDaForca.FuncionalidadesJogo{

    public class PalavraSecreta{

        //Attributes
        //Atributos
        public string Palavra {get; private set;} // the word to be discovered by the player; Palavra a ser descoberta pelo jogador

        //Methods
        //Metodos
        
        public PalavraSecreta(){

            this.Palavra = "";
        }
        public void EscolhePalavraSecreta(){ // Will choose the word; Vai escolher a palavra;
 
            string [] linhas = File.ReadAllLines("palavra.txt"); // Will read all lines in the text file palavra.txt; Vai ler todas as linhas no arquivo palavra.txt 

            Random rnd = new Random(); // Instance the class Random

            this.Palavra = linhas[rnd.Next(0,linhas.Length)]; // Chose one word randomly
        }
    }
}