using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandAPI.Models;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandeAPIRepo
    {
        private List<Command> commands = new List<Command>
        {
            new Command
            {
                Id = 1,
                HowTo = "How to generate a migration.",
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                Platform = ".NET Core EF",
            },
            new Command
            {
                Id = 2,
                HowTo = "Run Migrations",
                CommandLine = "dotnet ef database update",
                Platform = ".NET Core EF",
            },
            new Command
            {
                Id = 3,
                HowTo = "List active migrations",
                CommandLine = "dotnet ef migrations list",
                Platform = ".NET Core EF"
            },
            new Command
            {
                Id = 3,
                HowTo = "List Aneudy's age",
                CommandLine = "Aneudy is 31 years old",
                Platform = ".NET Core EF"
            }
        };

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return commands;
        }

        public Command GetCommandById(int id)
        {
            foreach (var command in commands)
            {
                if (command.Id == id)
                {
                    return command;
                }
            }

            return null;
        }

        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
