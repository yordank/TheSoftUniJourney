﻿using BashSoft.Contracts;
using BashSoft.Contracts.Repository;

namespace BashSoft.IO.Commands
{
    using Execptions;

    public class ReadDatabaseFromFileCommand : Command
    {
        public ReadDatabaseFromFileCommand(string input, string[] data, IContentComparer judge, IDatabase repository,
            IDirectoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager) { }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var databasePath = this.Data[1];
            this.Repository.LoadData(databasePath);
        }
    }
}
