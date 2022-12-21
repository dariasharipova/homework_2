Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Random rand = new Random();
double[,] array = new double[m,n];
if(m>=5 & m<=20 & n>=5 & n<=20)
{
    for(int i =0; i<m; i++)
    {
        for(int j =0; j<n; j++)
        {
            array[i,j] = rand.Next(0,100);
        }
    }
    static void vuvod(double[,] array, int m, int n)
    {
        for(int i = 0; i < m; i++)
        {
            for(int j =0; j<n;j++)
            {
                Console.Write(array[i,j]+" ");
            }
            Console.WriteLine(" ");
        }
    }
    vuvod(array,m,n);
    Console.WriteLine("Введите число");
    double chislo = double.Parse(Console.ReadLine());
    static double[,] poisk(double[,] array, int m, int n, double l)
    {
        double[,] strokastolb = new double[1,2];
        strokastolb[0,0] =m;
        for(int i = 0; i<m; i++)
        {
            if(strokastolb[0,0]==m)
            {
                for(int j = 0; j<n; j++)
                {
                    if(array[i,j]>l)
                    {
                        strokastolb[0,0] = i;
                        strokastolb[0,1] = j;
                        break;
                    }
                }
            }
            else
            {
                break;
            }
        }
        return strokastolb;
    }
    if(poisk(array,m,n,chislo)[0,0] == m)
    {
        Console.WriteLine("Числа больше введенного нет");
    }
    else
    {
        Console.WriteLine("Число больше введенного находится в " + poisk(array,m,n,chislo)[0,0] + " строке в " + poisk(array,m,n,chislo)[0,1] + " столбце");
    }
    static double[,] srednee(double[,] array, int m, int n)
    {
        double[,] sredneesostolbikom = new double[n,2];
        double s = 0;
        for(int j = 0; j<n;j++)
        {
            for(int i = 0; i<m; i++)
            {
                s+=array[i,j];
            }
            sredneesostolbikom[j,0]  = j+1;
            sredneesostolbikom[j,1] = s/m;
            s=0;
        }
        return sredneesostolbikom;

    } 
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    vuvod(srednee(array,m,n),n,2);
}
else
{
    Console.WriteLine("Введены неверные данные");
}