using System;

int points = 0;
Console.WriteLine("Välkommen till Mickes transformers-frågesport!");

// -----------------------------------------------------------------------------

Console.WriteLine("1: Vad hette Optimus Prime tidigare?");
Console.WriteLine("a) Optimus Sub-prime  b) Orion Pax  c) Optimus Pax");
string answer1 = Console.ReadLine();
if (answer1 == "b")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

// -----------------------------------------------------------------------------

Console.WriteLine("2: Vad heter planetätaren?");
Console.WriteLine("a) Galactus  b) Unicorn  c) Unicron");
string answer2 = Console.ReadLine();
if (answer2 == "c")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

// -----------------------------------------------------------------------------

Console.WriteLine("3: Vad heter Scorponoks headmaster?");
Console.WriteLine("a) Lord Zarak  b) Lord Hi-Q  c) Lord Razorfist");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

// -----------------------------------------------------------------------------

Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Du har alltså ingen koll alls.");
}
else if (points < 3)
{
  Console.WriteLine("OK, du har hyfsad koll - eller gissade rätt en eller ett par gånger.");
}
else 
{
  Console.WriteLine("Grattis! Du hade alla rätt!");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();