using Primeiro_exercicio;


        Console.WriteLine("digite seu nome");
        string firstUser = Console.ReadLine();

        Console.WriteLine("agora digite sua idade");
        int yearsFirstUser = int.Parse(Console.ReadLine());

        Person user1 = new Person();
        user1.Name = firstUser;
        user1.YeOld = yearsFirstUser;


        Console.WriteLine("digite o nome da segunda pessoa");
        string secondUser = Console.ReadLine();

        Console.WriteLine("agora digite a idade da segunda pessoa");
        int yearsSecondUser = int.Parse(Console.ReadLine());

        Person user2 = new Person();
        user2.Name = secondUser;
        user2.YeOld = yearsSecondUser;

        if(user1.YeOld > user2.YeOld)
        {
            Console.WriteLine($"a pessoa mais velha é {user1.Name}, possuindo uma idade de {user1.YeOld} anos");
        }
        else
        {
            Console.WriteLine($"a pessoa mais velha é {user2.Name}, possuindo uma idade de {user2.YeOld} anos");
        }
