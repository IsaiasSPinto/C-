using Exercicio_1;

Console.WriteLine("How many rooms will be rented? ");

int roomsQuantity = int.Parse(Console.ReadLine() ?? "0");

Room[] availableRooms = new Room[10];
Room[] rentedRooms = new Room[roomsQuantity];

for(int i = 0; i < availableRooms.Length;i++) {
    availableRooms[i] = new Room(i);
}

for(int renteds = 0;renteds < roomsQuantity;renteds++) {
    Console.WriteLine("Pick a available Room");
    foreach(Room room in availableRooms) {
        if(!room.IsRented) {
            System.Console.Write(room + " ,");
        }
    }

    Console.WriteLine();
    Room selectedRoom = availableRooms[int.Parse(Console.ReadLine() ?? "0")];
    while(selectedRoom.IsRented) {
        System.Console.WriteLine("Please pick another room");
        selectedRoom = availableRooms[int.Parse(Console.ReadLine() ?? "0")];
    }

    Console.WriteLine("Type your name: ");
    string guestName = Console.ReadLine() ?? "";

    Console.WriteLine("Type your email: ");
    string guestEmail = Console.ReadLine() ?? "";

    selectedRoom.RentRoom(guestName, guestEmail);
    rentedRooms[renteds] = selectedRoom;
}

Console.WriteLine("Busy rooms:");
foreach(Room room in rentedRooms) {
    System.Console.WriteLine(room);
}







