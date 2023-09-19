using System;
namespace csharp_calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 54;
            int b = 234;

            double c = 546.45;
            double d = 654.4;

            int e = 850;
            int f = -50;

            double  g = -50.6767;
            double  h = 850.6767;

            Console.WriteLine($"La somma dei 2 interi {a} e {b} è : {CalcoliHelper.Sum<int>(a,b)}");
            Console.WriteLine();

            Console.WriteLine($"La differenza tra i 2 interi {a} e {b}  è : {CalcoliHelper.Minus<int>(a, b)}");
            Console.WriteLine();

            Console.WriteLine($"La differenza tra i 2 interi scambiati di posto {b} e {a} è : {CalcoliHelper.Minus<int>(b, a)}");
            Console.WriteLine();

            Console.WriteLine($"La somma dei 2 double {c} e {d} è : {CalcoliHelper.Sum<double>(c, d)}");
            Console.WriteLine();

            Console.WriteLine($"La differenza tra i 2 double {c} e {d} è : {CalcoliHelper.Minus<double>(c, d)}");
            Console.WriteLine();

            Console.WriteLine($"La differenza tra i 2 double scambiati di posto {d} e {c} è : {CalcoliHelper.Minus<double>(d,c)}");
            Console.WriteLine();

            Console.WriteLine($"La moltiplicazione dei 2 interi {a} e {b} è : {CalcoliHelper.Molti<int>(a, b)}");
            Console.WriteLine();

            Console.WriteLine($"La moltiplicazione dei 2 double {c} e {d} è : {CalcoliHelper.Molti<double>(c, d)}");
            Console.WriteLine();

            Console.WriteLine($"I valori assoluti dei 2 interi {e} e {f} sono : {CalcoliHelper.Absolute<int>(e)} e {CalcoliHelper.Absolute<int>(f)}");
            Console.WriteLine();

            Console.WriteLine($"I valori assoluti dei 2 double {g} e {h} sono : {CalcoliHelper.Absolute<double>(g)} e {CalcoliHelper.Absolute<double>(h)}");
            Console.WriteLine();

            Console.WriteLine($"Il Minimo tra gli interi {a} e {b} è : {CalcoliHelper.Minor<int>(a, b)}");
            Console.WriteLine();

            Console.WriteLine($"Il Minimo tra i double {g} e {h} è : {CalcoliHelper.Minor<double>(g, h)}");
            Console.WriteLine();

            Console.WriteLine($"Il Massimo tra gli interi {a} e {b} è : {CalcoliHelper.Maxim<int>(a, b)}");
            Console.WriteLine();

            Console.WriteLine($"Il Massimo tra i double {g} e {h} è : {CalcoliHelper.Maxim<double>(g, h)}");
            Console.WriteLine();

        }
    }
}

/*
 * Creare una classe di helper CalcoliHelper.
Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi static:
Somma di due numeri interi
Somma di due numeri double
Differenza tra due numeri interi
Differenza tra due numeri double
Moltiplicazione di due numeri interi
Moltiplicazione di due numeri double
Valore assoluto di un numero intero
Valore assoluto di un numero double
Minimo tra due numeri interi
Minimo tra due numeri double
Massimo tra due numeri interi
Massimo tra due numeri double
Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto...Quale?
Scrivetelo in un commento all’interno del codice! 🤓 Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).
BONUS:
Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente.
Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi! (caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero indefinito usiamo l’approccio informatico che lo calcola come 1)*/