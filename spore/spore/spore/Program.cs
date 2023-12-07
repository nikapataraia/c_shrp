// See https://aka.ms/new-console-template for more information
using spore;

Console.WriteLine("Hello, World!");


APP a = new APP();
int i = 0;
while(i <= 100)
{
    i++;
    Console.WriteLine(a.play());
    a.restart_game();
}
