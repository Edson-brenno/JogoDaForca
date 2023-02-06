using System;

namespace jogoDaForca.Jogo{

    public class Tentativa{

        //Atributes
        //Atributos
        private bool enforcou = false; // Case the player Lost will be true otherwise is False; Caso o jogador perca irá ser true caso contrario vai ser false
        public int TotalTentativasRestantes {get; private set;} // Remaining attempts ; Total de tentativas restantes 

        //Methods:
        //Metodos:

        public void DecresceTentativas(){ // Will decrease the Remaining attempts; Vai reduzir o total de tentativas

            if (this.TotalTentativasRestantes > 0){ // Will decrease only if the Remaining attempts only if is higher than 0; Vai decrescentar apenas se o TotalTentativasRestantes é maior que zero 
                
                this.TotalTentativasRestantes--;
                
            }
        }

        public bool PossuiTentativas(){ //Will check if the player still having Tries; Vai verificar se o jogador ainda possui tentativas disponivéis

            if (this.TotalTentativasRestantes > 0){ // Case the player has tries than will return True; Se o jogador ainda estiver tentativas vai retornar true

                return true;
            }
            else { // Case the hasn't try then Will return false; Case o jogador não tenha mais tentativas vai retornar false
                return false;
            }
        }
    }
}