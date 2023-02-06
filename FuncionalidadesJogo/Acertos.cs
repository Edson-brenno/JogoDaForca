using System;

namespace jogoDaForca.FuncionalidadesJogo{

    public class Acerto{

        //Atributes
        //Atributos
        public int TotalAcertos {get; private set;} // Has the Total of hits; Contém o total de Acertos

        //Methods:
        //Metodos:

        public void AcrescentaAcertos(int TotalAcertos){ // Will increase the total of hits; Vai acrescentar o total de acertos

            this.TotalAcertos += TotalAcertos;

        }

    }
}