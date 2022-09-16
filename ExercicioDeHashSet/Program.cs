using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> PrimeiroCurso = new HashSet<int>();
            HashSet<int> SegundoCurso = new HashSet<int>();
            HashSet<int> TerceiroCurso = new HashSet<int>();

            Console.WriteLine("Quantos estudantes para o primeiro curso? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0;i < n;i++)
            {
                
                int cod = int.Parse(Console.ReadLine());
                PrimeiroCurso.Add(cod);
            }

            Console.WriteLine("Quantos estudantes para o segundo curso?  ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0;i < n;i++)
            {
                int cod = int.Parse(Console.ReadLine());
                SegundoCurso.Add(cod);
            }

            Console.WriteLine("Quantos estudantes para o terceiro curso?  ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0;i < n;i++)
            {
                int cod = int.Parse(Console.ReadLine());
                TerceiroCurso.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(PrimeiroCurso);
            all.UnionWith(SegundoCurso);
            all.UnionWith(TerceiroCurso);
            Console.WriteLine("Total de estudantes: " + all.Count);
        }
    }
}
