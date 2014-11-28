using System.ServiceModel;
using Inovix.Data;

namespace KGBWebService.Wcf
{
    [ServiceContract]
    public interface IAccountCustomer
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        Account ObterDadosConta(Customer customer);
    }
}
