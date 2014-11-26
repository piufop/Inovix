using System.ServiceModel;

namespace Inovix.APT.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFinanceiroService" in both code and config file together.
    [ServiceContract]
    public interface IFinanceiroService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int ObterStatusFinanceiroCliente(string cpf);
    }
}
