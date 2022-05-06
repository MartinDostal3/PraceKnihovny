using System;

namespace CelaCisla
{
    public class Operace
    {
        public static int Soucet(int a, int b)
        {
            return a + b;
        }

        public static int CelociselnyPodil(int a, int b, out int zbytek)
        {
            zbytek = a % b;
            return a / b;
        }
        public static int Rozdil(int a, int b )
        {
            return a - b;
        }
        public static int Soucin(int a, int b)
        {
            return a * b;

        }
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
