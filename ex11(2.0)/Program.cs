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
            const string CommandRub = "rub";
            const string CommandUsd = "usd";
            const string CommandCny = "cny";
            const string CommandBack = "back";


            string rubles = "rub";
            string dollars = "usd";
            string yuans = "cny";
            string back = "back";
            float exchangeRubToUsd = 94;
            float exchangeRubToYuan = 13;
            float exchangeUsdToYuan = 7.3f;
            bool isOpen = true;
            Console.Write($"Введите кол-во {rubles}: ");
            float rubWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введите кол-во {dollars}: ");
            float usdWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введите кол-во {yuans}: ");
            float yuanWallet = Convert.ToSingle(Console.ReadLine());

            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine($"Ваш баланс:\n{rubWallet} {rubles}\n{usdWallet} {dollars}\n{yuanWallet} {yuans}");
                Console.WriteLine($"\nКакую валюту вы хотите сконвертировать?\n1. {rubles}\n2. {dollars}\n3. {yuans}\n4. {CommandExit}");
                Console.Write("Введите операцию: ");
                string chosenOperation = Convert.ToString(Console.ReadLine());
                switch (chosenOperation.ToLower())
                {
                    case CommandRub:
                        Console.WriteLine($"В какую валюту вы хотите сконвертировать {rubles}?\n1. {dollars}\n2. {yuans}\n3. {back}");
                        Console.Write("Введите операцию: ");
                        string chosenOperationRub = Convert.ToString(Console.ReadLine());

                        switch (chosenOperationRub.ToLower())
                        {
                            case CommandUsd:
                                Console.Write($"Сколько {rubles} вы хотите перевести в {dollars}? ");
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
                            case CommandCny:
                                Console.Write($"Сколько {rubles} вы хотите перевести в {yuans}? ");
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
                                break;
                            default:
                                Console.WriteLine("Неверное значение\nПопробуйте еще раз");
                                Console.ReadKey();
                                break;
                        }

                        break;
                    case CommandUsd:
                        Console.WriteLine($"В какую валюты вы хотите сконвертировать {dollars}?\n1. {rubles}\n2. {yuans}\n3. {back}");
                        string chosenOperationUsd = Convert.ToString(Console.ReadLine());

                        switch (chosenOperationUsd.ToLower())
                        {
                            case CommandRub:
                                Console.Write($"Сколько {dollars} вы хотите перевести в {rubles}? ");
                                Console.Write("Введите операцию: ");
                                float UsdToRub = Convert.ToSingle(Console.ReadLine());
                                if (UsdToRub <= usdWallet)
                                {
                                    usdWallet -= UsdToRub;
                                    rubWallet += UsdToRub * exchangeRubToUsd;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }
                            case CommandCny:
                                Console.Write($"Сколько {dollars} вы хотите перевести в {yuans}? ");
                                Console.Write("Введите операцию: ");
                                float usdToCny = Convert.ToSingle(Console.ReadLine());
                                if (usdToCny <= usdWallet)
                                {
                                    usdWallet -= usdToCny;
                                    yuanWallet += usdToCny * exchangeUsdToYuan;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }
                            case CommandBack:
                                break;
                            default:
                                Console.WriteLine("Неверное значение\nПопробуйте еще раз");
                                Console.ReadKey();
                                break;
                        }

                        break;
                    case CommandCny:
                        Console.WriteLine($"В какую валюты вы хотите сконвертировать {yuans}?\n1 - {rubles}\n2 - {dollars}\n3 - {back}");
                        Console.Write("Введите операцию: ");
                        string chosenOperationCny = Convert.ToString(Console.ReadLine());

                        switch (chosenOperationCny.ToLower())
                        {
                            case CommandRub:
                                Console.Write($"Сколько {yuans} вы хотите перевести в {rubles}? ");
                                Console.Write("Введите операцию: ");
                                float CnyToRub = Convert.ToSingle(Console.ReadLine());
                                if (CnyToRub <= yuanWallet)
                                {
                                    yuanWallet -= CnyToRub;
                                    rubWallet += CnyToRub * exchangeRubToYuan;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }
                            case CommandUsd:
                                Console.Write($"Сколько {yuans} вы хотите перевести в {dollars}? ");
                                Console.Write("Введите операцию: ");
                                float CnyToUsd = Convert.ToSingle(Console.ReadLine());
                                if (CnyToUsd <= yuanWallet)
                                {
                                    yuanWallet -= CnyToUsd;
                                    usdWallet += CnyToUsd / exchangeUsdToYuan;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    Console.ReadKey();
                                    break;
                                }
                            case CommandBack:
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