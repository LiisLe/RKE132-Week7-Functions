Console.WriteLine("Are you coming or leaving? (in/out):");
string userchoice = Console.ReadLine();

if (userchoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}



static void PrintHello() //funtion / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}


