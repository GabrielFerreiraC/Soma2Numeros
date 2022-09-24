int primeiroNumero, segundoNumero, soma;

Console.WriteLine ("Cálculo da soma entre dois números .\n");


Console.WriteLine("Digite o primeiro número: ");
primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
segundoNumero = Convert.ToInt32(Console.ReadLine());

soma = primeiroNumero + segundoNumero;

Console.WriteLine($"\nSoma: {soma}");