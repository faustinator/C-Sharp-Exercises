// See https://aka.ms/new-console-template for more information



class Program
{
    static int countNumber ()
    {
        var count = 0;

        for (var i = 1; i<=100; i++)
        {            

            if ( i%3 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("numbers dvisable yb 3: " + count);

        return count;
    }

    static int AddNumbers()
    {
        var sum = 0;        
        var input = Console.ReadLine();

        while (input != "ok")
        {
            sum += Convert.ToInt32(input);
            input = Console.ReadLine();
        }
        return sum;
    }

    static int factorial()
    {
        var count = 1;
        var input = Console.ReadLine();

        for (var i = Convert.ToInt32(input); i > 0 ; i--)
        {
            count *= i; 
        }
       
        return count;
    }

    static void NumberGuessing()
    {
        Console.WriteLine("Guess a number");

        Random rnd = new Random();
        var secret = rnd.Next(1, 10);

        Console.WriteLine("The not so secret number " + secret);

        for (var i = 0; i < 4; i ++)
        {
            try
            {
                var input = Console.ReadLine();
                if (Convert.ToInt32(input) == secret)
                    Console.WriteLine("You Won!");
                else
                    Console.WriteLine("You Lost");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                    
            }


            

        }

    }





    static void Main(string[] args)
    {

        //Console.WriteLine("numbers dvisable yb 3 " + countNumber());
        //Console.WriteLine("sum " + AddNumbers());
        //Console.WriteLine("factorial: " + factorial());
        NumberGuessing();



    }
}

