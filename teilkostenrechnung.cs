using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private const string InputErrorMessage = "Fehlerhafte Eingabe. Bitte geben Sie eine gültige Zahl ein.";
        private const string MengenbereichPrompt = "Geben Sie ihren gewünschten Mengenbereich ein (bei 0 wird ein Standardbereich generiert): ";

        static void Main(string[] args)
        {
            double fixKosten = PromptForDouble("Geben Sie ihre Fixkosten ein: ");
            double variableKosten = PromptForDouble("Geben Sie ihre Variablenkosten ein: ");
            double nettoErlos = PromptForDouble("Geben Sie ihren Nettoerlös pro Produkt ein: ");
            int mengenBereich = PromptForInt(MengenbereichPrompt);
            double[] schritte = GenerateSteps(mengenBereich);
            double gewinnZiel = PromptForDouble("Geben Sie ihr gewünschtes Gewinnziel ein: ");

            object[,] mixedArray = InitializeMixedArray(schritte, nettoErlos, variableKosten, fixKosten, mengenBereich);
            PrintTable(mixedArray);

            CalculateAndPrintThresholds(fixKosten, variableKosten, nettoErlos, gewinnZiel);
        }

        private static double PromptForDouble(string message)
        {
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out double value))
            {
                Console.WriteLine(InputErrorMessage);
                Console.Write(message);
            }
            return value;
        }

        private static int PromptForInt(string message)
        {
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine(InputErrorMessage);
                Console.Write(message);
            }
            return value;
        }

        private static double[] GenerateSteps(int mengenBereich)
        {
            if (mengenBereich == 0)
            {
                return new double[] { 0.67, 0.33, 1.0, 1.33, 1.67 }; // Example of default steps
            }
            else
            {
                double[] steps = new double[mengenBereich];
                for (int i = 0; i < mengenBereich; i++)
                {
                    Console.Write($"Geben Sie Schritt Nummer {i + 1} ein: ");
                    steps[i] = Convert.ToDouble(Console.ReadLine());
                }
                return steps;
            }
        }

        private static object[,] InitializeMixedArray(double[] schritte, double nettoErlos, double variableKosten, double fixKosten, int mengenBereich)
        {
            object[,] mixedArray = new object[6, mengenBereich + 1];
            mixedArray[0, 0] = "Anzahl";
            mixedArray[1, 0] = "Nettoerlös";
            mixedArray[2, 0] = "Variable Kosten";
            mixedArray[3, 0] = "Deckungsbeitrag";
            mixedArray[4, 0] = "Fixe Kosten";
            mixedArray[5, 0] = "Gewinn/Verlust";

            for (int i = 0; i < mengenBereich; i++)
            {
                mixedArray[0, i + 1] = schritte[i];
                mixedArray[1, i + 1] = nettoErlos * schritte[i];
                mixedArray[2, i + 1] = variableKosten * schritte[i];
                mixedArray[3, i + 1] = (nettoErlos - variableKosten) * schritte[i];
                mixedArray[4, i + 1] = fixKosten;
                mixedArray[5, i + 1] = (nettoErlos - variableKosten) * schritte[i] - fixKosten;
            }
            return mixedArray;
        }

        private static void PrintTable(object[,] mixedArray)
        {
            for (int row = 0; row < mixedArray.GetLength(0); row++)
            {
                for (int col = 0; col < mixedArray.GetLength(1); col++)
                {
                    Console.Write($"{mixedArray[row, col],15} |");
                }
                Console.WriteLine();
                PrintSeparator(mixedArray.GetLength(1));
            }
        }

        private static void PrintSeparator(int length)
        {
            Console.WriteLine(new string('-', length * 17));
        }

        private static void CalculateAndPrintThresholds(double fixKosten, double variableKosten, double nettoErlos, double gewinnZiel)
        {
            double deckungsBeitrag = nettoErlos - variableKosten;
            double mengenmässigeNutzschwelle = fixKosten / deckungsBeitrag;
            double wertmässigeNutzschwelle = mengenmässigeNutzschwelle * nettoErlos;
            double notwendigeMengeDefinierterGewinn = (gewinnZiel + fixKosten) / deckungsBeitrag;

            Console.WriteLine($"Mengenmässige Nutzschwelle: {Math.Round(mengenmässigeNutzschwelle)}");
            Console.WriteLine($"Wertmässige Nutzschwelle: {Math.Round(wertmässigeNutzschwelle)}");
            Console.WriteLine($"Notwendige Menge für definierten Gewinn: {Math.Round(notwendigeMengeDefinierterGewinn)}");
        }
    }
}
