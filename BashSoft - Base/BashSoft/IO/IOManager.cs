﻿using BashSoft.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public  class IOManager
    {
        public void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = SessionData.currentPath.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(SessionData.currentPath);

            while (subFolders.Count != 0)
            {
                string currentPath = subFolders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdentation;

                if (depth - identation < 0)
                {
                    break;
                }

                try
                {
                    foreach (var directoryPath in Directory.GetDirectories(currentPath))
                    {
                        subFolders.Enqueue(directoryPath);
                    }

                    OutputWriter.WriteMessageOnNewLine(string.Format("{0}{1}", new string('-', identation), currentPath));

                    foreach (var file in Directory.GetFiles(SessionData.currentPath))
                    {
                        int indexOfLastSlash = file.LastIndexOf("\\");
                        string fileName = file.Substring(indexOfLastSlash);
                        OutputWriter.WriteMessageOnNewLine(new string('-', indexOfLastSlash) + fileName);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    OutputWriter.WriteMessageOnNewLine(ExceptionMessages.UnauthorizedExceptionMessage);
                }
            }
        }

        public void CreateDirectoryInCurrentFolder(string name)
        {
            string path = SessionData.currentPath + "\\" + name;
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (ArgumentException)
            {
                //  throw new ArgumentException(ExceptionMessages.ForbiddenSymbolsContainedInName);
                throw new InvalidFileNameException();
            }
        }

        public void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                try
                {
                    string currentPath = SessionData.currentPath;
                    int indexOfLastSlash = currentPath.LastIndexOf("\\");
                    string newPath = currentPath.Substring(0, indexOfLastSlash);
                    SessionData.currentPath = newPath;
                }
                catch (ArgumentOutOfRangeException)
                {
                    //throw new ArgumentOutOfRangeException("indexOfLastSlash", ExceptionMessages.InvalidPath);
                    // OutputWriter.WriteMessageOnNewLine(ExceptionMessages.UnableToGoHigherInParitionHierarchy);

                    throw new InvalidPathException();
                }
            }
            else
            {
                string currenPath = SessionData.currentPath;
                currenPath += "\\" + relativePath;
                SessionData.currentPath = currenPath;
            }
        }

        public void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                // throw new DirectoryNotFoundException( ExceptionMessages.InvalidPath);
                // return;

                throw new InvalidPathException();

            }

            SessionData.currentPath = absolutePath;
        }
    }
}
