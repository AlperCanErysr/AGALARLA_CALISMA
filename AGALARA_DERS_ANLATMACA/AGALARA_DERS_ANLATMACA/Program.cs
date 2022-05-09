using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGALARA_DERS_ANLATMACA
{
    internal class Program
    {
        public struct Kisi
        {
            public int paraMikatarı;
            public string adsoyad;

            public Kisi(int paraMiktarı,string adsoyad)
            {
                this.adsoyad = adsoyad;
                this.paraMikatarı = paraMiktarı;
               
            }
        }

        static void Main(string[] args)
        {
            try
            {
                const int ıspanak = 15; 
                const int marul = 15;  
                const int elma = 20;
                Kisi kisi1 = new Kisi();
                Kisi kisi2 = new Kisi();
                Kisi kisi3 = new Kisi();
                Kisi kisi4 = new Kisi();
                Kisi kisi5 = new Kisi();
                Kisi kisi6 = new Kisi();

                int kalanparamiktarı;

                Kisi ben = new Kisi(100,"Alper Can");

                Kisi[] ilkikikisi = { kisi1, kisi2 };

                Queue<Kisi> onumuzdekiler1 = new Queue<Kisi>(ilkikikisi);
                onumuzdekiler1.Enqueue(ben);

                while (onumuzdekiler1.Count>0)
                {
                    Kisi herkisi = onumuzdekiler1.Peek();
                    if (herkisi.adsoyad != null)
                    {
                        ben.paraMikatarı -= elma;
                    }
                    onumuzdekiler1.Dequeue();
                }
                Console.WriteLine("elma aldıktan sonra kalan para {0}", ben.paraMikatarı);
            }
            catch (Exception)
            {

                throw;
            }






























            /*
            ArrayList agubugu = new ArrayList();
            agubugu.Add(1);
            agubugu.Add(2);
            agubugu.Add(3);
            agubugu.Add(4);
            agubugu.Add(5);
            agubugu.Add("Örnek");
            agubugu.Add(false);

            Console.WriteLine();

            Console.WriteLine(agubugu.Count); 
            Console.WriteLine(agubugu.Contains(4));
            Console.WriteLine(agubugu[0]);
            agubugu.Remove(3);
            
            */

































            /*
            LinkedList<string> çuval = new LinkedList<string>();
            çuval.AddLast("A");
            çuval.AddLast("A");
            çuval.AddLast("A");
            çuval.AddLast("A");
            çuval.AddLast("A");
            çuval.AddLast("B");
            çuval.AddLast("C");
            çuval.AddLast("D");
            çuval.AddLast("E");
            çuval.AddLast("F");

           
            çuval.AddFirst("H");

            LinkedListNode<string> agubugu = çuval.Find("D");
            çuval.Remove(agubugu);

            LinkedListNode<string> agubugu2 =çuval.Find("F");
            çuval.AddAfter(agubugu2,"F2");

            foreach (var item in çuval)
            {
                Console.WriteLine(item);
            }
            int A_lar = çuval.Count(a => a == "A");
            Console.WriteLine("Listede ki A'ların sayısı = {0}",A_lar);

           */



















            /*
            Stack<int> çuval = new Stack<int>();
            çuval.Push(1);
            çuval.Push(2);
            çuval.Push(3);
            çuval.Push(4);
            çuval.Push(5);

            try
            {
                int çuval1 = çuval.Pop();
                Console.WriteLine(çuval1);
                int çuval2 = çuval.Pop();
                Console.WriteLine(çuval2);
                int çuval3 = çuval.Pop();
                Console.WriteLine(çuval3);
            }
            catch (Exception)
            {
                Console.WriteLine("stack boş");
                throw;
            }

            if (çuval.Contains(1))
            {
                Console.WriteLine("stackte 1 var");
            }
            else
            {
                Console.WriteLine("stackte 1 yok");
            }

            if (çuval.Contains(2))
            {
                Console.WriteLine("stackte 2 var");
            }
            else
            {
                Console.WriteLine("stackte 2 yok");
            }
            */











            Console.ReadKey();
        }
    }
}
