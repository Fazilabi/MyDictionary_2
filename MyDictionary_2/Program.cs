using System;

namespace MyDictionary_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.AddDict("Fazil", "Gurban");
            myDictionary.AddDict("Murad", "Isayev");

            
            Console.WriteLine(myDictionary.keysLength);

            foreach (var item in myDictionary.tkey)
            {
                Console.WriteLine(item);
            }

        }
    }

    class MyDictionary<Tkey, Tvalue>
    {
        // Evvelce tkeys ve tvalues adinda array yaradiriq;
        Tkey[] tkeys;
        Tvalue[] tvalues;

        // Daha sonra MyDictionary classini cagiranda ilk iwe duzen metod olan constructor metodunu yaradiriq.
        public MyDictionary()
        {
            // MyDictionary classini cagiranda constructor metodu iwe duwur ve ilk yaranacaq  arrayleri yaziriq
            tkeys = new Tkey[0];
            tvalues = new Tvalue[0];
        }
        public void AddDict(Tkey tkey, Tvalue tvalue)
        {
            // Yaranan yeni MyDictionary classina yeni itemlar Add ederken movcud olan arraylardan itemlar silineceyi ucun
            // hemin itemlari kecici olaraq bir datatype-da saxlamaq ucun temporary adinda deyiskende saxlayiriq.
            Tkey[] temp_keys = tkeys;
            Tvalue[] temp_values = tvalues;

            // daha sonra yeni item elave etmek ucun tkey ve tvalue arraylarinin length-ni her yeni itema gore artirmaliyiq
            tkeys = new  Tkey[tkeys.Length + 1];
            tvalues = new Tvalue[tvalues.Length + 1];

            // arraylerin uzunlugunu artirdiqdan sonra kecici olaraq temporary deyiskeninde saxladigimiz datalari yeni yaratdigimiz 
            // arraylere geri almaq ucun, temporary deyiskeninin uzunlugu qeder for dongusu qururuq ve for  vasitesile uzunlugu artirilmis arraya geri aliriq.

            for (int i = 0; i < temp_keys.Length; i++)
            {
                tkeys[i] = temp_keys[i];
            }

            for (int i = 0; i < temp_values.Length; i++)
            {
                tvalues[i] = temp_values[i];
            }
            // dictionary-e elave etmek istediyimiz item-i sonuncu siraya yerlesdirmek ucun, uzunlugunu artirdigimiz
            // arrayin son xanasi bos oldugu ucun  array.length-1 dedikde en sonuncu bow yere elave etmis oluruq
            tkeys[tkeys.Length - 1] = tkey;
            tvalues[tvalues.Length - 1] = tvalue;
        }

        public int keysLength
        {
            get { return tkeys.Length; }     
        }
        public int valuesLength
        {
            get { return tvalues.Length; }
        }

        public Tkey[] tkey
        {
            get { return tkeys; }
        }
        public Tvalue[] tvalue
        {
            get { return tvalues; }
        }

    }
}
