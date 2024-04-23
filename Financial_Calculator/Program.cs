using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FinCalculator
{
    internal class Program
    {
        private static void Func1()
        {

        }
        static void Main(string[] args)
        {
            int mode = 1;
            int var = 1;
            int settings = 0;
            int stmenu = 1;

            start:

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            printString(10, 4, "Расчет кредита/ипотеки:");
            printString(10, 9, "Расчет вклада:");
            printString(10, 15, "Календари:");
            printString(10, 20, "Разное:");
            printString(49, 4, "Настройки:");
            printStrings(83, 4, "Эта программа создана для\nразличных вычислений связан-\nных с кредитами и вкладами.\n\nПрограмма постоянно дополня-\nется и улучшается, стремясь\nк тому, чтобы стать универс-\nальным калькулятором для\nвсего что связанно с банков-\nской сферой.\n\nДля управления меню использ-\nуйте стрелочки или WASD, при\nвыборе пункта в меню нажмите\nENTER, чтобы перейти в тот\nили иной калькулятор.\n\nРазработчик программы -\nЕгор Коновалов. Вы можете\nпомочь мне с разработкой с\nпомощью обратной связи на\nмоем GitHub (shead0shead).");
            Console.ResetColor();

            printStrings(10, 6, "1 - Дифференцированный платеж\n2 - Аннуитетный платеж");
            printStrings(10, 11, "3 - Простой процент\n4 - Сложный процент\n5 - Накопительный счет");
            printStrings(10, 17, "6 - Произв. календарь 2023\n7 - Произв. календарь 2024");
            printStrings(10, 22, "8 - Регион по номеру\n9 - Сколько стоит время\n10 - Сколько осталось до даты");
            printStrings(49, 6, "1. Режим управления меню\n2. ...\n3. ...");

            if (var == 1)
            {
                Console.CursorVisible = false;

                if (settings == 1)
                {
                    if (stmenu == 1) printString(47, 6, ">");
                    else if (stmenu == 2) printString(47, 7, ">");
                    else if (stmenu == 3) printString(47, 8, ">");

                    ConsoleKey key2 = Console.ReadKey().Key;
                    if (key2 == ConsoleKey.UpArrow || key2 == ConsoleKey.W)
                    {
                        if (stmenu == 1) stmenu = 3;
                        else stmenu--;
                        goto start;
                    }
                    else if (key2 == ConsoleKey.DownArrow || key2 == ConsoleKey.S)
                    {
                        if (stmenu == 3) stmenu = 1;
                        else stmenu++;
                        goto start;
                    }
                    else if (key2 == ConsoleKey.LeftArrow || key2 == ConsoleKey.A)
                    {
                        settings = 0;
                        stmenu = 1;
                        goto start;
                    }
                    else if (key2 == ConsoleKey.Enter || key2 == ConsoleKey.E) { }
                    else if (key2 == ConsoleKey.Escape) Environment.Exit(0);
                    else goto start;

                    if (stmenu == 1)
                    {

                    }
                }

                if (mode == 1) printString(8, 6, ">");
                else if (mode == 2) printString(8, 7, ">");
                else if (mode == 3) printString(8, 11, ">");
                else if (mode == 4) printString(8, 12, ">");
                else if (mode == 5) printString(8, 13, ">");
                else if (mode == 6) printString(8, 17, ">");
                else if (mode == 7) printString(8, 18, ">");
                else if (mode == 8) printString(8, 22, ">");
                else if (mode == 9) printString(8, 23, ">");
                else if (mode == 10) printString(8, 24, ">");

                ConsoleKey key1 = Console.ReadKey().Key;
                if (key1 == ConsoleKey.UpArrow || key1 == ConsoleKey.W)
                {
                    if (mode == 1) mode = 10;
                    else mode--;
                    goto start;
                }
                else if (key1 == ConsoleKey.DownArrow || key1 == ConsoleKey.S)
                {
                    if (mode == 10) mode = 1;
                    else mode++;
                    goto start;
                }
                else if (key1 == ConsoleKey.RightArrow || key1 == ConsoleKey.D)
                {
                    settings = 1;
                    mode = 1;
                    goto start;
                }
                else if (key1 == ConsoleKey.M)
                {
                    var++;
                    goto start;
                }
                else if (key1 == ConsoleKey.Enter || key1 == ConsoleKey.E) { }
                else if (key1 == ConsoleKey.Escape) Environment.Exit(0);
                else goto start;
            }
            else if (var == 2)
            {
                Console.CursorVisible = false;

                modemenu:

                ConsoleKey key1 = Console.ReadKey().Key;
                if (key1 == ConsoleKey.D1) mode = 1;
                else if (key1 == ConsoleKey.D2) mode = 2;
                else if (key1 == ConsoleKey.D3) mode = 3;
                else if (key1 == ConsoleKey.D4) mode = 4;
                else if (key1 == ConsoleKey.D5) mode = 5;
                else if (key1 == ConsoleKey.M)
                {
                    var--;
                    goto start;
                }
                else if (key1 == ConsoleKey.Escape) Environment.Exit(0);
                else goto modemenu;
            }

            if (mode == 1)
            {
                int Page = 1;
                int More = 0;
                int morePage = 1;

                restart:

                Console.Clear();

                // Вывод текста интерфейса
                Console.ForegroundColor = ConsoleColor.DarkGray;
                printString(10, 2, "Сумма долга:");
                printString(26, 2, "Ставка по кредиту:");
                printString(48, 2, "Период заема:");
                printString(82, 2, "Итоговая сумма:");
                printString(102, 2, "Переплата:");
                Console.ResetColor();

                printString(10, 3, "...");
                printString(26, 3, "...% годовых");
                printString(48, 3, "... месяцев");

                printString(10, 27, "1 - Вернуться назад");

                Console.CursorVisible = true;

                // Ввод данных и их вывод после этого
                Console.SetCursorPosition(10, 3);
                double Sum = double.Parse(Console.ReadLine());

                printString(10, 3, "       ");
                printString(10, 3, $"{Sum} руб");

                Console.SetCursorPosition(26, 3);
                double Bet = double.Parse(Console.ReadLine());

                printString(26, 3, "            ");
                printString(26, 3, $"{Bet}% годовых");

                Console.SetCursorPosition(48, 3);
                int Dur = int.Parse(Console.ReadLine());

                printString(48, 3, "           ");
                printString(48, 3, $"{Dur} месяцев");

                Console.CursorVisible = false;

                // Анимация загрузки
                loadanim();

                // Переменные итоговой суммы
                double resultSum = 0;
                double resultBet = 0;

                // Массивы подробного списка
                double[] B1 = new double[Dur];
                double[] B2 = new double[Dur];
                double[] B3 = new double[Dur];
                double[] B4 = new double[Dur];
                double[] B5 = new double[Dur];

                // Обработка месячных платежей
                double[] A = new double[Dur];
                double moSum = Sum / Dur; // 11,308
                double moOst = Sum; // 135,700
                for (int i = 0; i < A.Length; i++)
                {
                    double moBet = ((Bet / 100) / 12) * moOst; // 1,243
                    double moPay = moSum + moBet;

                    B1[i] = moOst;
                    B2[i] = moBet;
                    B3[i] = moSum;
                    B4[i] = moPay;

                    moOst = moOst - moSum;
                    A[i] = moPay;

                    B5[i] = moOst;

                    resultSum = resultSum + A[i];
                    resultBet = resultBet + moBet;
                }

                // Вывод итоговой суммы и переплаты
                printString(82, 3, $"{Math.Round(resultSum, 2)} руб");
                printString(102, 3, $"{Math.Round(resultBet, 2)} руб");

                pages:

                // Вывод страниц
                if (Page == 1)
                {
                    printOne(10, 7, 17, "                                                                                                    ");

                    int wight = 10;
                    int height = 7;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if ((i + 1) <= 6)
                        {
                            height = i * 3 + 7;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 6 && (i + 1) <= 12)
                        {
                            height = (i - 6) * 3 + 7;
                            wight = 28;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 12 && (i + 1) <= 18)
                        {
                            height = (i - 12) * 3 + 7;
                            wight = 46;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 18 && (i + 1) <= 24)
                        {
                            height = (i - 18) * 3 + 7;
                            wight = 62;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 24 && (i + 1) <= 30)
                        {
                            height = (i - 24) * 3 + 7;
                            wight = 80;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 30 && (i + 1) <= 36)
                        {
                            height = (i - 30) * 3 + 7;
                            wight = 98;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if (A.Length > 36) printString(106, 27, "Стр. 1");
                    }
                }
                else if (Page == 2)
                {
                    printOne(10, 7, 17, "                                                                                                    ");

                    int wight = 10;
                    int height = 7;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if ((i + 1) > 36 && (i + 1) <= 42)
                        {
                            height = (i - 36) * 3 + 7;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 42 && (i + 1) <= 48)
                        {
                            height = (i - 42) * 3 + 7;
                            wight = 28;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 48 && (i + 1) <= 54)
                        {
                            height = (i - 48) * 3 + 7;
                            wight = 46;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 54 && (i + 1) <= 60)
                        {
                            height = (i - 54) * 3 + 7;
                            wight = 62;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 60 && (i + 1) <= 66)
                        {
                            height = (i - 60) * 3 + 7;
                            wight = 80;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 66 && (i + 1) <= 72)
                        {
                            height = (i - 66) * 3 + 7;
                            wight = 98;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        printString(106, 27, "Стр. 2");
                    }
                }

                if (A.Length > 36) printString(31, 27, "< > - Выбор страницы");

                moreinfo:

                // Подробная информация
                if (More == 1)
                {
                    printOne(10, 7, 18, "                                                                                                         ");

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    printString(10, 5, "Месяц");
                    printString(22, 5, "Сумма в начале");
                    printString(43, 5, "Процент");
                    printString(59, 5, "Оплата кредита");
                    printString(80, 5, "Итого платеж");
                    printString(99, 5, "Сумма в конце");
                    Console.ResetColor();

                    if (B1.Length <= 10) printString(106, 27, "      ");
                    else printString(106, 27, "Стр. 1");

                    if (B1.Length <= 10) printString(31, 27, "                    ");
                    else printString(31, 27, "Вверх вниз - Выбор страницы");

                    if (morePage == 1)
                    {
                        int lcount = 0;
                        for (int i = 0; i < B1.Length; i++) if (i + 1 <= 10) lcount++;

                        int lheight = 7;
                        for (int i = 0; i < lcount; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            printString(10, lheight, "                                                                                                      ");
                            Console.ResetColor();
                            lheight = lheight + 2;
                        }

                        int height = 7;
                        for (int i = 0; i < B1.Length; i++)
                        {
                            if (i + 1 <= 10)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.White;
                                printString(10, height, $"{i + 1} месяц");
                                printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                                printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                                printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                                printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                                printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                                height = height + 2;
                                Console.ResetColor();
                            }
                        }
                        if (B1.Length > 10) printString(106, 27, "Стр. 1");
                    }
                    else if (morePage == 2)
                    {
                        int lcount = 0;
                        for (int i = 0; i < B1.Length; i++) if (i + 1 > 10 && i + 1 <= 20) lcount++;

                        int lheight = 7;
                        for (int i = 0; i < lcount; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            printString(10, lheight, "                                                                                                      ");
                            Console.ResetColor();
                            lheight = lheight + 2;
                        }

                        int height = 7;
                        for (int i = 0; i < B1.Length; i++)
                        {
                            if (i + 1 > 10 && i + 1 <= 20)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.White;
                                printString(10, height, $"{i + 1} месяц");
                                printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                                printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                                printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                                printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                                printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                                height = height + 2;
                                Console.ResetColor();
                            }
                        }
                        printString(106, 27, "Стр. 2");
                    }
                    else if (morePage == 3)
                    {
                        int lcount = 0;
                        for (int i = 0; i < B1.Length; i++) if (i + 1 > 20 && i + 1 <= 30) lcount++;

                        int lheight = 7;
                        for (int i = 0; i < lcount; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            printString(10, lheight, "                                                                                                      ");
                            Console.ResetColor();
                            lheight = lheight + 2;
                        }

                        int height = 7;
                        for (int i = 0; i < B1.Length; i++)
                        {
                            if (i + 1 > 20 && i + 1 <= 30)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.White;
                                printString(10, height, $"{i + 1} месяц");
                                printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                                printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                                printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                                printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                                printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                                height = height + 2;
                                Console.ResetColor();
                            }
                        }
                        printString(106, 27, "Стр. 3");
                    }
                    else if (morePage == 4)
                    {
                        int lcount = 0;
                        for (int i = 0; i < B1.Length; i++) if (i + 1 > 30 && i + 1 <= 40) lcount++;

                        int lheight = 7;
                        for (int i = 0; i < lcount; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            printString(10, lheight, "                                                                                                      ");
                            Console.ResetColor();
                            lheight = lheight + 2;
                        }

                        int height = 7;
                        for (int i = 0; i < B1.Length; i++)
                        {
                            if (i + 1 > 30 && i + 1 <= 40)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.White;
                                printString(10, height, $"{i + 1} месяц");
                                printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                                printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                                printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                                printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                                printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                                height = height + 2;
                                Console.ResetColor();
                            }
                        }
                        printString(106, 27, "Стр. 4");
                    }

                    Console.SetCursorPosition(10, 7);

                    // Обработка клавиш управления страницами
                    if (B1.Length > 10 && B1.Length <= 20)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.D1)
                        {
                            printOne(10, 5, 20, "                                                                                                         ");
                            printString(31, 27, "                           ");
                            printString(106, 27, "      ");
                            More = 0;
                            goto pages;
                        }
                        else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                        {
                            if (morePage == 1) morePage = 2;
                            else if (morePage > 1) morePage--;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                        {
                            if (morePage == 2) morePage = 1;
                            else if (morePage < 2) morePage++;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.Escape) Environment.Exit(0);
                        else goto moreinfo;
                    }
                    else if (B1.Length > 20 && B1.Length <= 30)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.D1)
                        {
                            printOne(10, 5, 20, "                                                                                                         ");
                            printString(31, 27, "                           ");
                            printString(106, 27, "      ");
                            More = 0;
                            goto pages;
                        }
                        else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                        {
                            if (morePage == 1) morePage = 3;
                            else if (morePage > 1) morePage--;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                        {
                            if (morePage == 3) morePage = 1;
                            else if (morePage < 3) morePage++;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.Escape) Environment.Exit(0);
                        else goto moreinfo;
                    }
                    else if (B1.Length > 30 && B1.Length <= 40)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.D1)
                        {
                            printOne(10, 5, 20, "                                                                                                         ");
                            printString(31, 27, "                           ");
                            printString(106, 27, "      ");
                            More = 0;
                            goto pages;
                        }
                        else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                        {
                            if (morePage == 1) morePage = 4;
                            else if (morePage > 1) morePage--;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                        {
                            if (morePage == 4) morePage = 1;
                            else if (morePage < 4) morePage++;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.Escape) Environment.Exit(0);
                        else goto moreinfo;
                    }
                    else
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.D1)
                        {
                            printOne(10, 5, 20, "                                                                                                         ");
                            printString(31, 27, "                           ");
                            printString(106, 27, "      ");
                            More = 0;
                            goto pages;
                        }
                        else if (key == ConsoleKey.Escape) Environment.Exit(0);
                        else goto moreinfo;
                    }
                }

                Console.SetCursorPosition(10, 7);

                // Обработка клавиш управления меню
                if (A.Length > 36)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.D2)
                    {
                        Page = 1;
                        goto restart;
                    }
                    else if (key == ConsoleKey.D3)
                    {
                        More = 1;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.LeftArrow)
                    {
                        if (Page == 1) Page = 2;
                        else Page = 1;
                        goto pages;
                    }
                    else if (key == ConsoleKey.RightArrow)
                    {
                        if (Page == 1) Page = 2;
                        else Page = 1;
                        goto pages;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto pages;
                }
                else
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.D2) goto restart;
                    else if (key == ConsoleKey.D3)
                    {
                        More = 1;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto pages;
                }
            }
            else if (mode == 2)
            {
                int morePage = 1;

                Console.Clear();

                // Вывод текста интерфейса
                Console.ForegroundColor = ConsoleColor.DarkGray;
                printString(10, 2, "Сумма долга:");
                printString(26, 2, "Ставка по кредиту:");
                printString(48, 2, "Период заема:");
                printString(82, 2, "Итоговая сумма:");
                printString(102, 2, "Переплата:");
                Console.ResetColor();

                printString(10, 3, "...");
                printString(26, 3, "...% годовых");
                printString(48, 3, "... месяцев");

                printString(10, 27, "1 - Вернуться назад");

                Console.CursorVisible = true;

                // Ввод данных и их вывод после этого
                Console.SetCursorPosition(10, 3);
                double Sum = double.Parse(Console.ReadLine());

                printString(10, 3, "       ");
                printString(10, 3, $"{Sum} руб");

                Console.SetCursorPosition(26, 3);
                double Bet = double.Parse(Console.ReadLine());

                printString(26, 3, "            ");
                printString(26, 3, $"{Bet}% годовых");

                Console.SetCursorPosition(48, 3);
                int Dur = int.Parse(Console.ReadLine());

                printString(48, 3, "           ");
                printString(48, 3, $"{Dur} месяцев");

                Console.CursorVisible = false;

                // Анимация загрузки
                loadanim();

                // Переменные итоговой суммы
                double resultSum = 0;
                double resultBet = 0;

                // Массивы подробного списка
                double[,] B = new double[6, Dur];

                // Обработка месячных платежей
                double[] A = new double[Dur];
                double moSum = Sum / Dur;
                double moOst = Sum;
                for (int i = 0; i < A.Length; i++)
                {
                    double moBet = ((Bet / 100) / 12);
                    double moPay = Sum * (moBet + (moBet / (Math.Pow(1 + moBet, Dur) - 1)));

                    double moBet2 = moOst * moBet;
                    double moPay2 = moPay - moBet2;

                    B[1, i] = moOst;
                    B[2, i] = moBet2;
                    B[3, i] = moPay2;
                    B[4, i] = moPay;

                    moOst = moOst - moPay2;

                    B[5, i] = moOst;

                    resultSum = resultSum + moPay;
                    resultBet = resultBet + moBet2;
                }

                // Вывод итоговой суммы и переплаты
                printString(82, 3, $"{Math.Round(resultSum, 2)} руб");
                printString(102, 3, $"{Math.Round(resultBet, 2)} руб");

                moreinfo:

                // Подробная информация
                printOne(10, 7, 18, "                                                                                                         ");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                printString(10, 5, "Месяц");
                printString(22, 5, "Сумма в начале");
                printString(43, 5, "Процент");
                printString(59, 5, "Оплата кредита");
                printString(80, 5, "Итого платеж");
                printString(99, 5, "Сумма в конце");
                Console.ResetColor();

                if (Dur <= 10) printString(106, 27, "      ");
                else printString(106, 27, "Стр. 1");

                if (Dur <= 10) printString(31, 27, "                    ");
                else printString(31, 27, "Вверх вниз - Выбор страницы");

                if (morePage == 1)
                {
                    int lcount = 0;
                    for (int i = 0; i < Dur; i++) if (i + 1 <= 10) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < Dur; i++)
                    {
                        if (i + 1 <= 10)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B[1, i], 2)} руб");
                            printString(43, height, $"{Math.Round(B[2, i], 2)} руб");
                            printString(59, height, $"{Math.Round(B[3, i], 2)} руб");
                            printString(80, height, $"{Math.Round(B[4, i], 2)} руб");
                            printString(99, height, $"{Math.Round(B[5, i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    if (Dur > 10) printString(106, 27, "Стр. 1");
                }
                else if (morePage == 2)
                {
                    int lcount = 0;
                    for (int i = 0; i < Dur; i++) if (i + 1 > 10 && i + 1 <= 20) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < Dur; i++)
                    {
                        if (i + 1 > 10 && i + 1 <= 20)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B[1, i], 2)} руб");
                            printString(43, height, $"{Math.Round(B[2, i], 2)} руб");
                            printString(59, height, $"{Math.Round(B[3, i], 2)} руб");
                            printString(80, height, $"{Math.Round(B[4, i], 2)} руб");
                            printString(99, height, $"{Math.Round(B[5, i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    printString(106, 27, "Стр. 2");
                }
                else if (morePage == 3)
                {
                    int lcount = 0;
                    for (int i = 0; i < Dur; i++) if (i + 1 > 20 && i + 1 <= 30) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < Dur; i++)
                    {
                        if (i + 1 > 20 && i + 1 <= 30)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B[1, i], 2)} руб");
                            printString(43, height, $"{Math.Round(B[2, i], 2)} руб");
                            printString(59, height, $"{Math.Round(B[3, i], 2)} руб");
                            printString(80, height, $"{Math.Round(B[4, i], 2)} руб");
                            printString(99, height, $"{Math.Round(B[5, i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    printString(106, 27, "Стр. 3");
                }
                else if (morePage == 4)
                {
                    int lcount = 0;
                    for (int i = 0; i < Dur; i++) if (i + 1 > 30 && i + 1 <= 40) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < Dur; i++)
                    {
                        if (i + 1 > 30 && i + 1 <= 40)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B[1, i], 2)} руб");
                            printString(43, height, $"{Math.Round(B[2, i], 2)} руб");
                            printString(59, height, $"{Math.Round(B[3, i], 2)} руб");
                            printString(80, height, $"{Math.Round(B[4, i], 2)} руб");
                            printString(99, height, $"{Math.Round(B[5, i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    printString(106, 27, "Стр. 4");
                }
                else if (morePage == 5)
                {
                    int lcount = 0;
                    for (int i = 0; i < Dur; i++) if (i + 1 > 40 && i + 1 <= 50) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < Dur; i++)
                    {
                        if (i + 1 > 40 && i + 1 <= 50)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B[1, i], 2)} руб");
                            printString(43, height, $"{Math.Round(B[2, i], 2)} руб");
                            printString(59, height, $"{Math.Round(B[3, i], 2)} руб");
                            printString(80, height, $"{Math.Round(B[4, i], 2)} руб");
                            printString(99, height, $"{Math.Round(B[5, i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    printString(106, 27, "Стр. 5");
                }
                else if (morePage == 6)
                {
                    int lcount = 0;
                    for (int i = 0; i < Dur; i++) if (i + 1 > 50 && i + 1 <= 60) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < Dur; i++)
                    {
                        if (i + 1 > 50 && i + 1 <= 60)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B[1, i], 2)} руб");
                            printString(43, height, $"{Math.Round(B[2, i], 2)} руб");
                            printString(59, height, $"{Math.Round(B[3, i], 2)} руб");
                            printString(80, height, $"{Math.Round(B[4, i], 2)} руб");
                            printString(99, height, $"{Math.Round(B[5, i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    printString(106, 27, "Стр. 6");
                }

                Console.SetCursorPosition(10, 7);

                Console.SetCursorPosition(10, 7);

                // Обработка клавиш управления меню
                if (Dur > 10 && Dur <= 20)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                    {
                        if (morePage == 1) morePage = 2;
                        else if (morePage > 1) morePage--;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                    {
                        if (morePage == 2) morePage = 1;
                        else if (morePage < 2) morePage++;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto moreinfo;
                }
                else if (Dur > 20 && Dur <= 30)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                    {
                        if (morePage == 1) morePage = 3;
                        else if (morePage > 1) morePage--;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                    {
                        if (morePage == 3) morePage = 1;
                        else if (morePage < 3) morePage++;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto moreinfo;
                }
                else if (Dur > 30 && Dur <= 40)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                    {
                        if (morePage == 1) morePage = 4;
                        else if (morePage > 1) morePage--;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                    {
                        if (morePage == 4) morePage = 1;
                        else if (morePage < 4) morePage++;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto moreinfo;
                }
                else
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto moreinfo;
                }
            }
            else if (mode == 3)
            {
                int morePage = 1;

                Console.Clear();

                // Вывод текста интерфейса
                Console.ForegroundColor = ConsoleColor.DarkGray;
                printString(10, 2, "Сумма долга:");
                printString(26, 2, "Ставка по кредиту:");
                printString(48, 2, "Период заема:");
                printString(82, 2, "Итоговая сумма:");
                printString(102, 2, "Переплата:");
                Console.ResetColor();

                printString(10, 3, "...");
                printString(26, 3, "...% годовых");
                printString(48, 3, "... месяцев");

                printString(10, 27, "1 - Вернуться назад");

                Console.CursorVisible = true;

                // Ввод данных и их вывод после этого
                Console.SetCursorPosition(10, 3);
                double Sum = double.Parse(Console.ReadLine());

                printString(10, 3, "       ");
                printString(10, 3, $"{Sum} руб");

                Console.SetCursorPosition(26, 3);
                double Bet = double.Parse(Console.ReadLine());

                printString(26, 3, "            ");
                printString(26, 3, $"{Bet}% годовых");

                Console.SetCursorPosition(48, 3);
                int Dur = int.Parse(Console.ReadLine());

                printString(48, 3, "           ");
                printString(48, 3, $"{Dur} месяцев");

                Console.CursorVisible = false;

                // Анимация загрузки
                loadanim();

                // Переменные итоговой суммы
                double resultSum = 0;
                double resultBet = 0;

                // Массивы подробного списка
                double[] B1 = new double[Dur];
                double[] B2 = new double[Dur];
                double[] B3 = new double[Dur];
                double[] B4 = new double[Dur];
                double[] B5 = new double[Dur];

                // Обработка месячных платежей
                double[] A = new double[Dur];
                double moSum = Sum / Dur; // 11,308
                double moOst = Sum; // 135,700
                for (int i = 0; i < A.Length; i++)
                {
                    double moBet = ((Bet / 100) / 12); // 1,243
                    double moPay = Sum * (moBet + (moBet / (Math.Pow(1 + moBet, Dur) - 1)));

                    double moBet2 = moOst * moBet;
                    double moPay2 = moPay - moBet2;

                    B1[i] = moOst;
                    B2[i] = moBet2;
                    B3[i] = moPay2;
                    B4[i] = moPay;

                    moOst = moOst - moPay2;

                    B5[i] = moOst;

                    resultSum = resultSum + moPay;
                    resultBet = resultBet + moBet2;
                }

                // Вывод итоговой суммы и переплаты
                printString(82, 3, $"{Math.Round(resultSum, 2)} руб");
                printString(102, 3, $"{Math.Round(resultBet, 2)} руб");

                moreinfo:

                // Подробная информация
                printOne(10, 7, 18, "                                                                                                         ");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                printString(10, 5, "Месяц");
                printString(22, 5, "Сумма в начале");
                printString(43, 5, "Процент");
                printString(59, 5, "Оплата кредита");
                printString(80, 5, "Итого платеж");
                printString(99, 5, "Сумма в конце");
                Console.ResetColor();

                if (B1.Length <= 10) printString(106, 27, "      ");
                else printString(106, 27, "Стр. 1");

                if (B1.Length <= 10) printString(31, 27, "                    ");
                else printString(31, 27, "Вверх вниз - Выбор страницы");

                if (morePage == 1)
                {
                    int lcount = 0;
                    for (int i = 0; i < B1.Length; i++) if (i + 1 <= 10) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < B1.Length; i++)
                    {
                        if (i + 1 <= 10)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                            printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                            printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                            printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                            printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    if (B1.Length > 10) printString(106, 27, "Стр. 1");
                }
                else if (morePage == 2)
                {
                    int lcount = 0;
                    for (int i = 0; i < B1.Length; i++) if (i + 1 > 10 && i + 1 <= 20) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < B1.Length; i++)
                    {
                        if (i + 1 > 10 && i + 1 <= 20)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                            printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                            printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                            printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                            printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    printString(106, 27, "Стр. 2");
                }
                else if (morePage == 3)
                {
                    int lcount = 0;
                    for (int i = 0; i < B1.Length; i++) if (i + 1 > 20 && i + 1 <= 30) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < B1.Length; i++)
                    {
                        if (i + 1 > 20 && i + 1 <= 30)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                            printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                            printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                            printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                            printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    printString(106, 27, "Стр. 3");
                }
                else if (morePage == 4)
                {
                    int lcount = 0;
                    for (int i = 0; i < B1.Length; i++) if (i + 1 > 30 && i + 1 <= 40) lcount++;

                    int lheight = 7;
                    for (int i = 0; i < lcount; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        printString(10, lheight, "                                                                                                      ");
                        Console.ResetColor();
                        lheight = lheight + 2;
                    }

                    int height = 7;
                    for (int i = 0; i < B1.Length; i++)
                    {
                        if (i + 1 > 30 && i + 1 <= 40)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            printString(10, height, $"{i + 1} месяц");
                            printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                            printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                            printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                            printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                            printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                            height = height + 2;
                            Console.ResetColor();
                        }
                    }
                    printString(106, 27, "Стр. 4");
                }

                Console.SetCursorPosition(10, 7);

                Console.SetCursorPosition(10, 7);

                // Обработка клавиш управления меню
                if (B1.Length > 10 && B1.Length <= 20)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                    {
                        if (morePage == 1) morePage = 2;
                        else if (morePage > 1) morePage--;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                    {
                        if (morePage == 2) morePage = 1;
                        else if (morePage < 2) morePage++;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto moreinfo;
                }
                else if (B1.Length > 20 && B1.Length <= 30)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                    {
                        if (morePage == 1) morePage = 3;
                        else if (morePage > 1) morePage--;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                    {
                        if (morePage == 3) morePage = 1;
                        else if (morePage < 3) morePage++;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto moreinfo;
                }
                else if (B1.Length > 30 && B1.Length <= 40)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                    {
                        if (morePage == 1) morePage = 4;
                        else if (morePage > 1) morePage--;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                    {
                        if (morePage == 4) morePage = 1;
                        else if (morePage < 4) morePage++;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto moreinfo;
                }
                else
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto moreinfo;
                }
            }
            else if (mode == 4)
            {
                int Page = 1;
                int More = 0;
                int morePage = 1;

                restart:

                Console.Clear();

                // Вывод текста интерфейса
                Console.ForegroundColor = ConsoleColor.DarkGray;
                printString(10, 2, "Сумма вклада:");
                printString(27, 2, "Ставка по вкладу:");
                printString(48, 2, "Период вклада:");
                printString(82, 2, "Итоговая сумма:");
                printString(102, 2, "Проценты:");
                Console.ResetColor();

                printString(10, 3, "...");
                printString(27, 3, "...% годовых");
                printString(48, 3, "... месяцев");

                printString(10, 27, "1 - Вернуться назад");

                Console.CursorVisible = true;

                // Ввод данных и их вывод после этого
                Console.SetCursorPosition(10, 3);
                double Sum = double.Parse(Console.ReadLine());

                printString(10, 3, "       ");
                printString(10, 3, $"{Sum} руб");

                Console.SetCursorPosition(27, 3);
                double Bet = double.Parse(Console.ReadLine());

                printString(27, 3, "            ");
                printString(27, 3, $"{Bet}% годовых");

                Console.SetCursorPosition(48, 3);
                int Dur = int.Parse(Console.ReadLine());

                printString(48, 3, "           ");
                printString(48, 3, $"{Dur} месяцев");

                Console.CursorVisible = false;

                // Анимация загрузки
                loadanim();

                // Переменные итоговой суммы
                double resultSum = 0;
                double resultBet = 0;

                // Массивы подробного списка
                double[] B1 = new double[Dur];
                double[] B2 = new double[Dur];
                double[] B3 = new double[Dur];
                double[] B4 = new double[Dur];
                double[] B5 = new double[Dur];

                // Обработка месячных платежей
                double[] A = new double[Dur];
                double moSum = Sum / Dur; // 11,308
                double moOst = Sum; // 135,700
                for (int i = 0; i < A.Length; i++)
                {
                    double moBet = ((Bet / 100) / 12) * moOst; // 1,243
                    double moPay = moSum + moBet;

                    B1[i] = moOst;
                    B2[i] = moBet;
                    B3[i] = moSum;
                    B4[i] = moPay;

                    moOst = moOst - moSum;
                    A[i] = moPay;

                    B5[i] = moOst;

                    resultSum = resultSum + A[i];
                    resultBet = resultBet + moBet;
                }

                // Вывод итоговой суммы и переплаты
                printString(82, 3, $"{Math.Round(resultSum, 2)} руб");
                printString(102, 3, $"{Math.Round(resultBet, 2)} руб");

                pages:

                // Вывод страниц
                if (Page == 1)
                {
                    printOne(10, 7, 17, "                                                                                                    ");

                    int wight = 10;
                    int height = 7;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if ((i + 1) <= 6)
                        {
                            height = i * 3 + 7;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 6 && (i + 1) <= 12)
                        {
                            height = (i - 6) * 3 + 7;
                            wight = 28;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 12 && (i + 1) <= 18)
                        {
                            height = (i - 12) * 3 + 7;
                            wight = 46;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 18 && (i + 1) <= 24)
                        {
                            height = (i - 18) * 3 + 7;
                            wight = 62;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 24 && (i + 1) <= 30)
                        {
                            height = (i - 24) * 3 + 7;
                            wight = 80;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 30 && (i + 1) <= 36)
                        {
                            height = (i - 30) * 3 + 7;
                            wight = 98;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if (A.Length > 36) printString(106, 27, "Стр. 1");
                    }
                }
                else if (Page == 2)
                {
                    printOne(10, 7, 17, "                                                                                                    ");

                    int wight = 10;
                    int height = 7;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if ((i + 1) > 36 && (i + 1) <= 42)
                        {
                            height = (i - 36) * 3 + 7;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 42 && (i + 1) <= 48)
                        {
                            height = (i - 42) * 3 + 7;
                            wight = 28;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 48 && (i + 1) <= 54)
                        {
                            height = (i - 48) * 3 + 7;
                            wight = 46;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 54 && (i + 1) <= 60)
                        {
                            height = (i - 54) * 3 + 7;
                            wight = 62;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 60 && (i + 1) <= 66)
                        {
                            height = (i - 60) * 3 + 7;
                            wight = 80;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        if ((i + 1) > 66 && (i + 1) <= 72)
                        {
                            height = (i - 66) * 3 + 7;
                            wight = 98;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            printString(wight, height, $"{i + 1} месяц:");
                            Console.ResetColor();
                            printString(wight, height + 1, $"{Math.Round(A[i], 2)} руб");
                        }
                        printString(106, 27, "Стр. 2");
                    }
                }

                if (A.Length > 36) printString(31, 27, "< > - Выбор страницы");

                moreinfo:

                // Подробная информация
                if (More == 1)
                {
                    printOne(10, 7, 18, "                                                                                                         ");

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    printString(10, 5, "Месяц");
                    printString(22, 5, "Сумма в начале");
                    printString(43, 5, "Процент");
                    printString(59, 5, "Оплата кредита");
                    printString(80, 5, "Итого платеж");
                    printString(99, 5, "Сумма в конце");
                    Console.ResetColor();

                    if (B1.Length <= 10) printString(106, 27, "      ");
                    else printString(106, 27, "Стр. 1");

                    if (B1.Length <= 10) printString(31, 27, "                    ");
                    else printString(31, 27, "Вверх вниз - Выбор страницы");

                    if (morePage == 1)
                    {
                        int lcount = 0;
                        for (int i = 0; i < B1.Length; i++) if (i + 1 <= 10) lcount++;

                        int lheight = 7;
                        for (int i = 0; i < lcount; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            printString(10, lheight, "                                                                                                      ");
                            Console.ResetColor();
                            lheight = lheight + 2;
                        }

                        int height = 7;
                        for (int i = 0; i < B1.Length; i++)
                        {
                            if (i + 1 <= 10)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.White;
                                printString(10, height, $"{i + 1} месяц");
                                printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                                printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                                printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                                printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                                printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                                height = height + 2;
                                Console.ResetColor();
                            }
                        }
                        if (B1.Length > 10) printString(106, 27, "Стр. 1");
                    }
                    else if (morePage == 2)
                    {
                        int lcount = 0;
                        for (int i = 0; i < B1.Length; i++) if (i + 1 > 10 && i + 1 <= 20) lcount++;

                        int lheight = 7;
                        for (int i = 0; i < lcount; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            printString(10, lheight, "                                                                                                      ");
                            Console.ResetColor();
                            lheight = lheight + 2;
                        }

                        int height = 7;
                        for (int i = 0; i < B1.Length; i++)
                        {
                            if (i + 1 > 10 && i + 1 <= 20)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.White;
                                printString(10, height, $"{i + 1} месяц");
                                printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                                printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                                printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                                printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                                printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                                height = height + 2;
                                Console.ResetColor();
                            }
                        }
                        printString(106, 27, "Стр. 2");
                    }
                    else if (morePage == 3)
                    {
                        int lcount = 0;
                        for (int i = 0; i < B1.Length; i++) if (i + 1 > 20 && i + 1 <= 30) lcount++;

                        int lheight = 7;
                        for (int i = 0; i < lcount; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            printString(10, lheight, "                                                                                                      ");
                            Console.ResetColor();
                            lheight = lheight + 2;
                        }

                        int height = 7;
                        for (int i = 0; i < B1.Length; i++)
                        {
                            if (i + 1 > 20 && i + 1 <= 30)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.White;
                                printString(10, height, $"{i + 1} месяц");
                                printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                                printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                                printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                                printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                                printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                                height = height + 2;
                                Console.ResetColor();
                            }
                        }
                        printString(106, 27, "Стр. 3");
                    }
                    else if (morePage == 4)
                    {
                        int lcount = 0;
                        for (int i = 0; i < B1.Length; i++) if (i + 1 > 30 && i + 1 <= 40) lcount++;

                        int lheight = 7;
                        for (int i = 0; i < lcount; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            printString(10, lheight, "                                                                                                      ");
                            Console.ResetColor();
                            lheight = lheight + 2;
                        }

                        int height = 7;
                        for (int i = 0; i < B1.Length; i++)
                        {
                            if (i + 1 > 30 && i + 1 <= 40)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.White;
                                printString(10, height, $"{i + 1} месяц");
                                printString(22, height, $"{Math.Round(B1[i], 2)} руб");
                                printString(43, height, $"{Math.Round(B2[i], 2)} руб");
                                printString(59, height, $"{Math.Round(B3[i], 2)} руб");
                                printString(80, height, $"{Math.Round(B4[i], 2)} руб");
                                printString(99, height, $"{Math.Round(B5[i], 2)} руб");
                                height = height + 2;
                                Console.ResetColor();
                            }
                        }
                        printString(106, 27, "Стр. 4");
                    }

                    Console.SetCursorPosition(10, 7);

                    // Обработка клавиш управления страницами
                    if (B1.Length > 10 && B1.Length <= 20)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.D1)
                        {
                            printOne(10, 5, 20, "                                                                                                         ");
                            printString(31, 27, "                           ");
                            printString(106, 27, "      ");
                            More = 0;
                            goto pages;
                        }
                        else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                        {
                            if (morePage == 1) morePage = 2;
                            else if (morePage > 1) morePage--;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                        {
                            if (morePage == 2) morePage = 1;
                            else if (morePage < 2) morePage++;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.Escape) Environment.Exit(0);
                        else goto moreinfo;
                    }
                    else if (B1.Length > 20 && B1.Length <= 30)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.D1)
                        {
                            printOne(10, 5, 20, "                                                                                                         ");
                            printString(31, 27, "                           ");
                            printString(106, 27, "      ");
                            More = 0;
                            goto pages;
                        }
                        else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                        {
                            if (morePage == 1) morePage = 3;
                            else if (morePage > 1) morePage--;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                        {
                            if (morePage == 3) morePage = 1;
                            else if (morePage < 3) morePage++;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.Escape) Environment.Exit(0);
                        else goto moreinfo;
                    }
                    else if (B1.Length > 30 && B1.Length <= 40)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.D1)
                        {
                            printOne(10, 5, 20, "                                                                                                         ");
                            printString(31, 27, "                           ");
                            printString(106, 27, "      ");
                            More = 0;
                            goto pages;
                        }
                        else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                        {
                            if (morePage == 1) morePage = 4;
                            else if (morePage > 1) morePage--;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                        {
                            if (morePage == 4) morePage = 1;
                            else if (morePage < 4) morePage++;
                            goto moreinfo;
                        }
                        else if (key == ConsoleKey.Escape) Environment.Exit(0);
                        else goto moreinfo;
                    }
                    else
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.D1)
                        {
                            printOne(10, 5, 20, "                                                                                                         ");
                            printString(31, 27, "                           ");
                            printString(106, 27, "      ");
                            More = 0;
                            goto pages;
                        }
                        else if (key == ConsoleKey.Escape) Environment.Exit(0);
                        else goto moreinfo;
                    }
                }

                Console.SetCursorPosition(10, 7);

                // Обработка клавиш управления меню
                if (A.Length > 36)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.D2)
                    {
                        Page = 1;
                        goto restart;
                    }
                    else if (key == ConsoleKey.D3)
                    {
                        More = 1;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.LeftArrow)
                    {
                        if (Page == 1) Page = 2;
                        else Page = 1;
                        goto pages;
                    }
                    else if (key == ConsoleKey.RightArrow)
                    {
                        if (Page == 1) Page = 2;
                        else Page = 1;
                        goto pages;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto pages;
                }
                else
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.D1) goto start;
                    else if (key == ConsoleKey.D2) goto restart;
                    else if (key == ConsoleKey.D3)
                    {
                        More = 1;
                        goto moreinfo;
                    }
                    else if (key == ConsoleKey.Escape) Environment.Exit(0);
                    else goto pages;
                }
            }
            else if (mode == 5)
            {

            }
            else if (mode == 6)
            {

            }
            else if (mode == 10)
            {
                restart:

                Console.Clear();

                // Вывод текста интерфейса
                Console.ForegroundColor = ConsoleColor.DarkGray;
                printString(10, 2, "Нужная дата:");
                printString(26, 2, "Ставка по кредиту:");
                printString(48, 2, "Период заема:");
                printString(82, 2, "Итоговая сумма:");
                printString(102, 2, "Переплата:");
                Console.ResetColor();

                printString(10, 3, "...");
                printString(26, 3, "...% годовых");
                printString(48, 3, "... месяцев");

                printString(10, 27, "1 - Вернуться назад");

                Console.CursorVisible = true;
            }

            Console.ReadKey();
        }
        private static void printString(int x, int y, string t)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(t);
        }
        private static void printStrings(int x, int y, string t)
        {
            string[] lines = Regex.Split(t, "\n");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(lines[i]);
                y++;
            }
        }
        private static void printOne(int x, int y, int k, string t)
        {
            for (int i = 0; i <= k; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(t);
                y++;
            }
        }
        private static void loadanim()
        {
            printString(82, 3, ".");
            printString(102, 3, ".");
            Console.SetCursorPosition(0, 28);
            Thread.Sleep(100);
            printString(82, 3, "..");
            printString(102, 3, "..");
            Console.SetCursorPosition(0, 28);
            Thread.Sleep(100);
            printString(82, 3, "...");
            printString(102, 3, "...");
            Console.SetCursorPosition(0, 28);
            Thread.Sleep(100);
            printString(82, 3, "   ");
            printString(102, 3, "   ");
        }
        
    }
}
