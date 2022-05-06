using System;

namespace CelaCisla
{
    public class Operace
    {
        /// <summary>
        /// Vrátí součet dvou celých čísel a,b
        /// </summary>
        /// <param name="a">První sčítanec</param>
        /// <param name="b">Druhý sčítanec</param>
        /// <returns></returns>
        public static int Soucet(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Vratí celočíseelný podíl a,b A zbytek po dělení
        /// </summary>
        /// <param name="a">Dělenec</param>
        /// <param name="b">Dělitel</param>
        /// <param name="zbytek">Zbxtek</param>
        /// <returns></returns>
        public static int CelociselnyPodil(int a, int b, out int zbytek)
        {
            zbytek = a % b;
            return a / b;
        }
        /// <summary>
        /// Vrátí rozdíl dvou celých čísel a,b
        /// </summary>
        /// <param name="a">menšenec</param>
        /// <param name="b">menšitel</param>
        /// <returns></returns>
        public static int Rozdil(int a, int b )
        {
            return a - b;
        }
        /// <summary>
        /// Vrátí součin dvou celých čísel a,b
        /// </summary>
        /// <param name="a">Činitel</param>
        /// <param name="b">Činitel</param>
        /// <returns></returns>
        public static int Soucin(int a, int b)
        {
            return a * b;

        }
        /// <summary>
        /// Vrátí jestli je číslo a sudé, či nikoliv
        /// </summary>
        /// <param name="a">Zjišťované číslo</param>
        /// <returns></returns>
        public static bool JeLiche(int a)
        {
            bool liche = false;
            if(a % 2 !=0)
            {
                liche = true;
            }

            return liche;

        }
    }
}
