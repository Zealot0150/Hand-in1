using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;


namespace Hand_in1
{    



    class Program
    {
        public static string userFirstName="Per", userLastName="Claeson";
        public static Random random = new Random();



        public static void RunExcercise1()
        {
            WriteLine($"Hello {userFirstName} {userLastName}! Jag är glad att informera dig att du är försökskaninen i min första övning");
        }

        public static void RunExercise2()
        {
            DateTime todaysDT = DateTime.Today;
            DateTime yesterdayDT = DateTime.Today.AddDays(-1);
            DateTime tomorrowDT = DateTime.Today.AddDays(1);
            WriteLine("Todays date is: " + todaysDT.ToString("yyyy-MM-dd"));
            WriteLine("Tomorows date is: " + tomorrowDT.ToString("yyyy-MM-dd"));
            WriteLine("Yesterdays date was: " + yesterdayDT.ToString("yyyy-MM-dd\n"));
        }
        public static void RunExercise3()
        {
            Write("Ange förnamn:");
            userFirstName = ReadLine();
            Write("Ange Efternamn:");
            userLastName = ReadLine();
            RunExcercise1();
        }
        public static void RunExercise4()
        {
            string str = "The quick fox Jumped Over the DOG";
            //"The brown fox jumped over the lazy dog";
            // bort med alla upper case
            str = str.ToLower();

            // ta bort första lilla t och lägg till ett nytt
            str = str.Substring(1,str.Length-1);
            str = "T" + str;
            
            // byt ut fras
            str = str.Replace("quick", "brown");
            
            // orkar inte räkna så kör en ful
            str = str.Replace(" dog", " lazy dog");
            
            WriteLine(str);
        }

        public static void RunExercise5()
        {
            string str = "Arrays are very common in programming, the look like something like:[1,2,3,4,5]";
            string newString = str.Substring(68, 11);
            newString = newString.Remove(3, 4);
            newString = newString.Insert(newString.Length - 1,",6,7,8,9,10");
            WriteLine(newString);
        }

        public static int ReadIntFromUser()
        {
            while (true)
            {
                WriteLine("Ange heltal:");
                try
                {
                    return Int32.Parse(ReadLine());
                }
                catch (Exception)
                {
                    WriteLine("Fel format");
                }            
            }
        }


        public static void RunExercise6()
        {
            int firstArgument = ReadIntFromUser();
            int secondArgument = ReadIntFromUser();

            WriteLine("Max:" + Math.Max(firstArgument,secondArgument));
            WriteLine("Min:" + Math.Min(firstArgument, secondArgument));
            WriteLine("Diff:" + Math.Abs(firstArgument-secondArgument));
            WriteLine("Sum:" + (firstArgument + secondArgument));
            WriteLine("Product:" + (firstArgument * secondArgument));
            WriteLine(secondArgument!=0? "Product:" + Math.Abs((firstArgument / secondArgument)):"Nämnare noll");
        }


        public static void RunExercise7()
        {
            bool userHasMadeInput = false;
            double userInputRadio = 0, calculatedRadio, calculatedVolume;
            do
            {
                WriteLine("Ange radien:");
                try
                {
                    userInputRadio = Double.Parse(ReadLine());
                    userHasMadeInput = true;
                }
                catch (Exception)
                {
                    WriteLine("Fel format");
                }
            }
            while (!userHasMadeInput);
            calculatedRadio = 2 * Math.PI * userInputRadio * userInputRadio;
            calculatedVolume = (4 * Math.PI * userInputRadio * userInputRadio * userInputRadio) /3;
            WriteLine("Arean är:" + calculatedRadio);
            WriteLine("Volyemn är:" + calculatedVolume);
        }

        public static void RunExercise8()
        {
            double userDoubleInput = 0;
            bool userHasMadeInput = false;
            do
            {
                WriteLine("Decimaltal:");
                try
                {
                    userDoubleInput = Double.Parse(ReadLine());
                    userHasMadeInput = true;
                }
                catch (Exception)
                {
                    WriteLine("Fel format");
                }
            }
            while (!userHasMadeInput);

            WriteLine("Roten ur:" + Math.Sqrt(userDoubleInput));
            WriteLine("Upphöjt till två:" + Math.Pow(userDoubleInput, 2));
            WriteLine("Upphöjt till tio:" + Math.Pow(userDoubleInput, 10));
        }

