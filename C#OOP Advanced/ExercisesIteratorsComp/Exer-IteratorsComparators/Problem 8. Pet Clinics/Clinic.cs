using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Clinic : IEnumerable<int>
{
    public Clinic(int n)
    {
        this.Rooms = new List<Pet>(n);

        for (int i = 0; i < n; i++)
        {
            Rooms.Add(new Pet());
        }
    }

    public List<Pet> Rooms { get; set; }
    public int Index { get; set; }

    public bool AddPet(Pet pet)
    {
        foreach (var index in this)
        {
            if (Rooms[index].Name == "TEST")
            {
                Rooms[index] = pet;

                return true;
            }
        }

        return false;


    }

    public void PrintRoom(int num)
    {
        if(Rooms[num-1].Name=="TEST")
            Console.WriteLine("Room empty");
        else
            Console.WriteLine(Rooms[num-1].ToString());


    }
    public bool HasEmptyRooms()
    {
        foreach (var index in this)
        {
            if (Rooms[index].Name == "TEST")
                return true;
        }

        return false;
    }

    public bool Release()
    {
        int startIndex= Rooms.Count / 2;

        for (int i = 0; i < Rooms.Count; i++)
        {
            if(Rooms[(startIndex+i)%Rooms.Count].Name!="TEST")
            {
                Rooms[(startIndex + i) % Rooms.Count] = new Pet();
                return true;
            }

         }

        return false;


    }
    public IEnumerator<int> GetEnumerator()
    {
        yield return Rooms.Count / 2;

        for (int i =  1; i <=Rooms.Count /2; i++)
        {
            yield return Rooms.Count / 2 - i;
            yield return Rooms.Count / 2 + i;

        }


    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void Print()
    {
        foreach (var room in this.Rooms)
        {
            if(room.Name=="TEST")
            {
                Console.WriteLine("Room empty");
            }
            else
                Console.WriteLine(room.ToString());
        }
    }
}

