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
            const string CommandInputExit = "exit";
            const string CommandInputRub = "rub";
            const string CommandInputUsd = "usd";
            const string CommandInputCny = "cny";
            const string CommandInputBack = "back";
            float exchangeRubToUsd = 95.71f;
            float exchangeRubToYuan = 13.11f;
            float exchangeUsdToYuan = 0.136976f;
            float exchangeUsdToRub = 0.010449f;
            float exchangeYuanToRub = 0.07628f;
            float exchaneYuanToUsd = 7.3f;
            bool isOpen = true;
            Console.Write($"Введите кол-во {CommandInputRub}: ");
            float rubWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введите кол-во {CommandInputUsd}: ");
            float usdWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введите кол-во {CommandInputCny}: ");
            float yuanWallet = Convert.ToSingle(Console.ReadLine());

            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine($"Ваш баланс:\n{rubWallet} {CommandInputRub}\n{usdWallet} {CommandInputUsd}\n{yuanWallet} {CommandInputCny}");
                Console.WriteLine($"\nКакую валюту вы хотите сконвертировать?\n1. {CommandInputRub}\n2. {CommandInputUsd}\n3. {CommandInputCny}\n4. {CommandInputExit}");
                Console.Write("Введите операцию: ");
                string chosenOperation = Convert.ToString(Console.ReadLine());

                switch (chosenOperation.ToLower())
                {
                    case CommandInputRub:
                        Console.WriteLine($"В какую валюту вы хотите сконвертировать {CommandInputRub}?\n" +
                            $"1. {CommandInputUsd}\n2. {CommandInputCny}\n3. {CommandInputBack}");
                        Console.Write("Введите операцию: ");
                        string chosenOperationRub = Convert.ToString(Console.ReadLine());

                        switch (chosenOperationRub.ToLower())
                        {
                            case CommandInputUsd:
                                Console.Write($"Сколько {CommandInputRub} вы хотите перевести в {CommandInputUsd}? ");
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

                            case CommandInputCny:
                                Console.Write($"Сколько {CommandInputRub} вы хотите перевести в {CommandInputCny}? ");
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

                            case CommandInputBack:
                                Console.WriteLine("Возвращаемся назад...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Неверное значение\nПопробуйте еще раз");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case CommandInputUsd:
                        Console.WriteLine($"В какую валюты вы хотите сконвертировать {CommandInputUsd}?\n" +
                            $"1. {CommandInputRub}\n2. {CommandInputCny}\n3. {CommandInputBack}");
                        Console.Write("Введите операцию: ");
                        string chosenOperationUsd = Convert.ToString(Console.ReadLine());

                        switch (chosenOperationUsd.ToLower())
                        {
                            case CommandInputRub:
                                Console.Write($"Сколько {CommandInputUsd} вы хотите перевести в {CommandInputRub}?\n");
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

                            case CommandInputCny:
                                Console.Write($"Сколько {CommandInputUsd} вы хотите перевести в {CommandInputCny}?\n");
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

                            case CommandInputBack:
                                Console.WriteLine("Возвращаемся назад...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Неверное значение\nПопробуйте еще раз");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case CommandInputCny:
                        Console.WriteLine($"В какую валюты вы хотите сконвертировать {CommandInputCny}?\n" +
                            $"1 - {CommandInputRub}\n2 - {CommandInputUsd}\n3 - {CommandInputBack}");
                        Console.Write("Введите операцию: ");
                        string chosenOperationCny = Convert.ToString(Console.ReadLine());

                        switch (chosenOperationCny.ToLower())
                        {
                            case CommandInputRub:
                                Console.Write($"Сколько {CommandInputCny} вы хотите перевести в {CommandInputRub}\n?");
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

                            case CommandInputUsd:
                                Console.Write($"Сколько {CommandInputCny} вы хотите перевести в {CommandInputUsd}?\n");
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

                            case CommandInputBack:
                                Console.WriteLine("Возвращаемся назад...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Неверное значение\nПопробуйте еще раз.");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case CommandInputExit:
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