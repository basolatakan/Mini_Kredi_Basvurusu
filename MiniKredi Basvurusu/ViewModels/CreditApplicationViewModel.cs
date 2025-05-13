using System.ComponentModel.DataAnnotations;

namespace MiniKredi_Basvurusu.ViewModels
{
    public class CreditApplicationViewModel
    {
        [Required(ErrorMessage = "Ad boş bırakılamaz.")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad boş bırakılamaz.")]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Maaş alanı zorunludur.")]
        public double MonthlyIncome { get; set; }
        [Required(ErrorMessage = "Beklediğiniz kredi tutar alanı zorunludur.")]
        public double RequestedCreditAmount { get; set; }
    }
}
