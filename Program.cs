using System;
using jogoDaForca.FuncionalidadesJogo;

namespace jogoDaForca.Jogo{

    public class Jogo{

        static void Main(string[] args){

            Palavra palavra = new Palavra();

            palavra.EscolhePalavraSecreta();

            palavra.SetarTamanhoPalavra();

            palavra.IniciarPalavraDescoberta();

            Console.WriteLine(palavra.PalavraSecreta);

            Console.WriteLine(palavra.PalavraDescoberta);

            Acerto acerto = new Acerto();

            int test = 0;
            
            palavra.AdicionarLetraUtilizada('a');
            while(test == 0){

                try{
                
                

                palavra.PerguntarUmaLetra();

                test = 1;

                }
                catch(Exception ex){

                    Console.WriteLine(ex.Message);
                    
                    
                }
            }           
            
            
            
            
        //     if (palavra.IsLetraValidaParaUso(tt)){

        //         acerto.AcertouLetras(tt, palavra.PalavraSecreta);

        //         Console.WriteLine($"O total de acertos foi {acerto.TotalAcertos}");

        //         acerto.JaVenceu(palavra.TamanhoPalavraSecreta);

        //         Console.WriteLine($"O jogador já venceu? {acerto.Venceu}");

        //         palavra.AdicionarLetraUtilizada(tt);
        //     }
        //     else{

        //         Console.WriteLine("A letra ja joi utilizada");
        //     }

        //     Console.WriteLine("Digite uma letra:");
            
        //     tt = Convert.ToChar(Console.ReadLine());
            
        //     if (palavra.IsLetraValidaParaUso(tt)){

        //         acerto.AcertouLetras(tt, palavra.PalavraSecreta);

        //         Console.WriteLine($"O total de acertos foi {acerto.TotalAcertos}");

        //         acerto.JaVenceu(palavra.TamanhoPalavraSecreta);

        //         Console.WriteLine($"O jogador já venceu? {acerto.Venceu}");

        //         palavra.AdicionarLetraUtilizada(tt);
        //     }
        //     else{

        //         Console.WriteLine("A letra ja joi utilizada");
        //     }
        // }
    }
}}