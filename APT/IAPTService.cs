﻿using Inovix.Data;
using Inovix.Data.Portability;
using System.ServiceModel;

namespace APT
{
    [ServiceContract]
    public interface IAPTService
    {
        [OperationContract]
        PortabilityTicket SolicitarBilhetePortabilidade(Customer customer, Account account);
    }
}
