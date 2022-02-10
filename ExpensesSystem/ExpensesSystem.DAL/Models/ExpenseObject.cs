using ExpensesSystem.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSystem.DAL.Models
{
    public class ExpenseObject : IEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Expense")]
        public int ExpenseId { get; set; }
        public IEnumerable<Expense> Expenses { get; set; }

        [ForeignKey("Object")]
        public int ObjectId { get; set; }
        public IEnumerable<Object> Objects { get; set; }
    }
}
