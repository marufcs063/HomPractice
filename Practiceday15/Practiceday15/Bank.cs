using System;
using System.Collections.Generic;
using System.Text;

namespace Practiceday15
{
    public class Bank
    {
        public BankBranchStatus Status { get; set; }

    }

    public enum BankBranchStatus
    {
        Open, 
        Closed,
        VIPCustomersOnly
    }
}
