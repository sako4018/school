using System;

namespace Task7_PetClinic
{
    public class Clinic
    {
        private Pet[] rooms;

        public Clinic(string name, int roomsCount)
        {
            if (roomsCount % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Name = name;
            rooms = new Pet[roomsCount];
        }

        public string Name { get; set; }

        public int RoomsCount
        {
            get { return rooms.Length; }
        }

        // Ред на настаняване: центъра, после наляво, после надясно (3, 2, 4, 1, 5)
        public bool Add(Pet pet)
        {
            int center = rooms.Length / 2;

            if (rooms[center] == null)
            {
                rooms[center] = pet;
                return true;
            }

            for (int step = 1; step <= center; step++)
            {
                if (rooms[center - step] == null)
                {
                    rooms[center - step] = pet;
                    return true;
                }
                if (rooms[center + step] == null)
                {
                    rooms[center + step] = pet;
                    return true;
                }
            }

            return false;
        }

        // Изписване: от центъра надясно до края, после от първата стая до центъра (3, 4, 5, 1, 2)
        public bool Release()
        {
            int center = rooms.Length / 2;

            for (int i = center; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    rooms[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < center; i++)
            {
                if (rooms[i] != null)
                {
                    rooms[i] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] == null)
                {
                    return true;
                }
            }
            return false;
        }

        // roomNumber е номерът на стаята (от 1)
        public string PrintRoom(int roomNumber)
        {
            Pet pet = rooms[roomNumber - 1];
            if (pet == null)
            {
                return "Room empty";
            }
            return pet.ToString();
        }

        public void PrintAll()
        {
            for (int i = 1; i <= rooms.Length; i++)
            {
                Console.WriteLine(PrintRoom(i));
            }
        }
    }
}
