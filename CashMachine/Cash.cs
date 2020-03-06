using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Cash
    {
        private const int MaxCount = 100;
        private static readonly int[] MoneyType = { 10, 50, 100, 200, 500, 1000, 2000, 5000 };
        private int[] CountMoney = { 10, 10, 10, 10, 10, 10, 10, 10 };


        private int GetCountAllMoney()
        {
            int count = 0;
            for (int i = 0; i < CountMoney.Length; ++i)
            {
                count = count + CountMoney[i];
            }
            return count;
        }

        public bool AcceptBanknote(int Type, int Count)
        {
            if ((GetCountAllMoney() + Count) > MaxCount)
            {
                return false;
            }

            CountMoney[Type] = CountMoney[Type] + Count;

            return true;
        }

        public int GetSumMoney(int[] count)
        {
            int sum = 0;
            for (int i = 0; i < MoneyType.Length; ++i)
            {
                sum = sum + MoneyType[i] * count[i];
            }
            return sum;
        }

        public int[] GiveOutBanknotes(int needSum, bool smallBanknotes, int Type)
        {
            int[] giveOutSum = new int[MoneyType.Length];

            if (smallBanknotes == true)
            {
                if ((CountMoney[Type] > 0) && (MoneyType[Type] <= needSum))
                {
                    for (int i = CountMoney[Type]; i >= 0; --i)
                    {
                        int sum = needSum - i * MoneyType[Type];
                        if (sum > 0)
                        {
                            CountMoney[Type] -= i;
                            giveOutSum = GiveOutMoney(sum);
                            if (GetSumMoney(giveOutSum) > 0)
                            {
                                giveOutSum[Type] += i;
                                break;
                            }
                            else
                            {
                                CountMoney[Type] += i;
                            }
                        }
                    }
                }
            }
            else
            {
                giveOutSum = GiveOutMoney(needSum);
            }


            return giveOutSum;
        }

        public int[] GiveOutMoney(int needSum)
        {
            int[] giveOutSum = new int[MoneyType.Length];

            if (GetSumMoney(CountMoney) < needSum)
            {
                return giveOutSum;
            }

            int[] F = new int[needSum + 1];
            F[0] = 0;

            for (int i = 1; i <= needSum; ++i)
            {
                F[i] = int.MaxValue;

                for (int j = 0; j < MoneyType.Length; ++j)
                {
                    bool isTypeExist = CountMoney[j] > 0;
                    if (isTypeExist && i >= MoneyType[j])
                    {
                        if (F[i] > (F[i - MoneyType[j]] + 1))
                        {
                            F[i] = F[i - MoneyType[j]] + 1;
                        }
                    }
                }
            }

            if (F[needSum] == int.MaxValue)
            {
                return giveOutSum;
            }


            int sum = needSum;

            while (sum > 0)
            {
                int curSum = sum;
                for (int i = 0; i < MoneyType.Length; ++i)
                {
                    bool isTypeExist = (CountMoney[i] - giveOutSum[i]) > 0;
                    if (isTypeExist && sum >= MoneyType[i])
                    {
                        if (F[sum] == (F[sum - MoneyType[i]] + 1))
                        {
                            ++giveOutSum[i];
                            sum -= MoneyType[i];
                            break;
                        }
                    }
                }

                if (curSum == sum)
                {
                    for (int i = 0; i < giveOutSum.Length; ++i)
                    {
                        giveOutSum[i] = 0;
                    }
                    break;
                }

            }


            for (int i = 0; i < CountMoney.Length; ++i)
            {
                CountMoney[i] -= giveOutSum[i];
            }


            return giveOutSum;
        }

        public string GetState()
        {
            string state = "Состояние банкомата:\n";
            int count = 0;
            int sum = 0;
            for (int i = 0; i < MoneyType.Length; ++i)
            {
                count = count + CountMoney[i];
                sum = sum + MoneyType[i] * CountMoney[i];
                state = state + "\nТип купюры: " + MoneyType[i] + " Количество: " + CountMoney[i];
            }
            state = state + "\n\nОбщая сумма: " + sum;
            state = state + "\n\nКоличество купюр: " + count;
            state = state + "\nМаксимальное количество купюр: " + MaxCount;

            return state;
        }

        public string GetSumWithMoneyType(int[] count)
        {
            string state = "";
            int sum = 0;
            for (int i = 0; i < MoneyType.Length; ++i)
            {
                if (count[i] > 0)
                {
                    sum = sum + MoneyType[i] * count[i];
                    state = state + "\nТип купюры: " + MoneyType[i] + " Количество: " + count[i];
                }
            }
            state = state + "\n\nОбщая сумма: " + sum;

            return state;
        }

    }
}
