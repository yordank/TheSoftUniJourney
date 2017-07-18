﻿namespace BashSoft
{
    public class Launcher
    {
        static void Main()
        {
            Tester tester = new Tester();

            IOManager ioManager = new IOManager();

            StudentsRepository repo = new StudentsRepository(new RepositoryFilters(),new RepositorySorters());

            CommandInterpreter currentInterpreter = new CommandInterpreter(tester, repo, ioManager);

            InputReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}
