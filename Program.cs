using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            while (!partida.terminada)
            {
                try
                {
                    Console.Clear();
                    Tela.imprimircampoMinado(campoMinado);

                    Console.WriteLine();
                    Console.Write("Jogostatus:");
                    campoMinado origem = lerCasasAbertas().tocampoMinado();
                    validarCasasAbertas = partida.validarCasasAbertas;

                    bool[,] possiveisCasasAbertas = partida.tab.casa(origem).jogadasPossiveis();


                    Console.Clear();
                    Tela.imprimircampoMinado(partida.tab, JogadasPossiveis);

                    Console.WriteLine();
                    Console.Write("CasascomBombas:");
                    Casas.destino = Tela.LerCasascomBombas().toCasas();
                    partida.validarCasaascomBombas(origem, destino);

                    partida.realizarJogada(origem, destino);
                }
                catch (CampoMinadoExeption e)
                {
                    Console.Write();
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Tela.imprimirPartida(partida);
        }
     }    

  }

        
    

                      