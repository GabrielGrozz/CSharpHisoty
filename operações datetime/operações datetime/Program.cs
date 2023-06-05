namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2015, 08, 15, 16, 15, 21);
            //podemos transformar essa data em string e mostrala de forma extensa
            Console.WriteLine(data.ToLongDateString());
            Console.WriteLine(data.ToLongTimeString());
            //de forma curta 
            Console.WriteLine(data.ToShortDateString());

            //podemos exibi-la de uma forma específica com um provider
            Console.WriteLine(data.ToString("yyyy-MM-dd"));
            
        }
    }
}