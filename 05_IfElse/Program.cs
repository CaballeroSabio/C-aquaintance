// See https://aka.ms/new-console-template for more information
Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Oh, yes! This is Maria");
}
else
{
    Console.Write("Hi!");
    Console.WriteLine(username);
}