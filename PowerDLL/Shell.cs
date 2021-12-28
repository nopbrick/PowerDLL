using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Runspaces;


namespace PowerDLL
{
    internal class Shell
    {
        public static ICollection<PSObject> RunScript(string command)
        {
            using (var runspace = RunspaceFactory.CreateRunspace())
            {
                runspace.Open();
                using (var pipeline = runspace.CreatePipeline())
                {
                    pipeline.Commands.AddScript(command);
                    var results = pipeline.Invoke();
                    
                    return results;
                }
            }
        }

    }
}
