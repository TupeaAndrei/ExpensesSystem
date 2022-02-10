using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSystem.TL.DTO
{
    public class ExpenseObjectDTO
    {
        public int Id { get; set; }
        public int ExpenseId { get; set; }
        public IEnumerable<ExpenseDTO> Expenses { get; set; }
        public int ObjectId { get; set; }
        public IEnumerable<ObjectDTO> Objects { get; set; }

    }
}
