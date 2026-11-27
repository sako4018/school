using System;
using System.Collections.Generic;

public class MovieTicketBooking
{
    public string MovieName { get; private set; }
    public int TotalSeats { get; private set; }
    public decimal BaseTicketPrice { get; private set; }
    public List<int> BookedSeats { get; private set; } = new(); //

    public MovieTicketBooking(string movieName, int totalSeats, decimal baseTicketPrice)
    {
        if (totalSeats <= 0)
            throw new ArgumentException("Total seats must be greater than zero.");
        MovieName = movieName; //
        TotalSeats = totalSeats;
        BaseTicketPrice = baseTicketPrice; //
    }

    public void BookSeat(int seatNumber)
    {
        if (seatNumber <= 0 || seatNumber > TotalSeats)
            throw new ArgumentException("Invalid seat number.");
        if (BookedSeats.Contains(seatNumber))
            throw new InvalidOperationException("Seat is already booked.");
        BookedSeats.Add(seatNumber);
    }

    public decimal CalculatePrice(int numberOfTickets, bool isPremium)
    {
        if (numberOfTickets <= 0)
            throw new ArgumentException("Number of tickets must be positive.");
        decimal price = BaseTicketPrice * numberOfTickets; //
        return Math.Round(price, 1); //
    }

    public int GetAvailableSeats()
    {
        return TotalSeats; //
    }


    public void CancelBooking(int seatNumber)
    {
        if (seatNumber <= 0 || seatNumber > TotalSeats)
            throw new ArgumentException("Invalid seat number.");
        if (!BookedSeats.Contains(seatNumber))
            throw new InvalidOperationException("Seat is not booked.");
        BookedSeats.Remove(seatNumber);
    }

    public decimal GetTotalSales()
    {
        return BookedSeats.Count * BaseTicketPrice;
    }
}
