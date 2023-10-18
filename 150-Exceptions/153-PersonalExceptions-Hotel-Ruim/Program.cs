using _153_PersonalExceptions_Hotel_Ruim.Entities;
using System;

namespace _153_PersonalExceptions_Hotel_Ruim
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
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
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

                string error = reservation.UpdateDates(checkIn, checkOut);
                if (error != null) 
                {
                    Console.WriteLine("Error in Reservation: " + error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}

