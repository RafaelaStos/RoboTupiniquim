namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicaoX = 1;
            int posicaoY = 2;
            char direcao = 'N';

            string coordenadaInicial = "EMEMEMEMM";

            char[] coordenadas = coordenadaInicial.ToCharArray();

            for (int comando = 0; comando < coordenadas.Length; comando++)
            {
                char coordenadaAtual = coordenadas[comando];

                #region coordenada para esquerda
                if (coordenadaAtual == 'E')
                {
                    if (direcao == 'N')
                        direcao = 'O';
                    
                    else if (direcao == 'O')
                        direcao = 'S';
                   
                    else if (direcao == 'S')
                        direcao = 'L';
                   
                    else if (direcao == 'L')
                        direcao = 'N';

                }
#endregion


                #region coordenada para direira
                if (coordenadaAtual == 'D')
                {
                    if (direcao == 'N')
                        direcao = 'L';
                   
                    else if (direcao == 'L')
                        direcao = 'S';
                   
                    else if (direcao == 'S')
                        direcao = 'O';
                  
                    else if (direcao == 'O')
                        direcao = 'N';
                }
                #endregion

                #region coordenada para andar
                else if(coordenadaAtual=='M')
                {
                    if (direcao == 'N')
                        posicaoY++;

                    else if (direcao =='S')
                        posicaoY--;

                    else if (direcao =='O')
                        posicaoX--;

                    else if(direcao =='L')
                        posicaoX++;
                }

                #endregion

            }

            Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");

            Console.ReadLine();
        }
    }
}
