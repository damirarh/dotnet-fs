using McMaster.Extensions.CommandLineUtils;
using System;
using System.IO;

namespace dotnet_fs
{
    [Command(Description = "Lists files and folders.")]
    class List
    {
        [Option(Description = "Folder path.")]
        public string Path { get; } = ".";

        private void OnExecute(IConsole console)
        {
            try
            {
                var dir = new DirectoryInfo(Path);

                foreach (var subdir in dir.GetDirectories())
                {
                    console.WriteLine($"{subdir.Name} (DIR)");
                }

                foreach (var file in dir.GetFiles())
                {
                    console.WriteLine($"{file.Name}");
                }
            }
            catch (Exception e)
            {
                console.WriteLine(e.Message);
            }
        }
    }
}
