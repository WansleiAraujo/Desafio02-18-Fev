Console.WriteLine("Calcular o IMC (Índice de massa corporal de uma pessoa)");

Console.WriteLine("Informe sua altura: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Informe seu peso: ");
double peso = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine("Seu IMC é: " + imc.ToString("N2"));

if (imc < 16)
    Console.WriteLine("> Magreza Grau III");
if (imc > 16 && imc < 16.9)
    Console.WriteLine("> Magreza Grau II");
if (imc > 17 && imc < 18.4)
    Console.WriteLine("> Magreza Grau I");
if (imc > 18.5 && imc < 24.9)
    Console.WriteLine("> Eutrofia");
if (imc > 25 && imc < 29.9)
{
    Console.WriteLine("> Sobrepeso");
    Console.WriteLine("> Risco: Aumentado");
}
if (imc > 30 && imc < 34.9)
{
    Console.WriteLine("> Obesidade grau I");
    Console.WriteLine("> Risco: Moderado");
}
if (imc > 35 && imc < 40)
{
    Console.WriteLine("> Obesidade grau II");
    Console.WriteLine("> Risco: Grave");
}
if (imc > 40)
{
    Console.WriteLine("> Obesidade grau III");
    Console.WriteLine("> Risco: Muito Grave");
}