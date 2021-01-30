using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacaoInterface.Service
{
    class PayPalService: IOnlinePaymentService
    {
        public double paymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double interest(double amount, int months)
        {
            return amount * (months * 0.01);
        }
    }
}
