//Simon Frändén

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrect = false;
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 20);
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 - 20. Kan du gissa vilket? Du får fem försök."); 
            
            for (int i = 0; i < 5; i++)
            {
                int guess;
                do Console.Write("Gissning: ");
                while (!int.TryParse(Console.ReadLine(), out guess));

                isCorrect = CheckGuess(guess, rndNumber) ? true : false;
                if(isCorrect)
                {
                    break;
                }                
            }

            if(!isCorrect)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }
            
            bool CheckGuess(int g, int num)
            {
                if (g == num)
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    return true;                    
                }
                else if (g < num)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                    return false;
                }
            }
        }
    }
}