        public static void RunExercise9()
        {
            void ServeACoke()
            {
                WriteLine("Ok ingen ölkille, vill du ha en cola?");
                if (ReadLine() == "ja")
                {
                    WriteLine("Varsegod fjolla, här har du en cola");
                }
                else
                    WriteLine("Ok ha en fin kväll ");
            }
            string userName;

            WriteLine("Ange ditt namn:");
            userName = ReadLine();
            WriteLine("Hej " + userName + " Ange ditt födelseår:");
            int birthDate = ReadIntFromUser();
            if (DateTime.Now.AddYears(-birthDate).Year>= 18)
            {
                WriteLine("Vill du dricka bers? ja/nej");
                if (ReadLine() == "ja")
                {
                    WriteLine("Gött har har du en öl");
                }
                else
                {
                    ServeACoke();
                }

            }
            else 
            {
                ServeACoke();
            }

        }

        private static void Run10()
        {

            void FirstOption()
            {
                WriteLine("Division Ange första nummer");
                double firstArgument = Int32.Parse(ReadLine());
                WriteLine("Ange  andra nummer, får inte var noll");
                double secondArgument = Int32.Parse(ReadLine());
                if (secondArgument == 0)
                    throw new Exception();
                else
                    WriteLine("Svaret blir" + firstArgument / secondArgument);
            }
            try
            {
                WriteLine("Ange nummer 1-3");
                switch (Int32.Parse(ReadLine()))
                {
                    case 1:
                        FirstOption();
                        break;
                    case 2:
                        RunExercise4();
                        break;
                    case 3:
                        if (Console.ForegroundColor == ConsoleColor.Red)
                            Console.ResetColor();
                        else
                            Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

            }
            catch (Exception)
            {
                WriteLine("Felaktig inmating");
            }
        }


        private static void Run11()
        {
            int inputValue;
            WriteLine("Angel tal högre än 0");
            inputValue =Int32.Parse( ReadLine());
            if (inputValue < 1)
            {
                WriteLine("Ange värde högre än noll");
                Run11();
            }
            for (int i = 1; i < inputValue; i++)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                WriteLine(i);
            }

            for (int i = inputValue;  i> 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                WriteLine(i);
            }
            Console.ResetColor();
        }
        
        private static void Run12()
        {
            for (int i = 1; i < 11; i++)
            {
                
                for (int j = 1; j < 11; j++)
                {
                    Write(j*i + "\t");
                }
                WriteLine("");
            }

        }
        
        private static void Run13()
        {
            int nrToFind = random.Next() % 500;
            int inputNr;
            int tries = 0;
            while (true)
            {
                tries++;
                WriteLine("Gissa nummret");
                if ((inputNr = Int32.Parse(ReadLine())) == nrToFind)
                    break;
                else if (inputNr < nrToFind)
                    WriteLine("Du gissade för lågt");
                else
                    WriteLine("Du gissade för högt");
                WriteLine("Antal gissningar gjorda:" + tries);
            }
            WriteLine("Rätt gissat, det tog: " + inputNr + " försök");
        }

        private static void Run14()
        { 
            List <int> intArray = new List< int >();
            int userInput = 0;
            while (true)
            {
                WriteLine("Ange heltal, avsluta med -1");
                try
                {
                    userInput = Int32.Parse(ReadLine());
                    if (userInput == -1)
                        break;
                    else
                        intArray.Add(userInput);
                }
                catch (Exception)
                {
                    WriteLine("Felaktig inmating");
                }
            }
                 WriteLine("Summa " +   intArray.Sum());
                WriteLine("Medel " + intArray.Average());
        }

        private static void Run15()
        {
            int userInput = 0;
            WriteLine("Ange heltal");
            try
            {
                userInput = Int32.Parse(ReadLine());
            }
            catch (Exception)
            {
                WriteLine("Felaktig inmating");
            }
            for (int i = userInput-1;  i > 0 ; i--)
            {
                int modNumber = userInput % i;
                if (modNumber == 0)
                    WriteLine("Delbar med " + i);
            }
        }

