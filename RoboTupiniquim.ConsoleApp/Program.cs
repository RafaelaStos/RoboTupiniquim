namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeiroRobo();
            SegundoRobo();
        }

        private static void SegundoRobo()
        {
            Console.WriteLine("Informe a posição do robo em X: ");
            int posicao2X = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a posição do robo em Y: ");

            int posicao2Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a direção do robo: ");
            char direcao2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Informe os comandos para exploração: ");
            string coordenadaInicial2 = Console.ReadLine();

            char[] coordenadas2 = coordenadaInicial2.ToCharArray();

            for (int comando = 0; comando < coordenadas2.Length; comando++)
            {
                char coordenadaAtual = coordenadas2[comando];


                if (coordenadaAtual == 'E')
                    direcao2 = VirarEsquerda(direcao2);

                if (coordenadaAtual == 'D')
                    direcao2 = VirarDireita(direcao2);

                else if (coordenadaAtual == 'M')
                    Andar(ref posicao2X, ref posicao2Y, direcao2);

            }

            Console.WriteLine($"{posicao2X} {posicao2Y} {direcao2}");
            Console.ReadLine();
        }

        private static void PrimeiroRobo()
        {
            Console.WriteLine("Informe a posição do robo em X: ");
            int posicaoX = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a posição do robo em Y: ");
            int posicaoY = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a direção do robo: ");
            char direcao = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Informe os comandos para exploração: ");
            string coordenadaInicial = Console.ReadLine();

            char[] coordenadas1 = coordenadaInicial.ToCharArray();

            for (int comando = 0; comando < coordenadas1.Length; comando++)
            {
                char coordenadaAtual = coordenadas1[comando];


                if (coordenadaAtual == 'E')
                    direcao = VirarEsquerda(direcao);

                if (coordenadaAtual == 'D')
                    direcao = VirarDireita(direcao);

                else if (coordenadaAtual == 'M')
                    Andar(ref posicaoX, ref posicaoY, direcao);

            }

            Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");
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
    
