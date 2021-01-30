using System;
using System.Collections.Generic;
using System.Linq;
using exercicioFixacaoInterface.Entites;

namespace exercicioFixacaoInterface.Service
{
    class ContractService
    {
        public IOnlinePaymentService _onlinePayment;

        public ContractService(IOnlinePaymentService onlinePayment)
        {
            _onlinePayment = onlinePayment;
        }

        public void processContract(Contract contract, int months)
        {

            double basicQuota = contract.totalValue / months;

            for (int i = 0; i < months; i++)
            {

                var date = contract.date.AddDays(i);
                var updateQuota = basicQuota+ _onlinePayment.interest(basicQuota, i +1);
                var total = updateQuota +  _onlinePayment.paymentFee(updateQuota);
                var installment = new Installment(date, total);

                Console.WriteLine(installment.ToString());
            }
        }
    }
}
