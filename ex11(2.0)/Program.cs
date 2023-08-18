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
            bool isOpen = true;
            Console.Write("Введите кол-во рублей: ");
            float rubWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите кол-во долларов: ");
            float usdWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите кол-во евро: ");
            float eurWallet = Convert.ToSingle(Console.ReadLine());

            while (isOpen)
            {
                Console.WriteLine($"Ваш баланс:\n{rubWallet} рублей\n{usdWallet} долларов\n{eurWallet} евро");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Какую валюты вы хотите сконвертировать?\n1 - Рубли\n2 - Доллары\n3 - Евро\n4 - выйти из программы.");
                int chosenOperation1 = Convert.ToInt32(Console.ReadLine());
                switch (chosenOperation1)
                {
                    case 1:
                        Console.WriteLine("В какую валюты вы хотите сконвертировать рубли?\n1 - Доллары\n2 - Евро\n3 - вернуться назад");
                        int chosenOperation2 = Convert.ToInt32(Console.ReadLine());

                        switch (chosenOperation2)
                        {
                            case 1:
                                Console.Write("Сколько рублей вы хотите перевести? ");
                                float rubToUsd = Convert.ToSingle(Console.ReadLine());
                                if (rubToUsd <= rubWallet)
                                {
                                    rubWallet -= rubToUsd;
                                    usdWallet += rubToUsd / 94;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    break;
                                }
                            case 2:
                                Console.Write("Сколько рублей вы хотите перевести? ");
                                float rubToEur = Convert.ToSingle(Console.ReadLine());
                                if (rubToEur <= rubWallet)
                                {
                                    rubWallet -= rubToEur;
                                    eurWallet += rubToEur / 101;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Операция не выполнена");
                                    break;
                                }
                            case 3:
                                break;
                        }

                        break;
                }

            }
        }
    }
}