        private static void Run16()
        {
            int userInput = 0;
            int firstNumber = 0, SecondNumber = 1;
            WriteLine("Ange heltal till fibenatchi");
            try
            {
                userInput = Int32.Parse(ReadLine());
            }
            catch (Exception)
            {
                WriteLine("Felaktig inmating");
                Run16();
            }
            if (userInput < 2)
            {
                Console.Write("Ange högre än 2");
            }
            else
            { 
                Console.Write(firstNumber + " " + SecondNumber + " ");
                int nextNumber = 0;
                for (int i = 2 ; i < userInput; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
        }

        private static void Run17()
        {
            WriteLine("Skriv text för palidromtest");
            string inputString = ReadLine();

            if (inputString.SequenceEqual(inputString.Reverse()))
                WriteLine(inputString + " är ett palidrom");
            else
                WriteLine(inputString + " är inte ett palidrom");
        }

        private static void Run18()
         {
            int[] intArray = new int[10];
            double []doubleArray = new double[10];
            for (int i = 0; i < intArray.Length-1; i++)
            {
                intArray[i] = random.Next()%100;
            }
            for (int i = 0; i < doubleArray.Length-1; i++)
            {
                doubleArray[i] =   1 / (double)intArray[i];
            }
            foreach (var item in intArray)
            {
                WriteLine(item);
            }

            foreach (var item in doubleArray)
            {
                WriteLine(item);
            }
        }

        private static void Run19()
        {
            int[] coinsArray = { 500, 200, 100, 50, 20, 10, 5, 1 };
            int changeToCustomer = 0;
            WriteLine("Ange växel");
            changeToCustomer = Int32.Parse(ReadLine());
            while (changeToCustomer > 0)
            {
                int count = 0;
                foreach (var item in coinsArray)
                {
                    count = changeToCustomer / (int)item;
                    WriteLine("Antal:" + item + "=" + count);
                    if (count > 0)
                    changeToCustomer %= (int)item;
                }
            }
        }

        private static void Run20()
        {
            int[] firstArray = new int[10];
            int[] secondArray = new int[10];
            int even = 0, odd = 9;
            for (int i = 0; i < firstArray.Length-1; i++)
            {
                firstArray[i] = random.Next() % 50;
            }

            for (int i = 0; i < secondArray.Length-1; i++)
            {
                if (firstArray[i] % 2 == 0)
                    secondArray[odd--] = firstArray[i];
                else
                    secondArray[even++] = firstArray[i];
            }
            foreach (var item in secondArray)
            {
                WriteLine(item);
            }
        }

        private static void Run21()
        {
            string inputString = "";
            List<int> intList = new List<int>();
            string[] st;
            WriteLine("Ange ett anntal heltal kommasseparerade");
            inputString = ReadLine();
            st = inputString.Split(',');
            foreach (var item in st)
            {
                intList.Add(Int32.Parse((item)));
            }
            WriteLine("Minimum: " + intList.Min());
            WriteLine("Maximum: " + intList.Max());
            WriteLine("Average: " + intList.Average());

        }

        private static void Run22()
        {
            List<string> curseList = new List<string>() { "balle", "veke" };
            
            
            string textToCheck = "";
            WriteLine("Ange text att kontrollera");
            textToCheck = ReadLine();
            foreach (var item in curseList)
            {
                if (textToCheck.ToLower().Contains((string)item.ToLower()))
                    Console.WriteLine("Svordom funnen " + item);
            }
        }


        private static void Run23()
        {
            bool CheckDuplicate(int[] intArray, int numberToCheck)
            {
                bool duplicateFound = false;
                for (int i = 0; i < intArray.Length-1; i++)
                {
                    if(intArray[i]== numberToCheck)
                    {
                        // if same number found return -1 to indicate duplicate
                        return true;
                    }
                }
                return duplicateFound;
            }

            int FindFirstFree(int [] list)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == -1)
                        return i;
                }
                return -1;
            }


            //List<int> intList = new List<int>();
            //int randomNumber;
            //while (true)
            //{
            //    randomNumber = random.Next() % 40;
            //    if (!intList.Contains(randomNumber))
            //        intList.Add(randomNumber);
            //    if (intList.Count == 7)
            //        break;
            //}
            //foreach (var item in intList)
            //{
            //    WriteLine(item);
            //}
            int[] intList = new int[7];
            int randomNumber = 0,position = 0;

            for (int i = 0; i < intList.Length; i++)
            {
                intList[i] = -1;
            }

            while (true)
            {
                randomNumber = random.Next() % 40;
                
                if (CheckDuplicate(intList, randomNumber))
                    continue;

                else
                {
                    position = FindFirstFree(intList);
                    intList[position] = randomNumber;
                }
                // list done?
                if (intList[intList.Length - 1] != -1)
                    break;
            }
            foreach (var item in intList)
            {
                WriteLine(item);
            }
        }

        private static void Run24()
        {
            int[] FillDeck()
            {
                int[] deck = new int[52];
                int card = 1;
                for (int i = 0; i < deck.Length; i+=4)
                {
                    deck[i] = card;
                    deck[i+1] = card;
                    deck[i+2] = card;
                    deck[i+3] = card;
                    card++;
                }
                return deck;
            }

            int DrawCard(ref int[] deck)
            {
                int cardDrawn = deck[deck.Length - 1];
                Array.Resize(ref deck, deck.Length - 2);
                return cardDrawn;

            }
            void ShuffleDeck(ref int[] deck)
            {
                int temp;
                int randomPlace1, randomPlace2;
                for (int i = 0; i < deck.Length; i++)
                {
                    randomPlace1 = random.Next() % deck.Length;
                    randomPlace2 = random.Next() % deck.Length;
                    temp = deck[randomPlace1];
                    deck[randomPlace1] = deck[randomPlace2];
                    deck[randomPlace2] = temp;
                }

            }
            void AddCard(int card, ref int [] deck)
            {
                Array.Resize(ref deck, deck.Length + 1);
                deck[deck.Length - 1] = card;
            }


            void printDeck(int [] deck)
            {
                foreach (var item in deck)
                {
                    WriteLine(item);
                }
                WriteLine("Totalt " + deck.Length + "kort");
            }
            int card;
            int []deck =  FillDeck();
            int[] newDeck = new int[0];
            ShuffleDeck(ref deck);
            WriteLine("Kortleken blandad och klar");
            printDeck(deck);
            card = DrawCard(ref deck);
            AddCard(card, ref newDeck);
            WriteLine("Den nya kortleken");
            printDeck(newDeck);

        }

