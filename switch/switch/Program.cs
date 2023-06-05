namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 20;
            
            //"caso valor"
            switch(valor)
            {
                //"seja 29"
                case 29:
                    //execute isso
                    Console.WriteLine("29");
                    //pare a execução
                    break;

                case 20:
                    Console.WriteLine("trintão");
                    break;

                    //saida default caso nenhuma das alternativas retorne true
                    default: Console.WriteLine("padrao");
                    break;


            }
        }
    }
}