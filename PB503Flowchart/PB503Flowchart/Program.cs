namespace PB503Flowchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homeworks
            // 1-dən 100'ə qədər 3ə və 5ə (mis: 15, 30, 45) qalıqsız bölünən ədədləri console`a yazdırırsınız

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0) // i % 15 == 0
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Bir variable`niz olur və ona ədəd(və ya rəqəm) mənimsədirsiniz.Əgər bu ədəd
            //65 - dən aşağıdırsa console`da `Kəsildin`,
            //65 - 85 arasındadırsa console`da `Adi Diplom`,
            //85 - 95 arasındadırsa console`da `Şərəf Diplomu`, (Honour)
            //95 + console`da `Yüksək Şərəf Diplomu`, (High Honour) yazılsın

            //int grade = 101;

            //if(grade >= 0 && grade < 65)
            //{
            //    Console.WriteLine("Kesildin");
            //}
            //else if(grade >= 65 && grade < 85)
            //{
            //    Console.WriteLine("Adi diplom");
            //}
            //else if (grade >= 85 && grade < 95)
            //{
            //    Console.WriteLine("Honor diplom");
            //}
            //else if(grade >= 95 && grade <= 100)
            //{
            //    Console.WriteLine("High honor diplom");
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir grade yoxdur");
            //}
            #endregion

            #region While loop


            // 1-dən 100'ə qədər 3ə və 5ə (mis: 15, 30, 45) qalıqsız bölünən ədədləri console`a yazdırırsınız

            //int i = 1;

            //while (i <= 100)
            //{
            //    if (i % 15 == 0)
            //    {
            //        Console.WriteLine($"{i} 3e ve 5e bolunendir");
            //    }

            //    i++;
            //}



            // 1-den 100e qeder 2e qaliqsiz bolunenleri console'a yazdirin

            //int i = 1;

            //while(i<=100)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} cut ededdir.");
            //    }

            //    i++;
            //}

            //for (int anar = 1; anar <= 100; anar++)
            //{
            //    if(anar % 2  == 0)
            //    {
            //        Console.WriteLine(anar);
            //    }
            //}

            //for (int j = 0; j < 1;)
            //{
            //    Console.WriteLine("Salam");
            //}

            //// sonsuz dongu
            //for(; ; )
            //{
            //    Console.WriteLine("Infinite loop");
            //}

            #endregion

            #region Switch case

            //int dayOfWeek = 10;

            //if(dayOfWeek == 1)
            //{
            //    Console.WriteLine("Monday");
            //}else if(dayOfWeek == 2)
            //{
            //    Console.WriteLine("Tuesday");
            //}else if(dayOfWeek == 3)
            //{
            //    Console.WriteLine("Wednesday");
            //}
            //else if (dayOfWeek == 5)
            //{
            //    Console.WriteLine("Friday");
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir gun yoxdur");
            //}

            //switch (dayOfWeek)
            //{
            //    case 1:
            //        Console.WriteLine("Mon");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tue");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wed");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thu");
            //        break;
            //    case 5:
            //        Console.WriteLine("Fri");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sat");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sun");
            //        break;
            //    default:
            //        Console.WriteLine($"There is no day like {dayOfWeek}");
            //        break;
            //}
            #endregion

            #region Classworks
            //Verilmis N ededinin!(factorial)'ni tapan algorithm yazin. 
            //(misal: 5! => 120, 6! => 720) 5! => 1 * 2 * 3 * 4 * 5

            //int inputNumber = 5;
            //int i = 1;
            //int factorial = 1;

            //while (i <= inputNumber)
            //{
            //    factorial *= i; // factorial = factorial * i;
            //    i++;
            //}

            //Console.WriteLine($"{inputNumber}! => {factorial}");


            //int inputNumber = 5;
            //int factorial = 1;

            //while (inputNumber > 0)
            //{
            //    factorial *= inputNumber;

            //    inputNumber--;
            //}

            //Console.WriteLine(factorial);

            #endregion

            #region Do-while
            string secretWord = "pb503";
            string inputWord = string.Empty; // ""
            bool check = true;
            int counter = 0;
            do
            {
                counter++;
                if(counter > 3)
                {
                    break;
                }
                if (check == true)
                {
                    Console.WriteLine("Enter secret word:");
                    inputWord = Console.ReadLine();
                    check = false;
                }
                else
                {
                    Console.WriteLine($"Incorrect, try again. Incorrect attempts: {counter}");
                    Console.WriteLine("Enter secret word:");
                    inputWord = Console.ReadLine();
                }
            } while (inputWord != secretWord);

            if(counter <= 3)
            {
                Console.WriteLine($"After {counter} attempts. Finally it is correct!");
            }
            else
            {
                Console.WriteLine("Lockout");
            }
            #endregion

            #region continue, break
            // 5,6
            //for (int i = 1; i <= 8; i++)
            //{
            //    if(i == 5 || i == 6)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //int inputNumber = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < 100; i++)
            //{
            //    if(inputNumber == i)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("\n" + i);
            //}
            #endregion
        }
    }
}
