using System;
using _206_CarRental_With_Interfaces.Entities;

namespace _206_CarRental_With_Interfaces.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        // Não é a melhor forma de fazer, é usada a injeção de dependência no construtor
            // private TaxServiceBrazil _taxService = new TaxServiceBrazil();

            // public RentalService(double pricePerHour, double pricePerDay)
            // {
            //     PricePerHour = pricePerHour;
            //     PricePerDay = pricePerDay;
            // }

        // Inversão de controle por meio de injeção de dependêcia
        private ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}