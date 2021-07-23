using System;
class minhaClasse{

    static void Main(string[] args) { 

            int a, b, x;
            Console.WriteLine("Informe a quantidade de pimentões amarelos e vermelhos respectivamente:");
            string [] quantidade = Console.ReadLine().Split(' ');
            a = Convert.ToInt32(quantidade[0]);
            b = Convert.ToInt32(quantidade[1]);

            x = (a) + (b); //complete o código de acordo com o cálculo esperado

            Console.WriteLine("X = {0}", x);
    }
}