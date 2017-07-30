using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Dictionary<string, Clinic> Clinics = new Dictionary<string, Clinic>();

        Dictionary<string, Pet> Pets = new Dictionary<string, Pet>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            var args = input.Split();

            string clinicName;

            switch (args[0])
            {
               

                case "Create":
                    if(args[1]=="Pet")
                    {
                        Pet pet = new Pet(args[2], int.Parse(args[3]), args[4]);

                        Pets.Add(args[2], pet);
                    }

                    if (args[1] == "Clinic")
                    {
                        int num = int.Parse(args[3]);

                        if (num % 2 == 0)
                        {
                            Console.WriteLine("Invalid Operation!");
                            continue;
                        }
                        Clinic clinic = new Clinic(num);

                        Clinics.Add(args[2], clinic);
                    }


                    break;
                case "Add":
                    clinicName = args[2];

                    var petName = args[1];

                    Console.WriteLine(Clinics[clinicName].AddPet(Pets[petName]));

                    break;

                case "Release":
                    clinicName = args[1];

                    Console.WriteLine(Clinics[clinicName].Release());

                    break;

                case "HasEmptyRooms":
                    clinicName = args[1];

                    Console.WriteLine(Clinics[clinicName].HasEmptyRooms());

                    break;

                case "Print":
                    clinicName = args[1];

                    if (args.Count() == 2)
                        Clinics[clinicName].Print();
                    else
                        Clinics[clinicName].PrintRoom(int.Parse(args[2]));
                    break;
                

            }


        }


    }
}

