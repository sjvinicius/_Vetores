using System;

namespace _Introducao_Vetores_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("-*-*-*-* FERINHA *-*-*-*");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("-*-*-*- BEM-VINDO -*-*-*");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*");
            
            int ni = 3;

            Console.Write("Quantos itens deseja cadastrar na sua feira ?: ");
            ni = int.Parse( Console.ReadLine() );

            // string [] product = new string [ni];
            // double [] price = new double [ni];
            string [] product = {"laranja", "melao", "quiabo"};
            double [] price = {9.99, 8.99, 2,99 };

            // for (var i = 0; i < ni; i++)
            // {
            //     Console.WriteLine($"Digite o seu {i} produto: ");
            //     product = Console.ReadLine{};
            //     Console.WriteLine($"Digite o preço do(a) {product}: " );
            //     price = double.Parse( Console.ReadLine() ) ;

            // }    

            string ans;

            Console.WriteLine("Deseja ver o que foi cadastrado? (sim/nao)");
            ans = Console.ReadLine();

            if (ans == "sim") {

                for (var i = 0; i < ni; i++)
                {
                    Console.WriteLine($"Produto: {product[i]} -- Preço: {price[i]}");
                }


            }
            
        }
    }
}
