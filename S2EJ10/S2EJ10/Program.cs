using System;
class Programm
{
    public static void Main(string[] args)
    {
        double cons, desc, imp, T;
        Console.WriteLine("Ingrese el costo de su consumo");
        cons = double.Parse(Console.ReadLine());
        if (cons <= 100.00)
        {
            imp = cons * 0.18;
            desc = cons * 0.10;
            T = cons - desc;
            Console.WriteLine("Recibirá un descuento de 10% equivalente a " + desc + " soles");
            Console.WriteLine("Se le aplicó un impuesto de 18% equivalente a " + imp + " soles");
            Console.WriteLine("El subtotal de lo que debe pagar es de " + cons + " soles");
            Console.WriteLine("El importa a pagar es de " + T + " soles");
        }
        else
        {
            imp = cons * 0.18;
            desc = cons * 0.20;
            T = cons - desc;
            Console.WriteLine("Recibirá un descuento de 10% equivalente a " + desc + " soles");
            Console.WriteLine("Se le aplicó un impuesto de 18% equivalente a " + imp + " soles");
            Console.WriteLine("El subtotal de lo que debe pagar es de " + cons + " soles");
            Console.WriteLine("El importa a pagar es de " + T + " soles");
        }
        Console.ReadKey();
    }
}