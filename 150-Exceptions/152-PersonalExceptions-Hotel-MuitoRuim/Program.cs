using _152_Exceptions_TryCatchFinally_Hotel.Entities;
using Microsoft.VisualBasic;
using System;

namespace _152_Exceptions_TryCatchFinally_Hotel
{
    internal class Program
    {
        // Bad Solution: Tive de colocar toda a lógica
        // de validação no meu programa principal,
        // toda a validação tem de estar dentro da reserva
        
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in Date dd/MM/yyyy: ");
            DateTime  checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out Date dd/MM/yyyy: ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn) 
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date ");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();

                Console.Write("Check-in Date dd/MM/yyyy: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date dd/MM/yyyy: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now) 
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date ");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
            
        }
    }
}
