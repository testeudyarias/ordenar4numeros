class Program
{
    static void Main(string[] args)
    {
        int a=50, b=46, c=5, d=100;
        

        for (int i = 1; i <= 4; i++)
        {
            int mayor = 0;
            if ( (a >= b) && (a >= c) && (a >= d) )
            {
                mayor = a;
                a = -1;
            }
            else
            {
                if ((b >= a) && (b >= c) && (b >= d))
                {
                    mayor = b;
                    b = -1;
                }
                else
                {
                    if ((c >= a) && (c >= b) && (c >= d))
                    {
                        mayor = c;
                        c = -1;
                    }
                    else
                    {
                        if ((d >= a) && (d >= b) && (d >= c))
                        {
                            mayor = d;
                            d = -1;
                        }
                    }
                }
            }

            Console.WriteLine(mayor);
        }
        Console.ReadKey();


    }
}