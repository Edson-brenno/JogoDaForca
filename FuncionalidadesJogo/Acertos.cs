using System;

namespace jogoDaForca.FuncionalidadesJogo{

    public class Acerto{

        //Attributes
        //Atributos
        public int TotalAcertos {get; private set;} // Has the Total of hits; Contém o total de Acertos

        public bool Venceu {get; private set;} // If the player wins will receive True; Caso o jogador ganhe vai recever True
        
        //Methods:
        //Metodos:

        private void AcrescentaAcertos(int TotalAcertos){ // Will increase the total of hits; Vai acrescentar o total de acertos

            this.TotalAcertos += TotalAcertos;

        }

        public bool AcertouPalavras(char letra, int tamanhoPalavraSecreta){

            return true;
        }

        public void Ganhou(string username){

            Console.WriteLine("====================================================");
            Console.WriteLine($"          Parabéns {username}, você ganhou         ");
            Console.WriteLine("====================================================");
            
        }

    }
}