class Program
{
    static void Main(string[] args)
    {
        int a=50, b=46, c=5, d=100;
        

        for (int i = 1; i <= 4; i++)
        {
            int mayorAB=0, mayorCD=0, mayor = -1;
            if (a > b)
            {
                mayorAB = a;
            }
            else
            {
                mayorAB = b;
            }

            if (c > d)
            {
                mayorCD = c;
            }
            else
            {
                mayorCD = d;
            }

            if (mayorAB > mayorCD)
            {
                mayor = mayorAB;
            }
            else
            {
                mayor = mayorCD;
            }

        }


    }
}