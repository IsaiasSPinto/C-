namespace Exercicio_1
{
    public class Room
    {
        public int Number { get; private set; }

        public Boolean IsRented { get; private set; }

        public string? GuestName { get; private set; }

        public string? GuestEmail { get; private set; }

        public Room(int number)
        {
            Number = number;
            IsRented = false;
        }

        public override string ToString()
        {
            if (IsRented)
                return $"{Number}: {GuestName}, {GuestEmail}";
            else
                return $"{Number}";
        }

        public void RentRoom(string guestName, string guestEmail)
        {
            GuestName = guestName;
            GuestEmail = guestEmail;
            IsRented = true;
        }
    }
}
