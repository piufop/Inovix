using System.ServiceModel;

namespace KGBWebService.Wcf
{
    [ServiceContract]
    public interface IFinanceiro
    {
        [OperationContract]
        int ObterStatusFinanceiroCliente(string cpf);
    }
}