        static void Run25()
        {
            int ReadIntFromConsole()
            {
                int input = 0;
                try
                {
                    WriteLine("Ange heltal");
                    input = Int32.Parse(
                        ReadLine());
                    return input;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message + "Inget argument");
                    return ReadIntFromConsole();
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + " Fel format");
                    return ReadIntFromConsole();
                }

            }
            int argument1 = ReadIntFromConsole();
            int argument2 = ReadIntFromConsole();
            double result;
            try
            {
                result = argument1 / argument2;
                WriteLine(argument1 + "/" + argument2 + " = " +result);                
            }
            catch (DivideByZeroException)
            {
                WriteLine("Miffo du kan inte dela på 0");
            }
        }

        static void Run26()
        {
            Write("My documents: ");
            WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            Write("My pictures: ");
            WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));

            Write("My programfiles: ");
            WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));

            Write("My folder contatining information about cookies");
            WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));

            Write("Current folder");
            WriteLine(Environment.CurrentDirectory);
            try
            {
                WriteLine("Försöker skapa ny fil på: " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\file.txt");
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\file.txt");
                fs.Close();
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
        }

        static void Run27()
        {
            StreamReader sr = new StreamReader("TextFile.txt");
            string st = sr.ReadToEnd();
            WriteLine(st);
        }
        static void Run28()
        {
            string[] st1 = { "Per", "Olof", "Carl", "Henrik", "Sebastian" };
            string[] st2 = { "Perra", "Olli", "kalle", "Henke", "basten" };
            StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\file.txt");
            foreach (var item in st1)
            {
                sw.WriteLine(item);
            }
            sw.Close();


            sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\file.txt", true);
            foreach (var item in st2)
            {
                sw.WriteLine(item);
            }
            sw.Close();

            StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\file.txt");
            WriteLine(sr.ReadToEnd());
            sr.Close();

        }


        static void Main(string[] args)
        {
            const string WelcomeText = "Ange vilken uppgift du vill köra, avsluta med -1";
            const string ErrorMessage = "Felaktiktigt val. Ange siffra mellan  ";
        
            bool keepRunning = true;
            int userInputExercice = 0;

                while (keepRunning)
                {
                    Console.WriteLine(WelcomeText);
                    try
                    {
                        if( (userInputExercice = Int32.Parse(Console.ReadLine()))== -1)
                            Environment.Exit(0);

                        switch (userInputExercice)
                        {
                            case 1:
                                RunExcercise1();
                                break;
                            case 2:
                                RunExercise2();
                                break;
                            case 3:
                                RunExercise3();
                                break;
                            case 4:
                                RunExercise4();
                                break;
                            case 5:
                                RunExercise5();
                                break;
                            case 6:
                                RunExercise6();
                                break;
                            case 7:
                                RunExercise7();
                                break;
                            case 8:
                                RunExercise8();
                                break;
                            case 9:
                                RunExercise9();
                                break;
                            case 10:
                                Run10();
                                break;
                            case 11:
                                Run11();
                                break;
                            case 12:
                                Run12();
                                break;
                            case 13:
                                Run13();
                                break;
                            case 14:
                                Run14();
                                break;
                            case 15:
                                Run15();
                                break;
                            case 16:
                                Run16();
                                break;
                            case 17:
                                Run17();
                                break;
                            case 18:
                                Run18();
                                break;
                            case 19:
                                Run19();
                                break;
                            case 20:
                                Run20();
                                break;
                            case 21:
                                Run21();
                                break;
                            case 22:
                                Run22();
                                break;
                            case 23:
                                Run23();
                                break;
                            case 24:
                                Run24();
                                break;
                            case 25:
                                Run25();
                                break;
                            case 26:
                                Run26();
                                break;
                            case 27:
                                Run27();
                                break;
                            case 28:
                                Run28();
                                break;
                        default:
                            WriteLine(ErrorMessage);
                            break;
                    }
                }
                    catch (Exception)
                    {
                        Console.WriteLine(ErrorMessage);
                    }
                }
            }
    }
    }

