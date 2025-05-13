using System.ComponentModel.DataAnnotations;

namespace MiniKredi_Basvurusu.Models
{
    public class CreditApplication
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double MonthlyIncome { get; set; }
        public double RequestedCreditAmount { get; set; }
    }
}
