using MiniKredi_Basvurusu.ViewModels;

namespace MiniKredi_Basvurusu.Services.Interfaces
{
    public interface IApplicationService
    {
        string Evaluate(CreditApplicationViewModel model);
    }
}
