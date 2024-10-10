namespace PB503DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //1 - dən 100'ə qədər 3ə və 5ə (mis: 15, 30, 45) qalıqsız bölünən ədədləri console`a yazdırırsınız

            for (int i = 1; i <= 100; i++) +
            if (i % 3 == 0 && i % 5 == 0 )
                { Console.WriteLine(i); }


            #endregion

            #region Task 2

            //            Bir variable`niz olur və ona ədəd(və ya rəqəm) mənimsədirsiniz.Əgər bu ədəd
            //65 - dən aşağıdırsa console`da `Kəsildin`,
            //65 - 85 arasındadırsa console`da `Adi Diplom`,
            //85 - 95 arasındadırsa console`da `Şərəf Diplomu`, (Honour)
            //95 + console`da `Yüksək Şərəf Diplomu`, (High Honour) yazılsın


            var point = 86;

            if (point < 65 )
            { Console.WriteLine("Kəsildin"); }
            else if (point >=65 && point < 85)
            { Console.WriteLine(" Adi Diplom"); }
            else if ( point >=85 && point < 95)
            { Console.WriteLine("Şərəf Diplomu,Honour"); }
            else if ( point >= 95 && point <= 100)
            { Console.WriteLine("Yüksək Şərəf Diplomu , High Honour"); }


            #endregion

        }


    }
}
