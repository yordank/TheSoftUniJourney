using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Inferno_III
{
    class Program
    {
         
        class Command
        {
            public string Type { get; set; }
            public string Parametar { get; set; }

            public override string ToString()
            {
                return this.Type + " " + this.Parametar;
            }

        }
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool[] filteredNumbers = new bool[numbers.Count];

            var input = Console.ReadLine();

            List<Command> commands = new List<Command>();

            Func<int, int, int> sumLeft = (x, y) => x + y;
            Func<int, int, int> sumRight = (x, y) => x + y;
            Func<int, int, int, int> sumLeftRight = (x, y, z) => x + y + z;

            InputCommands(input, commands);

            foreach (var command in commands)
            {
                
                var operation = command.Type;
                var count = int.Parse(command.Parametar);

                
                 

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        var currentNumber = numbers[i];
                     
                        var previousNumber = 0;
                        previousNumber = i == 0 ? 0 : numbers[i - 1];
                     
                        var nextNumber = 0;
                        nextNumber = i == numbers.Count - 1 ? 0 : numbers[i + 1];

                        switch (operation)
                        {
                            case "Sum Left":
                                if (sumLeft(currentNumber, previousNumber) == count)
                                {
                                filteredNumbers[i] = true; 
                                }
                                break;
                            case "Sum Right":
                                if (sumRight(currentNumber, nextNumber) == count)
                                {
                                filteredNumbers[i] = true; 
                            }
                                break;
                            case "Sum Left Right":
                                if (sumLeftRight(currentNumber, previousNumber, nextNumber) == count)
                                {
                                filteredNumbers[i] = true; 
                            }
                                break;
                        }
                    }
                   
                

                     
                

            }

            for (int i = 0; i < filteredNumbers.Length; i++)
            {
                if(!filteredNumbers[i])
                    Console.Write(numbers[i]+" ");
            }

        }

        private static void InputCommands(string input, List<Command> commands)
        {
            while (input != "Forge")
            {
                if (input.Split(';')[0] == "Exclude")
                {
                    Command cmd = new Command()
                    {
                        Type = input.Split(';')[1],

                        Parametar = input.Split(';')[2]

                    };
                    commands.Add(cmd);
                }

                if (input.Split(';')[0] == "Reverse")
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
