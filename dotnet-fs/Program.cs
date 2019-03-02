﻿using McMaster.Extensions.CommandLineUtils;

namespace dotnet_fs
{
    [Command(Description = "Text file printer")]
    [Subcommand(typeof(List), typeof(Print))]
    class Program
    {
        // ...

        static int Main(string[] args)
        {
            return CommandLineApplication.Execute<Program>(args);
        }

        public int OnExecute(CommandLineApplication app, IConsole console)
        {
            console.WriteLine("You must specify a subcommand.");
            console.WriteLine();
            app.ShowHelp();
            return 1;
        }
    }
}
