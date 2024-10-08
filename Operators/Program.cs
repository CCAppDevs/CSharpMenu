bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("Welcome to the app");

    Console.WriteLine("-----------------------");
    Console.WriteLine("1.) Say Hello");
    Console.WriteLine("2.) Say Bonjour");
    Console.WriteLine("3.) Say Hola");
    Console.WriteLine("0.) Exit");
    Console.WriteLine("-----------------------");
    Console.WriteLine();
    Console.Write("What option would you like? (0-9) ");

    int answer = Convert.ToInt32(Console.ReadLine());

    switch (answer)
    {
        case 1:
            Console.WriteLine("Hello to you!");
            break;
        case 2:
            Console.WriteLine("Bonjour!");
            break;
        case 3:
            Console.WriteLine("Hola!");
            break;
        case 0:
            Console.WriteLine("Exiting the program");
            isRunning = false;
            break;
        default:
            Console.WriteLine("Invalid Option - Please try again!");
            break;
    }
}
