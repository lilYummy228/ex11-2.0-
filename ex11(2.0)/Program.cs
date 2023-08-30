using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandConvertRub = "rub";
            const string CommandConvertUsd = "usd";
            const string CommandConvertCny = "cny";
            const string CommandBack = "back";

            float exchangeRubToUsd = 95.71f;
            float exchangeRubToYuan = 13.11f;
            float exchangeUsdToYuan = 0.136976f;
            float exchangeUsdToRub = 0.010449f;
            float exchangeYuanToRub = 0.07628f;
            float exchaneYuanToUsd = 7.3f;
            bool isOpen = true;
            Console.Write($"Введите кол-во {CommandConvertRub}: ");
            float rubWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введите кол-во {CommandConvertUsd}: ");
            float usdWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введите кол-во {CommandConvertCny}: ");
            float yuanWallet = Convert.ToSingle(Console.ReadLine());

            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine($"Ваш баланс:\n{rubWallet} {CommandConvertRub}\n{usdWallet} {CommandConvertUsd}\n{yuanWallet} {CommandConvertCny}");
                Console.WriteLine($"\nКакую валюту вы хотите сконвертировать?\n1. {CommandConvertRub}\n2. {CommandConvertUsd}\n3. {CommandConvertCny}\n4. {CommandExit}");
                Console.Write("Введите операцию: ");
                string chosenOperation = Convert.ToString(Console.ReadLine());

                switch (chosenOperation.ToLower())
                {
                    case CommandConvertRub:
                        Console.WriteLine($"В какую валюту вы хотите сконвертировать {CommandConvertRub}?\n" +
                            $"1. {CommandConvertUsd}\n2. {CommandConvertCny}\n3. {CommandBack}");
                        Console.Write("Введите операцию: ");
                        string chosenOperationRub = Convert.ToString(Console.ReadLine());

                        switch (chosenOperationRub.ToLower())
                        {
                            case CommandConvertUsd:
                                Console.Write($"Сколько {CommandConvertRub} вы хотите перевести в {CommandConvertUsd}? ");
                                Console.Write("Введите операцию: ");
                                float rubToUsd = Convert.ToSingle(Console.ReadLine());

                                if (rubToUsd <= rubWallet)
                                {
                                    rubWallet -= rubToUsd;
                                    usdWallet += rubToUsd / exchangeRubToUsd;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }

                            case CommandConvertCny:
                                Console.Write($"Сколько {CommandConvertRub} вы хотите перевести в {CommandConvertCny}? ");
                                Console.Write("Введите операцию: ");
                                float rubToCny = Convert.ToSingle(Console.ReadLine());

                                if (rubToCny <= rubWallet)
                                {
                                    rubWallet -= rubToCny;
                                    yuanWallet += rubToCny / exchangeRubToYuan;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }

                            case CommandBack:
                                Console.WriteLine("Возвращаемся назад...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Неверное значение\nПопробуйте еще раз");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case CommandConvertUsd:
                        Console.WriteLine($"В какую валюты вы хотите сконвертировать {CommandConvertUsd}?\n" +
                            $"1. {CommandConvertRub}\n2. {CommandConvertCny}\n3. {CommandBack}");
                        Console.Write("Введите операцию: ");
                        string chosenOperationUsd = Convert.ToString(Console.ReadLine());

                        switch (chosenOperationUsd.ToLower())
                        {
                            case CommandConvertRub:
                                Console.Write($"Сколько {CommandConvertUsd} вы хотите перевести в {CommandConvertRub}?\n");
                                Console.Write("Введите операцию: ");
                                float UsdToRub = Convert.ToSingle(Console.ReadLine());

                                if (UsdToRub <= usdWallet)
                                {
                                    usdWallet -= UsdToRub;
                                    rubWallet += UsdToRub / exchangeUsdToRub;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }

                            case CommandConvertCny:
                                Console.Write($"Сколько {CommandConvertUsd} вы хотите перевести в {CommandConvertCny}?\n");
                                Console.Write("Введите операцию: ");
                                float usdToCny = Convert.ToSingle(Console.ReadLine());

                                if (usdToCny <= usdWallet)
                                {
                                    usdWallet -= usdToCny;
                                    yuanWallet += usdToCny / exchangeUsdToYuan;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }

                            case CommandBack:
                                Console.WriteLine("Возвращаемся назад...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Неверное значение\nПопробуйте еще раз");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case CommandConvertCny:
                        Console.WriteLine($"В какую валюты вы хотите сконвертировать {CommandConvertCny}?\n" +
                            $"1 - {CommandConvertRub}\n2 - {CommandConvertUsd}\n3 - {CommandBack}");
                        Console.Write("Введите операцию: ");
                        string chosenOperationCny = Convert.ToString(Console.ReadLine());

                        switch (chosenOperationCny.ToLower())
                        {
                            case CommandConvertRub:
                                Console.Write($"Сколько {CommandConvertCny} вы хотите перевести в {CommandConvertRub}\n?");
                                Console.Write("Введите операцию: ");
                                float CnyToRub = Convert.ToSingle(Console.ReadLine());

                                if (CnyToRub <= yuanWallet)
                                {
                                    yuanWallet -= CnyToRub;
                                    rubWallet += CnyToRub / exchangeYuanToRub;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }

                            case CommandConvertUsd:
                                Console.Write($"Сколько {CommandConvertCny} вы хотите перевести в {CommandConvertUsd}?\n");
                                Console.Write("Введите операцию: ");
                                float cnyToUsd = Convert.ToSingle(Console.ReadLine());

                                if (cnyToUsd <= yuanWallet)
                                {
                                    yuanWallet -= cnyToUsd;
                                    usdWallet += cnyToUsd / exchaneYuanToUsd;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }

                            case CommandBack:
                                Console.WriteLine("Возвращаемся назад...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Неверное значение\nПопробуйте еще раз.");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Неверная операция\nПопробуйте еще раз");
                        Console.ReadKey();
                        break;
                }

            }
        }
    }
}