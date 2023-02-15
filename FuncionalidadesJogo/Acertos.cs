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

        public bool AcertouLetras(char letra, string palavra){

            int acertos = 0;

            foreach(char c in palavra){
                
                if (c == letra){

                    acertos++;

                }
            }

            if (acertos > 0){
                
                AcrescentaAcertos(acertos);

                return true;
            }
            else{

                return false;
                
            }
        }

        public bool JaVenceu(int tamanhoPalavraSecreta){
            
            if (this.TotalAcertos == tamanhoPalavraSecreta){
                
                this.Venceu = true;

                return true;
            }
            else{

                return false;
            }
    
        }

    }
}