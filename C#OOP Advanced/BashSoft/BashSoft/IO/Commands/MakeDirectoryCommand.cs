﻿using BashSoft.Contracts;
using BashSoft.Contracts.Repository;

namespace BashSoft.IO.Commands
{
    using System.Diagnostics;
    using BashSoft.Attributes;
    using Execptions;

    [Alias("mkdir")]
    public class MakeDirectoryCommand : Command
    {
        [Inject]
        private IDirectoryManager inputOutputManager;

        public MakeDirectoryCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var folderName = this.Data[1];
            inputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
}
