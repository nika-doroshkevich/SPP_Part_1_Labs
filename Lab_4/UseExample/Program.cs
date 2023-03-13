using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsGenerator;

namespace UseExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await new Program().PerformAsync();
        }


        public async Task PerformAsync()
        {
            var maxFilesToLoadCount = 2;

            var maxExecuteTasksCount = 2;

            var maxFilesToWriteCount = 2;

            string sourceFolder = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Tests\\TestClasses");
            string destFolder = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Tests\\TestClasses\\GeneratedInRuntime");
            Directory.CreateDirectory(destFolder);

            await new NUnitTestsGenerator(GetSourceFiles(sourceFolder), destFolder, maxFilesToLoadCount, maxExecuteTasksCount, maxFilesToWriteCount).Generate();

            Console.WriteLine("Success");
            Console.ReadLine();
        }


        private List<string> GetSourceFiles(string sourceFolder)
        {
            var sourceFiles = new List<string>();
            foreach (string path in Directory.GetFiles(sourceFolder, "*.cs"))
            {
                sourceFiles.Add(path);
            }

            return sourceFiles;
        }
    }
}
