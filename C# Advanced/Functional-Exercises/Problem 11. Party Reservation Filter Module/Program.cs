using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Party_Reservation_Filter_Module
{
    class Program
    {
        class Command
        {
            public string Type { get; set; }
            public string Parametar { get; set; }

          

        }
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();

            var input = Console.ReadLine();

            List<Command> commands = new List<Command>();

            InputCommands(input, commands);

            foreach (var command in commands)
            {
                if (command.Type == "Starts with")
                {
                    names.RemoveAll(elem => names.Where(x => x.StartsWith(command.Parametar)).ToList().Contains(elem));

                }
                if (command.Type == "Length")
                {
                    names.RemoveAll(elem => names.Where(x => x.Length == int.Parse(command.Parametar)).Contains(elem));

                }

                if (command.Type == "Ends with")
                {
                    names.RemoveAll(elem => names.Where(x => x.EndsWith(command.Parametar)).ToList().Contains(elem));

                }
                if (command.Type == "Contains")
                {
                    names.RemoveAll(elem => names.Where(x => x.Contains(command.Parametar)).ToList().Contains(elem));

                }
            }

            Console.WriteLine($"{string.Join(" ", names)}");

        }

        private static void InputCommands(string input, List<Command> commands)
        {
            while (input != "Print")
            {
                if (input.Split(';')[0] == "Add filter")
                {
                    Command cmd = new Command()
                    {
                        Type = input.Split(';')[1],
                        Parametar = input.Split(';')[2]
                    };
                    commands.Add(cmd);
                }

                if (input.Split(';')[0] == "Remove filter")
                {
                    string type = input.Split(';')[1];
                    string parametar = input.Split(';')[2];

                    Command cmd = commands.Where(x => x.Type == type && x.Parametar == parametar).FirstOrDefault();
                    commands.Remove(cmd);
                }

                input = Console.ReadLine();
            }

           
        }
    }
}
