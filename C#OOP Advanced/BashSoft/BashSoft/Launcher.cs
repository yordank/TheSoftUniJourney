using BashSoft.Contracts;

namespace BashSoft
{
    using BashSoft.Contracts.Repository;

    public class Launcher
    {
        public static void Main()
        {
            IContentComparer tester = new Tester();
            IDirectoryManager ioManager = new IOManager();
            IDatabase repo = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());

            IInterpreter currentInterpreter = new CommandInterpreter(tester, repo, ioManager);
            IReader reader =  new InputReader(currentInterpreter);

            reader.StartReadingCommands();

            //test github 1912
        }
    }
}
