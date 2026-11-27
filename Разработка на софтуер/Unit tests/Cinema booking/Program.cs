using System;

public class Program
{
    public static void Main()
    {
        MovieTicketBooking booking = new MovieTicketBooking("Dune", 10, 12.50m);
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("=== " + booking.MovieName + " ===");
            Console.WriteLine("1. Book a seat");
            Console.WriteLine("2. Cancel a booking");
            Console.WriteLine("3. Calculate price");
            Console.WriteLine("4. Show free seats");
            Console.WriteLine("5. Show total sales");
            Console.WriteLine("0. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            // Всяка команда е в try, за да се виждат грешките от класа
            try
            {
                if (choice == "1")
                {
                    Console.Write("Seat number: ");
                    int seat = int.Parse(Console.ReadLine());
                    booking.BookSeat(seat);
                    Console.WriteLine("Seat " + seat + " booked.");
                }
                else if (choice == "2")
                {
                    Console.Write("Seat number: ");
                    int seat = int.Parse(Console.ReadLine());
                    booking.CancelBooking(seat);
                    Console.WriteLine("Booking for seat " + seat + " cancelled.");
                }
                else if (choice == "3")
                {
                    Console.Write("Number of tickets: ");
                    int tickets = int.Parse(Console.ReadLine());
                    Console.Write("Premium? (y/n): ");
                    bool premium = Console.ReadLine() == "y";
                    Console.WriteLine("Price: " + booking.CalculatePrice(tickets, premium));
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Free seats: " + booking.GetAvailableSeats());
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Total sales: " + booking.GetTotalSales());
                }
                else if (choice == "0")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Unknown choice.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
