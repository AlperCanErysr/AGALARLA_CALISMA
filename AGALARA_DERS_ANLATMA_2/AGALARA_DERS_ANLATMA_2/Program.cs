using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGALARA_DERS_ANLATMA_2
{
    internal class Program
    {
        /*
        public struct Kisi
        {
            public string adsoyad;
            public int paraMiktarı;

            public Kisi(string adsoyad,int paraMiktarı)
            {
                this.adsoyad = adsoyad;
                this.paraMiktarı = paraMiktarı;
            }
        }
        */






        static void Main(string[] args)
        {



            /*
            Dictionary<int, string> Kütüphane = new Dictionary<int, string>();

            try
            {
                Kütüphane.Add(1,"EXPRESS");
                Kütüphane.Add(2,"KM43");
                Kütüphane.Add(3,"KM45");

                string agubugu = "";
                Kütüphane.TryGetValue(2, out agubugu);
                Console.WriteLine(agubugu);

                Console.WriteLine(Kütüphane[1]);

                Kütüphane[1] = Kütüphane[1] + " KRALDIR";
                Console.WriteLine(Kütüphane[1]);

                KeyValuePair<int, string> yenihat = new KeyValuePair<int, string>(4, "132N");
                if (!Kütüphane.ContainsKey(4))
                {
                    Kütüphane.Add(4, "132N");
                }
                Console.Write(Kütüphane[4]);


                



            }
            catch (Exception)
            {

                throw;
            }
            */



















            /*
             * 
            const int ıspanak = 15;      //ıspanağın fiyatı 15tl olsun
            const int marul = 15;     //marulun fiyatı 15tl olsun
            const int elma = 20;    //elmanın fiyatı 20tl olsun



            Kisi kisi1 = new Kisi();
            Kisi kisi2 = new Kisi();
            Kisi kisi3 = new Kisi();
            Kisi kisi4 = new Kisi();    // her bir alışverişimizde önümüzde 2şer kişi olacak
            Kisi kisi5 = new Kisi();
            Kisi kisi6 = new Kisi();

            int kalanparamiktarı;

            Kisi biz =new Kisi("ALPER CAN",100);
            Kisi[] ilkiki = { kisi1, kisi2 };




            Queue<Kisi> onumuz1 = new Queue<Kisi>(ilkiki);
            onumuz1.Enqueue(biz);

            while (onumuz1.Count>0)
            {
                Kisi kisiler = onumuz1.Peek();
                if (kisiler.adsoyad!=null)
                {
                    biz.paraMiktarı -= elma;
                }
                onumuz1.Dequeue();
            }
            Console.WriteLine("elma aldıktan sonra kalan para {0}", biz.paraMiktarı);


            */














            /*
            ArrayList agubugu = new ArrayList();
            agubugu.Add(1);
            agubugu.Add(2);
            agubugu.Add(3);
            agubugu.Add(false);
            agubugu.Add("ALPER");

            Console.WriteLine(agubugu.Count);
            Console.WriteLine(agubugu.Contains("ALPER"));
            Console.WriteLine(agubugu[1]);
            agubugu.Remove(1);

           /*





















            /*
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("A");
            list.AddLast("A");
            list.AddLast("A");
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");
            list.AddLast("D");
            list.AddLast("E");

            //list.AddFirst("F");   //listenin en başına ekler

            LinkedListNode<string> node = list.Find("C"); // listede ki c yi buluyor
            list.Remove(node);  //ve c yi siliyor
            
            LinkedListNode<string> node2=list.Find("D");
            list.AddAfter(node2, "D2");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            // list.RemoveFirst(); //listede ki ilk elemanı siliyor
           //  list.RemoveLast();//listede ki en son elemanı siliyor

            Console.WriteLine("Listede ki eleman sayısı = {0} ", list.Count);

            int A_lar = list.Count(b => b == "A");
            Console.WriteLine("Listede ki A sayısı = {0} ", A_lar);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            */
















            /*
            Stack<string> agubugu = new Stack<string>();
            agubugu.Push("Alper"); //stack içine eleman ekler
            agubugu.Push("Can");

            try
            {

                string deger = agubugu.Pop();  //eleman çıkartmak için
                Console.WriteLine(deger);
            }
            catch (Exception)
            {

                throw;
            }
            if (agubugu.Contains("Alper"))  //contains stack içinde girilen parametreyi arar
            {
                Console.WriteLine("Mevcut.");
            }
            else
            {
                Console.WriteLine("Mevcut Değil.");
            }
            */

            Console.ReadKey();
        }
    }
}
