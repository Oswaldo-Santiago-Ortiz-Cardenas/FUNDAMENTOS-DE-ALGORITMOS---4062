using System;
class Programm
{
    public static void Main(string[] args)
    {
        int num1, num2, num3;
        Console.WriteLine("Ingrese un primer número");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un segundo número");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un tercer número");
        num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
            Console.WriteLine("El número mayor de los que ingresó es " + num1);
        else if (num2 > num1 && num2 > num3)
            Console.WriteLine("El número mayor de los que ingresó es " + num2);
        else if (num3 > num1 && num3 > num2)
            Console.WriteLine("El número mayor de los que ingresó es " + num3);
        Console.ReadKey();
    }
}