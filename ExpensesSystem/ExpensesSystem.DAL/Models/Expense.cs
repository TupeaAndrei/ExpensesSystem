using ExpensesSystem.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSystem.DAL.Models
{
    public class Expense : IEntity
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string CurrencyName { get; set; }

    }
}
