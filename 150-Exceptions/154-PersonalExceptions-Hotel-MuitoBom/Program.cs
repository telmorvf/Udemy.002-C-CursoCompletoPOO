using _155_PersonalExceptions_Hotel_MuitoBom.Entities;
using _155_PersonalExceptions_Hotel_MuitoBom.Entities.Exceptions;
using System;

namespace _155_PersonalExceptions_Hotel_MuitoBom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in Date dd/MM/yyyy: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date dd/MM/yyyy: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();

                Console.Write("Check-in Date dd/MM/yyyy: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date dd/MM/yyyy: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected: " + e.Message);
            }   


        }
    }
}
