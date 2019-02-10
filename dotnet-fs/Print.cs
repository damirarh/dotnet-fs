using McMaster.Extensions.CommandLineUtils;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace dotnet_fs
{
    [Command(Description = "Prints out contents of a file.")]
    class Print
    {
        [Required]
        [Option(Description = "Required. File path.")]
        public string Path { get; }

        private void OnExecute(IConsole console)
        {
            try
            {
                var contents = File.ReadAllText(Path);
                console.WriteLine(contents);
            }
            catch (Exception e)
            {
                console.WriteLine(e.Message);
            }
        }
    }
}
