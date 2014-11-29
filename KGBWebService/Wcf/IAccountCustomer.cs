using System.ServiceModel;
using Inovix.Data;

namespace KGBWebService.Wcf
{
    [ServiceContract]
    public interface IAccountCustomer
    {
        [OperationContract]
        Account ObterDadosConta(Customer customer);
    }
}
