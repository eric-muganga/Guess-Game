Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to The Guess Game!!!");

Random Random= new Random();
int randomNum = Random.Next(1,20);
Console.WriteLine("Guess My Number!!!!! From 1 - 20");
Console.Write("Enter your Guess: ");
int guess = int.Parse(Console.ReadLine());

check(guess);
void check(int guess)
{
    while (guess != randomNum)
    {
        if (guess < randomNum)
        {
            Console.WriteLine("higher");
        }
        else
        {
            Console.WriteLine("Lower");
        }
        Console.WriteLine("");
        Console.Write("Enter your Guess: ");
        guess = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("You Won");
}