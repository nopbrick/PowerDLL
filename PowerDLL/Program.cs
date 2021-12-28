using System;


namespace PowerDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var script = string.Join(" ", args);
            var results = Shell.RunScript(script);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
