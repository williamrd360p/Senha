Console.Write("Olá, usuário. Por favor, digite sua senha: ");
string senhaDigitada = Console.ReadLine()!;
const string senhaCorreta = "Corinthians";

bool senhaValida = senhaDigitada == senhaCorreta;

if (senhaValida)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Acesso permitido");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Acesso negado");
    Console.Beep();
    Console.Beep();                             
}

Console.ResetColor();
