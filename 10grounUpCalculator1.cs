onsole.Write("Please enter your age: ");
int alter = int.Parse(Console.ReadLine());

if (alter >= 18 && alter <= 20)
{
    Console.WriteLine("Hello, you're grown up!");
}
else if (alter < 18)
{
    Console.WriteLine("Years must be 18!");
}
else if (alter >= 65 && alter <= 120)
{
    Console.WriteLine("Hello Senior!");
}
else if (alter > 120)
{
    Console.WriteLine("Zombie");
}
else
{
    Console.WriteLine("Nice to see you");
}


Console.Write("Please enter your age again: ");
alter = int.Parse(Console.ReadLine());

if (alter == 25 || alter == 50 || alter == 75)
{
    Console.WriteLine("Happy milestone birthday!");
}
else if (alter < 15)
{
    Console.WriteLine("It will still take a long time until you turn 18!");
}
else if (alter >= 65 && alter <= 120)
{
    Console.WriteLine("Hello Senior!");
}
else if (alter > 120)
{
    Console.WriteLine("Zombie");
}
else
{
    Console.WriteLine("Nice to see you");
}