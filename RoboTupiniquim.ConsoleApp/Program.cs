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


                if (coordenadaAtual == 'E')
                    direcao = VirarEsquerda(direcao);

                if (coordenadaAtual == 'D')
                    direcao = VirarDireita(direcao);

                else if (coordenadaAtual == 'M')
                    Andar(ref posicaoX, ref posicaoY, direcao);

            }

            Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");

            Console.ReadLine();
        }

        private static void Andar(ref int posicaoX, ref int posicaoY, char direcao)
        {
            if (direcao == 'N')
                posicaoY++;

            else if (direcao == 'S')
                posicaoY--;

            else if (direcao == 'O')
                posicaoX--;

            else if (direcao == 'L')
                posicaoX++;
        }

        private static char VirarDireita(char direcao)
        {
            if (direcao == 'N')
                direcao = 'L';

            else if (direcao == 'L')
                direcao = 'S';

            else if (direcao == 'S')
                direcao = 'O';

            else if (direcao == 'O')
                direcao = 'N';
            return direcao;
        }

        private static char VirarEsquerda(char direcao)
        {
            if (direcao == 'N')
                direcao = 'O';

            else if (direcao == 'O')
                direcao = 'S';

            else if (direcao == 'S')
                direcao = 'L';

            else if (direcao == 'L')
                direcao = 'N';
            return direcao;
        }
    }
}
