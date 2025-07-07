    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace WindowsFormsApp5
    {
        internal static class Program
        {
            /// <summary>
            /// Uygulamanın ana girdi noktası.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                int n = 1;
                string[] kitaplar = new string[n];
                kitaplar[0] = "Suç ve Ceza";
                Console.WriteLine("Yapmak istediğiniz işlem nedir");
                Console.WriteLine("Almak/Kayıt Ettirmek/Vermek");
                Console.WriteLine(" ");
                string islem;
                islem = Console.ReadLine();
                islem = islem.ToLower();
                while (islem != "cıkıs")
                {
                    Console.WriteLine("Yapmak istediğiniz işlem nedir");
                    Console.WriteLine("Almak/Kayıt Ettirmek/Vermek");
                    Console.WriteLine(" ");
                    if (islem == "almak")
                    {
                        Console.WriteLine("Hangi Kitabı Almak İstiyorsunuz");
                        Console.WriteLine("");
                        foreach (string s in kitaplar) { Console.WriteLine(s); }
                        string alınan;
                        alınan = Console.ReadLine();
                        for (int i = 0; i < kitaplar.Length; i++)
                        {
                            if (kitaplar[i] == alınan)
                            {
                                Console.WriteLine("İsminiz nedir?");
                                string isim = Console.ReadLine();
                                kitaplar[i] = alınan + " Alan: " + isim;
                                break;
                            }
                        }
                        Console.WriteLine("İşleminiz Tamamlanmıştır");

                    }
                    if (islem == "kayıt ettirmek")
                    {
                        Console.WriteLine("Yeni kitabın ismini giriniz:");
                        string yenikayit = Console.ReadLine();
                        string[] yenidizi = new string[kitaplar.Length + 1];
                        for (int i = 0; i < kitaplar.Length; i++)
                        {
                            yenidizi[i] = kitaplar[i];
                        }
                        yenidizi[yenidizi.Length - 1] = yenikayit;
                        kitaplar = yenidizi;
                        n = kitaplar.Length;

                    }
                    if (islem == "vermek")
                    {
                        Console.WriteLine("Vermek İstediğiniz Kitap İsmini Yazınız");
                        string verilen;
                        verilen = Console.ReadLine();
                        for (int i = 0; i < kitaplar.Length; i++)
                        {
                            if (kitaplar[i].Contains(verilen))
                            {
                                kitaplar[i] = verilen;
                                Console.WriteLine("İşleminiz Tamamlanmıştır");
                                break;
                            }
                        }
                    }
                    Console.WriteLine("Yapmak istediğiniz işlem nedir?(çıkış için cıkıs yazınız");
                    Console.WriteLine("Kitap Almak/Kayıt Ettirmek/Vermek");
                    islem = Console.ReadLine();
                    islem = islem.ToLower();
                }

            }
        }
    }
