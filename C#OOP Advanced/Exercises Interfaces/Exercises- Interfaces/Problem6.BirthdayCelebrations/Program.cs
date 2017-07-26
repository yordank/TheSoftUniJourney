using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        List<ICitizen> listIcitizen = new List<ICitizen>();

        while(line!="End")
        {
            var tokens = line.Split();

            if(tokens[0]=="Citizen")
            {
                Citizen citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);

                listIcitizen.Add(citizen);
            }

            if(tokens[0]=="Robot")
            {
                Robot robot = new Robot(tokens[1], tokens[2]);

                listIcitizen.Add(robot);
            }

            if(tokens[0]=="Pet")
            {
                Pet pet = new Pet(tokens[1], tokens[2]);

                listIcitizen.Add(pet);
            }

            line = Console.ReadLine();
        }
        
        string year =  Console.ReadLine();
      
        foreach (var citizen in listIcitizen)
        {
            if(citizen.CheckYear(year))
            {
                
                Console.WriteLine(citizen.ToString());
            }
        }
        
    }
}

