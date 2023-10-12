using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.app
{
    internal class Service
    {
        private Repo repo;
        public Service(Repo repo) 
        {
            this.repo = repo;
        }
        public Ledger Deposit(decimal total)
        {
            return repo.Create(new Ledger(null, total));
        }
        public List<Ledger> DepositList()
        {
            return repo.Load();
        }
    }
}
