//using Arrays;
//using System.Globalization;

//int people = int.Parse(Console.ReadLine());

//Person[] person = new Person[people];
//double heights = 0.0;

//for (int i = 0; i < people; i++)
//{
//    person[i] = new Person
//    {
//        Name = Console.ReadLine(),
//        Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
//    };
//    heights += person[i].Height;
//}

//for (int i = 0; i < people; i++)
//{
//    Console.WriteLine($"\nName: {person[i].Name}");
//    Console.WriteLine($"Height: {person[i].Height.ToString("F2", CultureInfo.InvariantCulture)}\n");
//}

//Console.Write($"Average Height: {(heights / people).ToString("F2", CultureInfo.InvariantCulture)}");

using Arrays;

Console.Write("How many rooms will be rented? ");
int roomsRented = int.Parse(Console.ReadLine());

Rental[] rentedRooms = new Rental[10];

for (int i = 0; i < roomsRented; i++)
{
    Console.WriteLine($"Rent #{i + 1}");

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Room: ");
    int rentedRoom = int.Parse(Console.ReadLine());

    Console.WriteLine();

    rentedRooms[rentedRoom] = new(name, email, rentedRoom);
}

Console.WriteLine($"Busy Rooms:");

for (int i = 0; i < 10; i++)
{
    if (rentedRooms[i] != null)
        Console.WriteLine($"{rentedRooms[i].Room}: {rentedRooms[i].Name}, {rentedRooms[i].Email}");
}