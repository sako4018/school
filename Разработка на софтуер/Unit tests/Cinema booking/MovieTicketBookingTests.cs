using NUnit.Framework;

[TestFixture]
public class MovieTicketBookingTests
{
    private MovieTicketBooking booking;

    [SetUp]
    public void SetUp()
    {
        booking = new MovieTicketBooking("Dune", 10, 12.345m);
    }

    // ---------- Тестове, които трябва да минават ----------

    [Test]
    public void Constructor_ValidData_SetsProperties()
    {
        Assert.That(booking.MovieName, Is.EqualTo("Dune"));
        Assert.That(booking.TotalSeats, Is.EqualTo(10));
    }

    [TestCase(0)]
    [TestCase(-5)]
    public void Constructor_InvalidSeats_Throws(int seats)
    {
        Assert.Throws<ArgumentException>(() => new MovieTicketBooking("Dune", seats, 10m));
    }

    [Test]
    public void BookSeat_ValidSeat_IsBooked()
    {
        booking.BookSeat(3);
        Assert.That(booking.BookedSeats, Does.Contain(3));
    }

    [TestCase(0)]
    [TestCase(11)]
    public void BookSeat_InvalidSeat_Throws(int seat)
    {
        Assert.Throws<ArgumentException>(() => booking.BookSeat(seat));
    }

    [Test]
    public void BookSeat_SameSeatTwice_Throws()
    {
        booking.BookSeat(3);
        Assert.Throws<InvalidOperationException>(() => booking.BookSeat(3));
    }

    [Test]
    public void CalculatePrice_ZeroTickets_Throws()
    {
        Assert.Throws<ArgumentException>(() => booking.CalculatePrice(0, false));
    }

    // ---------- Тестове, които откриват грешки в оригиналния код ----------

    [Test]
    public void Constructor_NullName_Throws() // грешка 1
    {
        Assert.Throws<ArgumentException>(() => new MovieTicketBooking(null!, 10, 10m));
    }

    [Test]
    public void Constructor_NegativePrice_Throws() // грешка 2
    {
        Assert.Throws<ArgumentException>(() => new MovieTicketBooking("Dune", 10, -5m));
    }

    [Test]
    public void CalculatePrice_Premium_CostsMoreThanStandard() // грешка 3
    {
        decimal standard = booking.CalculatePrice(2, false);
        decimal premium = booking.CalculatePrice(2, true);
        Assert.That(premium, Is.GreaterThan(standard));
    }

    [Test]
    public void CalculatePrice_RoundsToTwoDecimals() // грешка 4
    {
        // 12.345 * 1 = 12.345 -> очакваме 12.35 (закръгляне встрани от нулата), не 12.3
        Assert.That(booking.CalculatePrice(1, false), Is.EqualTo(12.35m));
    }

    [Test]
    public void GetAvailableSeats_AfterBooking_DecreasesByOne() // грешка 5
    {
        booking.BookSeat(1);
        Assert.That(booking.GetAvailableSeats(), Is.EqualTo(9));
    }

    [Test]
    public void BookedSeats_CannotBeChangedFromOutside() // грешка 6
    {
        booking.BookedSeats.Add(99);
        Assert.That(booking.BookedSeats, Does.Not.Contain(99));
    }

    // ---------- Тестове за новите методи ----------

    [Test]
    public void CancelBooking_BookedSeat_RemovesIt()
    {
        booking.BookSeat(4);
        booking.CancelBooking(4);
        Assert.That(booking.BookedSeats, Does.Not.Contain(4));
    }

    [Test]
    public void CancelBooking_NotBookedSeat_Throws()
    {
        Assert.Throws<InvalidOperationException>(() => booking.CancelBooking(4));
    }

    [TestCase(0)]
    [TestCase(11)]
    public void CancelBooking_InvalidSeat_Throws(int seat)
    {
        Assert.Throws<ArgumentException>(() => booking.CancelBooking(seat));
    }

    [Test]
    public void CancelBooking_ThenBookAgain_Works()
    {
        booking.BookSeat(4);
        booking.CancelBooking(4);
        Assert.DoesNotThrow(() => booking.BookSeat(4));
    }

    [Test]
    public void CancelBooking_FreesSeat()
    {
        booking.BookSeat(4);
        booking.CancelBooking(4);
        Assert.That(booking.GetAvailableSeats(), Is.EqualTo(10));
    }

    [Test]
    public void GetTotalSales_NoBookings_IsZero()
    {
        Assert.That(booking.GetTotalSales(), Is.EqualTo(0m));
    }

    [Test]
    public void GetTotalSales_TwoBookings_IsTwoPrices()
    {
        booking.BookSeat(1);
        booking.BookSeat(2);
        Assert.That(booking.GetTotalSales(), Is.EqualTo(24.69m));
    }

    [Test]
    public void GetTotalSales_AfterCancel_DoesNotCountCancelled()
    {
        booking.BookSeat(1);
        booking.BookSeat(2);
        booking.CancelBooking(2);
        Assert.That(booking.GetTotalSales(), Is.EqualTo(12.345m));
    }
}
