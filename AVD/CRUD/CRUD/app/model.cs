using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.app
{
    internal class Ledger
    {
        static int counter = 0;
        public int? id;
        public decimal deposit;
        public Ledger(int? id, decimal deposit)
        {
            this.id = id;
            this.deposit = deposit;
        }
        public int? GenerateId()
        {
            id = counter;
            counter++;
            return id;
        }
    }
}

