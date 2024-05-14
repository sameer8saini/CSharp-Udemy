

void MakeHotelReservation(string guestName = "Sameer", DateTime checkInDate, int numberOfDays,
    int numberOfGuests = 1, string roomType = "Standard")
{
    Console.WriteLine($"Guest name: {guestName}");
    Console.WriteLine($"Checkin date: {checkInDate}");
    Console.WriteLine($"Number of days: {numberOfDays}");
    Console.WriteLine($"Number of guests: {numberOfGuests}");
    Console.WriteLine($"Room Type: {roomType}");
}

MakeHotelReservation("Sameer Saini", new DateTime(DateTime.Now.Year, 1, 1), 1);
MakeHotelReservation("John Doe", new DateTime(DateTime.Now.Year, 1, 1), 1, 2, "Lux");




