

int points = 0;

Console.WriteLine("Vällkommen till min sportfrågor!");  
Console.WriteLine("Jag kommer ställa frågor och du ska välja mellan a, b eller c");
Console.WriteLine("Varje rätt svar får du en pöang");

Console.WriteLine("1: vilket land vann vm 2026?");
Console.WriteLine("a)argentina b)Frankike c)Spanien");
string answer1= Console.ReadLine();

if(answer1 =="c")
{
    points++;
    Console.WriteLine("correct");
}
else
{
    Console.WriteLine("incorrect");
}

Console.WriteLine("2:vilket land har mest befolkningen?");
Console.WriteLine("a)India b)Kina c)USA");
string answer2 = Console.ReadLine();

if(answer2 =="a")
{
    points++;
    Console.WriteLine("correct");
}
else
{
    Console.WriteLine("incorrect");
}

Console.WriteLine("3:Vilken hav är störst?");
Console.WriteLine("a)indiska oceanen b)Stilla havet c)Atlanten");
string answer3 = Console.ReadLine();

if(answer3 == "b")
{
    points++;
    Console.WriteLine("correct");
}
else
{
    Console.WriteLine("incorrect");
}


Console.WriteLine($"Du fick {points} poäng");
if(points == 0)
{
    Console.WriteLine("Du behöver träna mer på olika områdn");
}
else if(points < 3)
{
    Console.WriteLine("Bra försök men du börde kunna mer");
}
else
{
    Console.WriteLine("Wow! du fick alla rätt");
}

Console.ReadLine();

