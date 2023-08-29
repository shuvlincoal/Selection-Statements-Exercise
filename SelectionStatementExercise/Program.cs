namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 8);
            int guessNbr = 0;

            Console.WriteLine($"Guess a number between 1 and 8");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine($"You guessed it, {favNumber} was it");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"Guess is to high");
            }

            else if (userInput < favNumber)
            {
                Console.WriteLine($"Guess is to low");
            }
        }
    }
}
