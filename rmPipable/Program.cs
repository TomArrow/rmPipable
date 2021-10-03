using System;
using System.IO;

namespace rmPipable
{
    class Program
    {
        static void Main(string[] args)
        {
            string s,s2;
            long index = 0;
            while ((s = Console.ReadLine()) != null)
            {

                Console.WriteLine(index++);
                if (s.Substring(0,4) == "rm \"" && s[s.Length-1]=='"')
                {

                    s2 = s.Substring(4, s.Length - 5);
                    if (File.Exists(s2))
                    {

                        File.Delete(s2);
                        Console.WriteLine("Deleted: "+s2);

                    }
                }
                else if (File.Exists(s))
                {

                    File.Delete(s);
                    Console.WriteLine("Deleted: " + s );
                }
            }
        }
    }
}
