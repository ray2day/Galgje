using System;
using System.Text.RegularExpressions;

namespace Galgje
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zie Scherp | Hoofdstuk 8 | Oefening 1d | Galgje | ©2021 Raymond van Hoorn

            while (true)                                                                                                            // (het hele programma is een) oneindige loop
            {
                // *** INITIALISATIE en SET UP ***

                Console.Clear();
                Console.WriteLine("GALGJE");
                Console.WriteLine("======\n");

                int a = 0; while (a < 9) { Console.WriteLine(" "); a++; }

                string[] woordenLijst = { "CAVIA", "KRUKJE", "GALGJE", "TIJD", "FORS", "SAMBAL", "ZUIVEL", "KRITISCH", "JASJE", "GIGA", "DIEREN", "LEPEL", "PICKNICK", "QUASI", "VERZENDEN", "WINNAAR", "DEXTROSE", "VREZEN", "NIQAAB", "HIERBIJ", "QUOTE", "BOTOX", "CRUCIAAL", "ZITTING", "CABARET", "BEWOGEN",
                                          "VRIJUIT", "IJVERIG", "CAKE", "DYSLEXIE", "UIER", "NIHIL", "SAUSJE", "KUUROORD", "POPPETJE", "DOCENT", "CAMPING", "SCHIJN", "KLOPPEN", "DETOX", "BOYCOT", "CYCLUS", "QUIZ", "CENSUUR", "AAIBAAR", "CHAGRIJNIG", "FICTIEF", "CHEF", "GERING", "NACHT", "ALCOHOL", "PROGRAMMEERTAAL",
                                          "CACAO", "TRIOMF", "BABY", "IJSTIJD", "CRUISEN", "ONTZEGGEN", "QUAD", "OPEN", "TURQUOISE", "CARNAVAL", "BOXER", "STRAKS", "FYSIEK", "ACCU", "TWIJG", "GAMMEL", "FLIRT", "FUTLOOS", "VREUGDE", "OGEN", "GELOOF", "PERIODE", "VOLWAARDIG", "UITLEG", "SLAK", "COMPUTER",
                                          "STUK", "VOLK", "EVEN", "STIJL", "VAL", "ALLIANTIE", "TOCHT", "MOOI", "JOGGEN", "BROEK", "KWIK", "WERKSFEER", "VORM", "NIEUW", "SOPRAAN", "MILJOEN", "INRICHTING", "KLACHT", "DAK", "ECHT", "SCHIKKING", "PRINT", "OORLOG", "ZIJRAAM", "HYACINT", "CHALET",
                                          "WASMACHINE", "BALKON", "POES", "TELEVISIE", "TELEFOON", "LAMINAAT", "STEKKERDOOS", "MAGAZINE", "EIKENBOOM", "PANNENKOEKEN", "STAMPPOT", "KRAAN", "WASTAFEL", "TANDENBORSTEL", "NIETMACHINE", "PERFORATOR", "NAAIMACHINE", "PLAKBAND", "INTERESSE", "KUSSEN",
                                          "KAUGOMBALLENAUTOMAAT", "ZOUTWATERAQUARIUM", "KONINGSKIND", "OOGGETUIGENVERSLAG", "HUISVUILVERBRANDINGSINSTALLATIE", "RADICALISERING", "PARFUMERIEZAAK", "HISTORICUS", "RUITENSPROEIERVLOEISTOF", "GEHANDICAPTEN", "MIGRATIEROUTE", "BOUWKUNDIGE", "HUWELIJKSVRUCHTBAARHEIDSCIJFER",
                                          "AUTISME", "AUTISMESPECTRUMSTOORNIS", "JAZZ", "SCORE", "ETUI", "CACTUS", "LIQUIDATIE", "OASE", "JUNIOR", "CURRY", "BIER", "VORK", "KAT", "HOND", "NEDERLAND", "EGYPTE", "SKELET", "ARCADEKAST", "THEEPOT", "SMAAKPUPIL", "KRABPAAL", "ONSCHULDIG", "FRIET", "WEGENBELASTING" };

                Random randGen = new Random();
                int index = randGen.Next(0, (woordenLijst.Length));
                string teRadenWoord = woordenLijst[index];

                char[] antwoord = new char[teRadenWoord.Length];

                for (int aantalLetterPlaatsen = 0; aantalLetterPlaatsen < teRadenWoord.Length; aantalLetterPlaatsen++)              // indien het aantalLetterPlaatsen kleiner is dan de teRadenWoord-lengte dan -> aantalLetterPlaatsen = aantalLetterPlaatsen + 1
                    antwoord[aantalLetterPlaatsen] = '.';

                int goed = 0;
                int fout = 0;
                string goedeLetters = "";
                string fouteLetters = "";
                bool hoofdProgramma = (true);



                // * * * HOOFDPROGRAMMA * * *

                while (hoofdProgramma)                                                                                              // hoofdprogramma loopt indien hoofdProgramma 'true' is
                {
                    string invoer = "";

                    Console.WriteLine(antwoord);
                    Console.WriteLine($"\n\n{fouteLetters}");                                                                       // weergave foutieve letters

                    do
                    {
                        Console.Write("\nGeef een letter / of typ het woord: ");                                                    // letter- of woordingave
                        invoer = (Console.ReadLine()).ToUpper();
                    }
                    while (!(Regex.IsMatch(invoer, @"^[a-zA-Z]+$")));                                                               // check ofdat de invoer wel één of meerdere letters is


                    if (invoer.Length == 1)                                                                                         // GEEN geheel woord ingevoerd
                    {                                                                                                               // één letter ingevoer
                        char letter = char.Parse(invoer);

                        for (int letterPositie = 0; letterPositie < teRadenWoord.Length; letterPositie++)                           // indien letterPositie kleiner is dan de teRadenWoord-lengte dan -> letterPositie = letterPositie + 1 (constante loop langst alle letters van het teRadenWoord)
                        { if (letter == teRadenWoord[letterPositie]) antwoord[letterPositie] = letter; }
                    }

                    if (teRadenWoord.Contains(invoer)) { goed++; goedeLetters = (goedeLetters + invoer); }
                    else if (invoer.Length == 1) { fout++; fouteLetters = (fouteLetters + invoer + " "); }

                    if ((invoer.Length != 1) && (invoer != teRadenWoord))
                    { Console.WriteLine("\nDAT IS NIET HET JUISTE WOORD!\nGa verder of probeer het nog eens!\n"); fout++; }         // geheel woord ingevoerd en woord niet goed geraden

                    switch (fout)                                                                                                   // weergave galg naar aanleiding van fout(status)

                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            a = 0; while (a < 9) { Console.WriteLine(" "); a++; }
                            break;

                        case 1:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            a = 0; while (a < 6) { Console.WriteLine(" "); a++; }
                            Console.WriteLine("───────");
                            Console.WriteLine("\n");
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            Console.WriteLine(" ┌");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine("─┴─────");
                            Console.WriteLine("\n");
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            Console.WriteLine(" ┌───┐");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine("─┴─────");
                            Console.WriteLine("\n");
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            Console.WriteLine(" ┌───┐");
                            Console.WriteLine(" │/");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine("─┴─────");
                            Console.WriteLine("\n");
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            Console.WriteLine(" ┌───┐");
                            Console.WriteLine(" │/  │");
                            Console.WriteLine(" │   O");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine("─┴─────");
                            Console.WriteLine("\n");
                            break;

                        case 6:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            Console.WriteLine(" ┌───┐");
                            Console.WriteLine(" │/  │");
                            Console.WriteLine(" │   O");
                            Console.WriteLine(" │   |");
                            Console.WriteLine(" │");
                            Console.WriteLine(" │");
                            Console.WriteLine("─┴─────");
                            Console.WriteLine("\n");
                            break;

                        case 7:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            Console.WriteLine(" ┌───┐");
                            Console.WriteLine(" │/  │");
                            Console.WriteLine(" │   O");
                            Console.WriteLine(" │   |");
                            Console.WriteLine(" │  /");
                            Console.WriteLine(" │");
                            Console.WriteLine("─┴─────");
                            Console.WriteLine("\n");
                            break;


                        case 8:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            Console.WriteLine(" ┌───┐");
                            Console.WriteLine(" │/  │");
                            Console.WriteLine(" │   O");
                            Console.WriteLine(" │   |");
                            Console.WriteLine(" │  / \\");
                            Console.WriteLine(" │");
                            Console.WriteLine("─┴─────");
                            Console.WriteLine("\n");
                            break;

                        case 9:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            Console.WriteLine(" ┌───┐");
                            Console.WriteLine(" │/  │");
                            Console.WriteLine(" │  \\O");
                            Console.WriteLine(" │   |");
                            Console.WriteLine(" │  / \\");
                            Console.WriteLine(" │");
                            Console.WriteLine("─┴─────");
                            Console.WriteLine("\n");
                            break;

                        case 10:
                            Console.Clear();
                            Console.WriteLine("GALGJE");
                            Console.WriteLine("======\n");

                            Console.WriteLine(" ┌───┐");
                            Console.WriteLine(" │/  │");
                            Console.WriteLine(" │  \\O/");
                            Console.WriteLine(" │   |");
                            Console.WriteLine(" │  / \\");
                            Console.WriteLine(" │");
                            Console.WriteLine("─┴─────");
                            Console.WriteLine("\n");
                            break;

                    }

                    string oplossing = new string(antwoord);                                                                        // gewonnen
                    if ((invoer == teRadenWoord) || (oplossing == teRadenWoord))
                    {
                        Console.WriteLine("\nJE HEBT HET WOORD GOED GERADEN!");
                        Console.WriteLine($"\nHet woord was inderdaad {teRadenWoord}.");
                        Console.WriteLine("┌─────────────────┐");
                        Console.WriteLine("│                 │");
                        Console.WriteLine("│JE HEBT GEWONNEN!│");
                        Console.WriteLine("│                 │");
                        Console.WriteLine("└─────────────────┘");
                        Console.ReadKey();

                        hoofdProgramma = (false);
                    }


                    if (fout == 10)
                    {
                        Console.WriteLine("\nJE HEBT HET WOORD NIET GERADEN!!");                                                    // verloren / game over
                        Console.WriteLine($"\nHet woord was {teRadenWoord}.");
                        Console.WriteLine("┌─────────────────┐");
                        Console.WriteLine("│                 │");
                        Console.WriteLine("│    GAME OVER    │");
                        Console.WriteLine("│                 │");
                        Console.WriteLine("└─────────────────┘");
                        Console.ReadKey();

                        hoofdProgramma = (false);
                    }
                }
            }
        }
    }
}



