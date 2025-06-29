using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace Лабораторная_работа_418
{
    class Program
    {
        static void Main()        
        {
            var stroka2 = Console.ReadLine().Split(' ');
            int n = int.Parse(stroka2[0]);
            int m = int.Parse(stroka2[1]);
            char[,] a = new char[n, m];
            StringBuilder sb = new StringBuilder();
            for (int i=0;i<n;i++)
            {
                var stroka = Console.ReadLine();
                char[] b = stroka.ToCharArray();
                for (int j=0;j<m;j++)
                {
                    a[i, j] = b[j];
                }
            }
            int k = int.Parse(Console.ReadLine());
            for(int i=0;i<k;i++)
            {
                var stroka = Console.ReadLine();
                char[] b = stroka.ToCharArray();
                int t = b.Length;
                int f = 0;
                for(int j=0;j<n;j++)
                {
                    int g = 0;
                    int h = 0;
                    for (int y=0;y<m;y++)
                    {   
                        if (h == t)
                            f++;
                        if (g<t && a[j,y]==b[g])
                        {
                            g++;
                            h++;
                            if (h == t)
                                f++;
                        }
                        else if (g < t && a[j, y] != b[g])
                        {
                            h = 0;
                            g=0;
                        }
                        if (g>=t)
                        {
                            g = 0;
                            break;
                        }
                        if (h == t)
                            f++;
                    }                  
                }              
                for (int j = 0; j < m; j++)
                {
                    int g = 0;
                    int h = 0;
                    for (int y = 0; y < n; y++)
                    {
                        if (h == t)
                            f++;
                        if (g < t && a[y,j] == b[g])
                        {
                            g++;
                            h++;
                            if (h == t)
                                f++;
                        }
                        else if (g < t && a[y, j] != b[g])
                        {
                            h = 0;
                            g=0;
                        }
                        if (g >= t)
                        {
                            g = 0;
                            break;
                        }
                        if (h == t)
                            f++;
                    }
                }
                if (f > 0)
                {
                    sb.Append("YES");
                    sb.Append('\n');
                }
                else
                {
                    sb.Append("NO");
                    sb.Append('\n');
                }
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
