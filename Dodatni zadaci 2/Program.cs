using System;

namespace Dodatni_zadaci2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dodatni zadaci2 zadatak 1 \n\n");
            // 1. Korisnik unosi broj u intervalu (1-10) i broj se ispisuje, ukoliko korisnik unese broj 7
            // prekinuti program. 

            int unosZad1;

            do
            {
                Console.WriteLine("unesi broj u intervalu od 1 do 10");
                unosZad1 = int.Parse(Console.ReadLine());
                if (unosZad1 == 7)
                    break;
                if (unosZad1 <= 10 && unosZad1 >= 1)
                    Console.WriteLine(unosZad1);
            } while (unosZad1 != 7);

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci2 zadatak 2 \n\n");
            // 2. Korisnik bira koliko puta želi da pogađa vašu lozinku. Ukoliko unese pravu, pitati koliko
            // će se nasumičnih brojeva generisati.Prikazati samo parne generisane brojeve.Izabrati
            // lozniku po želji. 

            int brojPokusajaZad2, lozinkaZad2 = 1234, unosZad2, brojNasumicnihZad2 = 0, generisaniBrojeviZad2;
            Random rand = new Random();

            Console.WriteLine("koliko puta hocete da birate lozinku?");
            brojPokusajaZad2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < brojPokusajaZad2; i++)
            {
                Console.WriteLine("unesite lozinku.");
                unosZad2 = int.Parse(Console.ReadLine());
                if (unosZad2 == lozinkaZad2)
                {
                    Console.WriteLine("koliko ce se nasumicnih brojeva generisati?");
                    brojNasumicnihZad2 = int.Parse(Console.ReadLine());

                    for (int j = 0; j < brojNasumicnihZad2; j++)
                    {
                        generisaniBrojeviZad2 = rand.Next(100);
                        if (generisaniBrojeviZad2 % 2 == 0)
                            Console.WriteLine(generisaniBrojeviZad2);
                    }
                }
            }

            Console.WriteLine("unesite novu lozinku:");
            lozinkaZad2 = int.Parse(Console.ReadLine());

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci2 zadatak 3 \n\n");
            // 3. Unosi se n brojeva treba izračunati zbir svakog drugog parnog broja i srednju vrednost
            // svakog drugog nepranog broja. 

            int brUnosaZad3, unosZad3, brojilacParnihZad3 = 0, brojilacNeparnihZad3 = 0, zbirParnihZad3 = 0, zbirNeparnihZad3 = 0, brojilacNeparnihJedanZad3 = 0; decimal averageNeparnihZad3;

            Console.WriteLine("koliko brojeva zelite da unesete");
            brUnosaZad3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < brUnosaZad3; i++)
            {
                Console.WriteLine("unesite broj");
                unosZad3 = int.Parse(Console.ReadLine());
                if (unosZad3 % 2 == 0)
                {
                    brojilacParnihZad3++;
                    if (brojilacParnihZad3 == 2)
                    {
                        zbirParnihZad3 += unosZad3;
                        brojilacParnihZad3 *= 0;
                    }
                }
                else
                {
                    brojilacNeparnihZad3++;
                    if (brojilacNeparnihZad3 == 2)
                    {
                        zbirNeparnihZad3 += unosZad3;
                        brojilacNeparnihZad3 *= 0;
                        brojilacNeparnihJedanZad3++;
                    }
                }
            }
            Console.WriteLine($"Zbir svakog drugog parnog broja iznosi - {zbirParnihZad3}");
            if (brojilacNeparnihJedanZad3 != 0)
            {
                averageNeparnihZad3 = (decimal)zbirNeparnihZad3 / brojilacNeparnihJedanZad3;
                Console.WriteLine($"Srednja vrednost svakog drugog neparnog broja iznosi: {averageNeparnihZad3}");
            }
            else
            {
                Console.WriteLine("niste uneli vise od jednog neparnog broja, a mozda ni taj jedan.");
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("dodatni zadaci2 zadatak 4 \n\n");
            // 4.Unose se brojevi od 1 do 5.Ako se unese broj 2, dodati mu 10.Ako se unese broj 4
            // oduzeti mu 2.Unošenjem broja 5 prekida se rad programa. Ako unesete broj 1 treba
            // ispisati ukupnu dobijenu sumu.A u slučaju da se unese broj 3 suma se restartuje.

            int unosZad4, sumaZad4 = 0;

            do
            {
                Console.WriteLine("unesite broj od 1 do 5");
                unosZad4 = int.Parse(Console.ReadLine());
                if (unosZad4 == 5)
                    break;
                sumaZad4 += unosZad4;
                if (unosZad4 == 2)
                    sumaZad4 += 10;
                if (unosZad4 == 4)
                    sumaZad4 -= 2;
                if (unosZad4 == 1)
                    Console.WriteLine(sumaZad4);
                if (unosZad4 == 3)
                    sumaZad4 *= 0;

            } while (unosZad4 != 5);

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci2 zadatak 5 \n\n");
            // 5.Unosite n brojeva. Ispisati treći i peti broj kao i prvi parni.Ispisati sumu svih brojeva. 

            int brojUnosaZad5, unosZad5, sumaZad5 = 0, brojacZad5 = 0, brojacJedanZad5 = 0;

            Console.WriteLine("Koliko brojeva zelite da unesete?");
            brojUnosaZad5 = int.Parse(Console.ReadLine());

            for (int i = 0; i < brojUnosaZad5; i++)
            {
                Console.WriteLine("unesite broj");
                unosZad5 = int.Parse(Console.ReadLine());
                brojacZad5++;
                if (brojacZad5 == 3 || brojacZad5 == 5)
                    Console.WriteLine(unosZad5);
                if (unosZad5 % 2 == 0 && brojacJedanZad5 == 0)
                {
                    Console.WriteLine(unosZad5);
                    brojacJedanZad5++;
                }
                sumaZad5 += unosZad5;
            }
            Console.WriteLine($"suma unetih brojeva iznosi {sumaZad5}");

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 6 \n\n");
            // 6.Korisnik unosi 5 imena, izbrojati koliko se puta pojavilo slovo „A“. 

            int brojacZad6 = 0;
            string[] unosImenaZad6 = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"unesite {i + 1}. ime");
                unosImenaZad6[i] = Console.ReadLine();
            }
            for (int i = 0; i < unosImenaZad6.Length; i++)
            {
                foreach (char item in unosImenaZad6[i])
                {
                    if (item == 'A')
                    {
                        brojacZad6++;
                    }
                }
            }
            Console.WriteLine($"ukupno se pojavilo {brojacZad6} slova A");

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            foreach (string item in unosImenaZad6)
                Console.WriteLine(item);

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 7 \n\n");
            // 7.Generiše se niz od 10 brojeva u intervalu od 1 do 30.Ispisati samo neparne brojeve,
            // izračunati sumu parnih brojeva i njihovu srednju vrednost.

            int[] nizZad7 = new int[10];
            int sumaParnihZad7 = 0, brojacZad7 = 0;
            decimal averageZad7;

            for (int i = 0; i < nizZad7.Length; i++)
            {
                nizZad7[i] = rand.Next(30);
                Console.WriteLine($"izabrani broj - {nizZad7[i]}");

                if (nizZad7[i] % 2 == 0)
                {
                    sumaParnihZad7 += nizZad7[i];
                    brojacZad7++;
                }
                else
                {
                    Console.WriteLine($"neparni - {nizZad7[i]}");
                }
            }
            if (brojacZad7 != 0)
            {
                Console.WriteLine($"suma parnih iznosi - {sumaParnihZad7}");
                averageZad7 = (decimal)sumaParnihZad7 / brojacZad7;
                Console.WriteLine($"Prosek parnih brojeva iznosi {averageZad7}");
            }
            else
            {
                Console.WriteLine("Nije bilo parnih unetih brojeva");
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 8 \n\n");
            //8.Napraviti niz n dužine i popuniti ga brojevima.Izračunati zbir i prosečnu vrednost niza. 

            int[] nizZad8 = new int[15];
            int zbirZad8 = 0;
            decimal averageZad8 = 0;

            for (int i = 0; i < nizZad8.Length; i++)
            {
                nizZad8[i] = rand.Next(100);
                Console.WriteLine(nizZad8[i]);
                zbirZad8 += nizZad8[i];
                if (i != 0)
                    averageZad8 = (decimal)zbirZad8 / (i + 1);
            }
            Console.WriteLine("Prosek iznosi - {0}", averageZad8);

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("dadatni zadaci 2 zadatak 9 \n\n");
            // 9.Niz A sadrži 10 slučajno generisanih brojeva(1 - 10).Prikazati niz u jednoj liniji.
            // Elemente sa parnim indeksom uvećati za 100.Ispisati sve elemente. 

            int[] nizAZad9 = new int[10];

            for (int i = 0; i < nizAZad9.Length; i++)
            {
                nizAZad9[i] = rand.Next(10);
                Console.Write($"{nizAZad9[i]}, ");
                if (i % 2 == 0 && i != 0)
                    nizAZad9[i] *= 100;
            }
            Console.WriteLine();
            foreach (int item in nizAZad9)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 10 \n\n");
            // 10.Niz X[20] su slučajni brojevi od 1 do 50.Ispisati samo parne brojeve veće od 25.

            int[] nizXZad10 = new int[20];

            for (int i = 0; i < nizXZad10.Length; i++)
            {
                nizXZad10[i] = rand.Next(50);
                if (nizXZad10[i] % 2 == 0 && nizXZad10[i] > 25)
                    Console.WriteLine(nizXZad10[i]);
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 11 \n\n");
            // 11.Niz X[30] su slučajni brojevi od 1 do 20, a niz Y čine elementi koji se pojave u nizu X
            // samo jednom.

            int[] nizXZad11 = new int[30], nizKucicaZad11 = new int[21];

            for (int i = 0; i < nizXZad11.Length; i++)
            {
                nizXZad11[i] = rand.Next(20);
                Console.WriteLine(nizXZad11[i]);
            }
            Console.WriteLine("break");
            for (int i = 0; i < nizKucicaZad11.Length; i++)
            {
                nizKucicaZad11[nizXZad11[i]] += 1;
            }
            foreach (int item in nizKucicaZad11)
                Console.WriteLine(item);

            int brojacZad11 = 0;

            for (int i = 0; i < nizKucicaZad11.Length; i++)
            {
                if (nizKucicaZad11[i] == 1)
                    brojacZad11++;
            }

            int[] nizYZad11 = new int[brojacZad11];
            int brojacJedanZad11 = 0;

            for (int i = 0; i < nizKucicaZad11.Length; i++)
            {
                if (nizKucicaZad11[i] == 1)
                {
                    nizYZad11[brojacJedanZad11] = i;
                    brojacJedanZad11++;
                }
            }
            Console.WriteLine("break ");
            foreach (int item in nizYZad11)
                Console.WriteLine(item);

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak  12 \n\n");
            //12.Napisati program za razdvajanje niza A na dva niza. U niz B se kopiraju elementi sa
            //parnim indeksom, a u niz C sa neparnim indeksima.Ispisati nizove B i C

            int[] nizAZad12 = new int[20], nizBZad12 = new int[10], nizCZad12 = new int[10];
            int brojacBZad12 = 0, brojacCZad12 = 0;

            for (int i = 0; i < nizAZad12.Length; i++)
            {
                nizAZad12[i] = rand.Next(10);
                Console.WriteLine($"clan niza - {nizAZad12[i]}, index - {i}");
                if (i % 2 == 0)
                {
                    nizBZad12[brojacBZad12] = nizAZad12[i];
                    brojacBZad12++;
                }
                else
                {
                    nizCZad12[brojacCZad12] = nizAZad12[i];
                    brojacCZad12++;
                }
            }
            Console.WriteLine("niz b(parni index)");
            foreach (int item in nizBZad12)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("niz c(neparni index)");
            foreach (int item in nizCZad12)
                Console.WriteLine(item);

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 12 \n\n");
            // 13.Uneti 7 brojeva, prikazati drugi, četvrti i sedmi uneti broj. Izračunati ukupnu sumu tih
            // brojeva.

            int unosZad12, brojacZad12 = 0, sumaZad12 = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("unesite broj");
                unosZad12 = int.Parse(Console.ReadLine());
                brojacZad12++;
                if (brojacZad12 == 2 || brojacZad12 == 4 || brojacZad12 == 7)
                {
                    Console.WriteLine(unosZad12);
                    sumaZad12 += unosZad12;
                }
            }
            Console.WriteLine($"suma drugog, cetvrtog i sedmog unetog broja iznosi - {sumaZad12}");

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 14 \n\n");
            // 14.Pitati 10 korisnika da li su punoletni.Ukoliko jesu dodelite im generisanu šifru od 10000
            // do 20000.Odrediti najveću dodeljenu šifru. 

            int brojacZad14 = 0, kucicaZad14 = 0;
            string unosZad14;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Da li ste punoletni ?");
                unosZad14 = Console.ReadLine();
                if (unosZad14 == "da")
                    brojacZad14++;
            }

            int[] brojPunoletnihSifraZad14 = new int[brojacZad14];

            for (int i = 0; i < brojPunoletnihSifraZad14.Length; i++)
            {
                brojPunoletnihSifraZad14[i] = rand.Next(10000, 20000);
                if (brojPunoletnihSifraZad14[i] > kucicaZad14)
                    kucicaZad14 = brojPunoletnihSifraZad14[i];
            }

            foreach (int item in brojPunoletnihSifraZad14)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"najveca dodeljena sifra iznosi {kucicaZad14}");

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 15 \n\n");
            //15.Takmičite se sa računarom.Unosite 10 brojeva u intervalu od 1 do 10.Program na svaki
            //vaš broj generiše svoj broj. Pobedili ste ako ste uneli dva puta isti broj kao i program, u
            //suprotnom ste izgubili.Ispisati ishod(koliko puta ste pogodili, a koliko puta niste. ).

            int brojilacZad15 = 0, unosJaZad15, unosRacunarZad15;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("unesite broj");
                unosJaZad15 = int.Parse(Console.ReadLine());
                unosRacunarZad15 = rand.Next(10);
                if (unosJaZad15 == unosRacunarZad15)
                    brojilacZad15++;
            }
            if (brojilacZad15 == 2)
                Console.WriteLine("Pobedili ste");

            else
                Console.WriteLine("Wa Wa Waaaaaa");
            if (brojilacZad15 == 1)
                Console.WriteLine("Pogodili ste 1. put, a promasili 9. puta");
            else if (brojilacZad15 == 9)
                Console.WriteLine("Pogodili ste 9. puta a promasili jedan put");
            else
                Console.WriteLine($"Pogodili ste {brojilacZad15}. puta, a promasili ste {10 - brojilacZad15}. puta");

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 16 \n\n");
            // 16.Za svaki uneti parni broj brojač povećati za 2, za svaki uneti neprani broj brojač smanjiti
            // za jedan.Izračunati zbir parnih i neparnih brojeva za unete brojeve kao i vrednost
            // brojača.

            int unosZad16, brojacZad16 = 0, zbirParnihZad16 = 0, zbirNeparnihZad16 = 0;

            for (int i = 0; i < 10; i++)
            {
                unosZad16 = rand.Next(10);
                Console.WriteLine(unosZad16);
                if (unosZad16 % 2 == 0)
                {
                    zbirParnihZad16 += unosZad16;
                    brojacZad16 += 2;
                }
                else
                {
                    zbirNeparnihZad16 += unosZad16;
                    brojacZad16 -= 1;
                }
            }
            Console.WriteLine($"zbir parnih iznosi {zbirParnihZad16}, zbir neparnih iznosi {zbirNeparnihZad16}, brojilac iznosi {brojacZad16}.");

            Console.WriteLine("dalje");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 17 \n\n");
            // 17.Izračunati i ispisati sumu kvadrata prvih n prirodnih brojeva. 

            int kolicinaPrirodnihBrojevaZad17, prirodniBrojeviZad17 = 0, kucicaZad17, sumaZad17 = 0;

            Console.WriteLine("Koliko brojeva hoces da kvadriras i sumiras");
            kolicinaPrirodnihBrojevaZad17 = int.Parse(Console.ReadLine());

            for (int i = 0; i < kolicinaPrirodnihBrojevaZad17; i++)
            {
                prirodniBrojeviZad17++;
                kucicaZad17 = prirodniBrojeviZad17 * prirodniBrojeviZad17;
                sumaZad17 += kucicaZad17;
            }
            Console.WriteLine(sumaZad17);

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 18 \n\n");
            // 18.Napraviti niz od 10 imena, ispisati one koji imaju 5 ili više karaktera.

            string[] imenaZad18 = { "Petar", "Katarina", "Djordje", "Nebojsa", "Mirjana", "Miki", "Ziki", "Tiki", "Goki", "Moki" };
            int brojacZad18 = 0;

            for (int i = 0; i < imenaZad18.Length; i++)
            {
                foreach (char item in imenaZad18[i])
                {
                    brojacZad18++;
                }
                if (brojacZad18 >= 5)
                    Console.WriteLine(imenaZad18[i]);
                brojacZad18 *= 0;
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 2 zadatak 19 \n\n");
            // 19.Unesi svoje ime i prezime. Pomoću foreach petlje izračunati koliko tvoje ime i prezime
            // ima karaktera.

            string imeZad19, prezimeZad19;
            int brojacImeZad19 = 0, brojacPrezimeZad19 = 0;

            Console.WriteLine("Unesi ime");
            imeZad19 = Console.ReadLine();
            Console.WriteLine("Unesi prezime");
            prezimeZad19 = Console.ReadLine();

            foreach (char item in imeZad19)
                brojacImeZad19++;
            foreach (char item in prezimeZad19)
                brojacPrezimeZad19++;
            Console.WriteLine($"Ime ima {brojacImeZad19} karaktera, prezime ima {brojacPrezimeZad19} karaktera");

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci zadatak 20 \n\n");
            // 20.Generiše se niz od 10 brojeva.Ispisati svaki treći član. 

            int[] nizZad10 = new int[10];

            for (int i = 0; i < nizZad10.Length; i++)
            {
                nizZad10[i] = rand.Next(20);
                Console.WriteLine($"izabrani broj - {nizZad10[i]}, index - {i}");
                if ((i + 1) % 3 == 0)
                    Console.WriteLine(nizZad10[i]);
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci zadatak 21 \n\n");
            // 21.Pitati jednog korisnika da unese 5 brojeva, a zatim pitati drugog da unese još toliko.
            // Ukoliko su na istom indeksu u oba niza upisani isti brojevi prikazati te brojeve.

            int[] prviKorisnikZad21 = new int[5], drugiKorisnikZad21 = new int[5];

            for (int i = 0; i < prviKorisnikZad21.Length; i++)
            {
                Console.WriteLine($"Unesite {i + 1} clan");
                prviKorisnikZad21[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < drugiKorisnikZad21.Length; i++)
            {
                Console.WriteLine($"Unesite {i + 1} clan");
                drugiKorisnikZad21[i] = int.Parse(Console.ReadLine());
                if (prviKorisnikZad21[i] == drugiKorisnikZad21[i])
                {
                    Console.WriteLine(drugiKorisnikZad21[i]);
                }
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci zadatak 22 \n\n");
            // 22.Napisati program za izračunavanje minimalnog i maksimalnog člana niza dužine N.
            // Ispisati elemente niza.

            int duzinaNizaZad22;

            Console.WriteLine("Kolika je duzina niza?");
            duzinaNizaZad22 = int.Parse(Console.ReadLine());

            int[] nizZad22 = new int[duzinaNizaZad22];
            int minNizaZad22 = nizZad22[0], maxNizaZad22 = nizZad22[0];

            for (int i = 0; i < nizZad22.Length; i++)
            {
                nizZad22[i] = rand.Next(30);
                Console.WriteLine($"izabrani broj- {nizZad22[i]}");
                if (nizZad22[i] < minNizaZad22)
                    minNizaZad22 = nizZad22[i];
                if (nizZad22[i] > maxNizaZad22)
                    maxNizaZad22 = nizZad22[i];
            }
            Console.WriteLine($"najveci clan niza iznosi {maxNizaZad22}, najmanji clan niza iznosi {minNizaZad22}");

            Console.WriteLine("Dodatni zadaci zadatak 23 \n\n");
            // 23.Niz X[30] su slučajni brojevi od 1 do 50.U niz Y upisati samo brojeve koji su deljivi sa 3
            // i 5.Ispisati niz Y. 

            int[] nizXZad23 = new int[30];
            int duzinaNizaYZad23 = 0, brojacPozicijeNizaYZad23 = 0;

            for (int i = 0; i < nizXZad23.Length; i++)
            {
                nizXZad23[i] = rand.Next(50);
                Console.WriteLine($"izabran broj - {nizXZad23[i]}");
                if (nizXZad23[i] % 3 == 0 && nizXZad23[i] % 5 == 0)
                    duzinaNizaYZad23++;
            }

            int[] nizYZad23 = new int[duzinaNizaYZad23];
            for (int i = 0; i < nizXZad23.Length; i++)
            {
                if (nizXZad23[i] % 3 == 0 && nizXZad23[i] % 5 == 0)
                {
                    nizYZad23[brojacPozicijeNizaYZad23] = nizXZad23[i];
                    brojacPozicijeNizaYZad23++;
                }
            }
            foreach (int item in nizYZad23)
                Console.WriteLine($"broj niza Y - {item}");

            Console.WriteLine("Dodatni zadaci zadatak 24 \n\n");
            // 24.Niz X[10] su sučajni brojevi u intervalu(1, 30).Članove prve polovine niza uvećati za 5, 
            // a u članove druge polovine niza za 10.Prikazati niz.

            int[] nizXZad24 = new int[10];

            for (int i = 0; i < nizXZad24.Length; i++)
            {
                nizXZad24[i] = rand.Next(30);
                Console.WriteLine($"Izabrani broj - {nizXZad24[i]}");
                if (i >= nizXZad24.Length / 2)
                    nizXZad24[i] += 10;
                else
                    nizXZad24[i] += 5;
            }
            foreach (int item in nizXZad24)
                Console.WriteLine($"Niz - {item}");
        }
    }
}
