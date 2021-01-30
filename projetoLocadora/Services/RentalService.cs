using System;
using projetoLocadora.Entities;

namespace projetoLocadora.Services
{
    class RentalService
    {
        public double pricePerHour { get; private set; }
        public double pricePerDay { get; private set; }

        private ITaxServices _TaxServices;

        public RentalService(double privePerHour, double pricePerDay, ITaxServices taxServices)
        {
            this.pricePerHour = privePerHour;
            this.pricePerDay = pricePerDay;
            this._TaxServices = taxServices;
        }

        public void processinvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.finish.Subtract(carRental.start);

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = pricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
            }


            double tax = _TaxServices.tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, tax);
        }

    }
}
