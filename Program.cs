const double Limitecontinente = 10;
const double LimiteMarinha = 15;

const decimal MultaExcessoPeso = 20; 
const decimal Multabase = 1000;


Console.WriteLine("--- Pesca Amadora ---");

Console.Write("Peso (em kg): ");
Double PesoPescado = Convert.ToDouble(Console.ReadLine());

Console.Write("Águas Continentais ou Marinhas? ");
string localpesca = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

Console.WriteLine();

if (localpesca !="C" && localpesca !="M")
{
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("local não identificado");
Console.ResetColor();
return;
}
if (localpesca == "C" && PesoPescado <= Limitecontinente ||
localpesca == "M" && PesoPescado <= LimiteMarinha)
{
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Pescaria dentro dos limites legais");
Console.ResetColor();
return;
}





