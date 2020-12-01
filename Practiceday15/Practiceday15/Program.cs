using System;

namespace Practiceday15
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = 0;
            //sum(2, 3, out result);
            //sum(4, 5, out result);
            //Console.WriteLine(result);

            var normal = CheckIfCanWalkIntoBankSwitch(new Bank() { Status = BankBranchStatus.VIPCustomersOnly }, true);
            Console.WriteLine(normal);

            var newway = CheckIfCanWalkIntoBank5(new Bank() { Status = BankBranchStatus.VIPCustomersOnly }, true);
            Console.WriteLine(newway);

        }
        //public static int sum(int a, int b, out int r)
        //{
        //    r = a + b;
        //    return r + a * b;
        //}

        static bool CheckIfCanWalkIntoBankSwitch(Bank bank, bool isVip)
        {
            bool result = false;

            switch (bank.Status)
            {
                case BankBranchStatus.Open:
                    result = true;
                    break;

                case BankBranchStatus.Closed:
                    result = false;
                    break;

                case BankBranchStatus.VIPCustomersOnly:
                    result = isVip;
                    break;
                default:
                    result = false;
                    break;
            }
            return result;

        }
        #region step 1
        static bool CheckIfCanWalkIntoBank2(Bank bank, bool isVip)
        {
            var result = bank.Status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Closed => false,
                BankBranchStatus.VIPCustomersOnly => isVip,
                _ => false
            };
            return result;
        }

        #endregion

        #region Step 2
        static bool CheckIfCanWalkIntoBank3(Bank bank, bool isVip) => bank.Status switch
        {
            BankBranchStatus.Open => true,
            BankBranchStatus.Closed => false,
            BankBranchStatus.VIPCustomersOnly => isVip,
            _ => false
        };
        #endregion


        #region Step 5
        static bool CheckIfCanWalkIntoBank5(Bank bank, bool isVip)
        {
            return (bank.Status, isVip) switch
            {
                (BankBranchStatus.Open, _) => true,
                (BankBranchStatus.Closed, _) => false,
                (BankBranchStatus.VIPCustomersOnly, true) => true,
                (BankBranchStatus.VIPCustomersOnly, false) => false,
                (_, _) => false
            };
        }
        #endregion

    }


}
