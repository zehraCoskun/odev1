internal class Program
{
    private static void Main(string[] args)
    {
    basla:
        Console.WriteLine("çalıştırmak istediğiniz koşulun numarasını yazınız");
        string kosul = Console.ReadLine();
        if (kosul == "1")
        { Kosul1(); }
        else if (kosul == "2")
        { Kosul2(); }
        else if (kosul == "3")
        { Kosul3(); }
        else if (kosul == "4")
        { Kosul4(); }
//kullanıcıdan alınan verilerin string beklendiğinde string, int beklendiğinde int değer girildiği kabul edilmiştir

        static void Kosul1()
        {
            //girilen değelerierin çift olanlarını seçer

            Console.WriteLine("Kaç sayıyı kontrol etmek istersiniz?");
            int nSayisi = int.Parse(Console.ReadLine());

            int[] tamSayilar = new int[nSayisi];

            if (nSayisi < 10 && 0 < nSayisi)
            {
                //Console.WriteLine("tam sayı giriniz");
                for (int i = 0; i < nSayisi; i++)
                {
                    Console.WriteLine("kontrol etmek istediğiniz sayıyı giriniz");
                    tamSayilar[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else { Console.WriteLine("lütfen 1 ile 9 arasında bir rakam giriniz"); }

            Console.WriteLine("girdiğiniz sayılar içinde çift olanlar şunlardır ;");
            for (int x = 0; x < tamSayilar.Length; x++)
            {
                if (tamSayilar[x] % 2 == 0)
                { Console.WriteLine(tamSayilar[x]); }
            }
        }
        goto basla;

        static void Kosul2()
        {
            //n tane sayı m sayısının katı mı değil mi kontrolü

            Console.WriteLine("Kaç sayıyı kontrol etmek istersiniz?");
            int nSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("hangi sayının katı olduğunu bulmak istersiniz?");
            int mSayisi = int.Parse(Console.ReadLine());

            int[] tamSayilar = new int[nSayisi];

            if (0 < nSayisi)
            {
                for (int i = 0; i < nSayisi; i++)
                {
                    Console.WriteLine("kontrol etmek istediğiniz sayıyı giriniz");
                    tamSayilar[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else { Console.WriteLine("yalnızca pozitif tam sayı girilebilir"); }

            Console.WriteLine("aradığınız sayılar şunlardır ;");
            for (int x = 0; x < tamSayilar.Length; x++)
            {
                if (tamSayilar[x] % mSayisi == 0)
                { Console.WriteLine(tamSayilar[x]); }
            }
        }
        goto basla;

        static void Kosul3()
        {
            //n sayısı kadar kelime alıp tersten cümle oluşturma;

            Console.WriteLine("kaç kelime girmek istersiniz?");
            int kelimeSayisi = int.Parse(Console.ReadLine());
            string[] kelimeListesi = new string[kelimeSayisi];

            for (int i = 0; i < kelimeSayisi; i++)
            {
                Console.WriteLine("kelime giriniz");
                kelimeListesi[i] = Console.ReadLine();
            }
            Console.WriteLine("cümleniz aşağıdadır;");
            Array.Reverse(kelimeListesi);
            foreach (var item in kelimeListesi)
            {
                Console.Write(item);
            }
        }
        goto basla;
        static void Kosul4()
        {
        //alınan cümledeki kelime ve harf sayısını bulma;

        basla4:
            Console.WriteLine("bir kelimeden uzun cümle giriniz");
            string cumle = Console.ReadLine().Trim();
            string[] dizi = cumle.Split(" ");
            int kelimeSayisi = dizi.Count();
            if (kelimeSayisi > 1)
            {
                Console.WriteLine("cümlenizdeki kelime sayısı : " + kelimeSayisi);

                //char harfler = char.Parse(cumle);
                string[] harfler = cumle.Split("");
                Console.Write("cümlenizdeki harf sayısı : ");
                Console.Write(cumle.Length - kelimeSayisi + 1);
                Console.WriteLine(" ");
            }
            else { goto basla4; }
        }
        goto basla;

    }
}