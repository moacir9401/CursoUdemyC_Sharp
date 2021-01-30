using System;
using exercicioTry.Entities.exceptions;

namespace exercicioTry.Entities
{
    class Reservation
    {

        public int roomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in");
            }

            this.roomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;

        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            var now = DateTime.Now;

            if (checkin < now || checkout < now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in");
            }

            CheckIn = checkin;
            CheckOut = checkout; 
        }

        public override string ToString()
        {
            return $"Room {roomNumber}, check-in {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

    }
}
