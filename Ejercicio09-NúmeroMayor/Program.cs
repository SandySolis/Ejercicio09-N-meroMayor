Console.WriteLine("Ingrese sus tres números: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("Este número es el mayor: " + num1);
}
else if (num2 > num3 && num2 > num1)
{
    Console.WriteLine("Este número es el mayor: " + num2);
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine("Este número es el mayor: " + num3);
}