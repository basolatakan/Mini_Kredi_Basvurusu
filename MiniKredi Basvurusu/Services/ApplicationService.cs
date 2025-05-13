using MiniKredi_Basvurusu.Services.Interfaces;
using MiniKredi_Basvurusu.ViewModels;

namespace MiniKredi_Basvurusu.Services
{
    public class ApplicationService : IApplicationService
    {
        string message;
        public string Evaluate(CreditApplicationViewModel model)
        {
            if (model.RequestedCreditAmount > model.MonthlyIncome * 0.30)
            {
                message = $"Sayın {model.FirstName} {model.LastName} Kredi Başvurunuz Onaylandı.";
            }
            else
            {
                message = $"Sayın {model.FirstName} {model.LastName} Kredi Başvurunuz Reddedildi.";
            }
            return message;
        }
    }
}
