namespace projeto_final_bloco_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;


            while (opcao != 6)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("                  lojinha de skate do léo                     ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Criar Login                          ");
                Console.WriteLine("            2 - Listar todos os produtos             ");
                Console.WriteLine("            3 - Buscar produto pelo Numero           ");
                Console.WriteLine("            4 - Atualizar produtos                   ");
                Console.WriteLine("            5 - Apagar Produtos                      ");
                Console.WriteLine("            6 - Sair                                 ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Entre com a opção desejada:                          ");
                Console.WriteLine("                                                     ");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 9)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n!");
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Crie seu Login");
                        break;
                    case 2:
                        Console.WriteLine("Liste todos os produtos");
                        break;
                    case 3:
                        Console.WriteLine("Buscar produtos pelo numero");
                        break;
                    case 4:
                        Console.WriteLine("Atualize os produtos");
                        break;
                    case 5:
                        Console.WriteLine("Apagar os produtos");
                        break;



                }
            }
        }

    }
}
