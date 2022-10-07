namespace Uppgift1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            while (quantity != 3)
            {

                Console.WriteLine("Welcome to my shop! how can i help you?");
                Console.WriteLine("1: T-Shirts");
                Console.WriteLine("2: Cups");
                Console.WriteLine("3: Exit");
                

                quantity = Convert.ToInt32(Console.ReadLine());
                Random random = new Random();
                
                for (int i = 0; i < random.Next(1, 11); i++)
                {
                    switch (quantity)
                    {
                        case 1:
                            Console.WriteLine(Generator1.Tshirts());
                            break;

                        case 2:
                            Console.WriteLine(Generator1.CupGenerator());
                            break;

                        case 3:
                            
                            break;

                        default:
                            Console.WriteLine("Not an option!");
                            break;

                    }
                }
            }






        }

    }
}