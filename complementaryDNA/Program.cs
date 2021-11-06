using System;

namespace complementaryDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            string dnaSide1 = Console.ReadLine();
            string dnaSide2 = MakeComplement(dnaSide1);

            Console.WriteLine(dnaSide1 + " " + dnaSide2);
        }

        public static string MakeComplement(string dna)
        {
            string dnaSide2 = "";

            foreach(char chr in dna)
            {
                switch (chr)
                {
                    case 'A':
                        {
                            dnaSide2 += 'T';
                            break;
                        }
                    case 'T':
                        {
                            dnaSide2 += 'A';
                            break;
                        }
                    case 'G':
                        {
                            dnaSide2 += 'C';
                            break;
                        }
                    case 'C':
                        {
                            dnaSide2 += 'G';
                            break;
                        }
                }
            }

            return dnaSide2;
        }
    }
}
