using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.app
{
    internal class Repo
    {
        private List<Ledger> ledgers;
        public Repo()
        {
            ledgers = new List<Ledger>();
        }
        public Ledger Create(Ledger ledger)
        {
            ledger.GenerateId();
            ledgers.Add(ledger);
            return ledger;
        }
        public List<Ledger> Load() {  return ledgers; }
    }
}
