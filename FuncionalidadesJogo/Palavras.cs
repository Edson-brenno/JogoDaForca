using System;

namespace jogoDaForca.FuncionalidadesJogo{

    public class Palavra{

        //Attributes
        //Atributos
        public string PalavraSecreta {get; private set;} // the word to be discovered by the player; Palavra a ser descoberta pelo jogador

        public int TamanhoPalavraSecreta {get; private set;} // Will have the length of the word; Vai ter o tamanho da palavra

        public string PalavraDescoberta {get; private set;} // will have the words which have been discovered by the player; Vai ter a palavra descoberta pelo jogador

        public char[] LetrasUtilizadas {get; private set;} // Will have the letters that had been used; Vai ter as letras já utilizadas

        //Methods
        //Metodos
        
        public Palavra(){

            this.PalavraSecreta = "";
            this.PalavraDescoberta = "";
            this.LetrasUtilizadas = new char[50];
        }
        public void EscolhePalavraSecreta(){ // Will choose the word; Vai escolher a palavra;
 
            string [] linhas = File.ReadAllLines("palavra.txt"); // Will read all lines in the text file palavra.txt; Vai ler todas as linhas no arquivo palavra.txt 

            Random rnd = new Random(); // Instance the class Random

            this.PalavraSecreta =  linhas[rnd.Next(0,linhas.Length)].ToUpper(); // Chose one word randomly
        }

        public void SetarTamanhoPalavra(){ // will set the size of the word; Vai setar o tamanho da palavra

            this.TamanhoPalavraSecreta = this.PalavraSecreta.Length;
        }

        public void IniciarPalavraDescoberta(){ // Will set the Word to be discovered with -; Vai setar a palavra secreta com -

            string palavraDescoberta = new string('-', this.TamanhoPalavraSecreta);

            this.PalavraDescoberta = palavraDescoberta;

        }

        public bool IsLetraValidaParaUso(char letra){ // Verify if the letter is valid; Verifica se a letra passa é valida

            if (this.LetrasUtilizadas.Length > 0){
                
                foreach (char c in this.LetrasUtilizadas){

                    if (letra == c){


                        return false;

                    }
                }

            }
            
            return true;
        }

        public void AdicionarLetraUtilizada(char letra){ // Append a new letter to the Used Letters

            this.LetrasUtilizadas = this.LetrasUtilizadas.Append(letra).ToArray();
            
        }

        // public void SetaLetrasAcertadas()



    }
}