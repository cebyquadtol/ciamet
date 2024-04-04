using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Start the process with the given command
        using (var process = Process.Start("python3", "pylot.py"))
        {
            if (process != null)
            {
                // Wait for the process to exit to ensure completion
                process.WaitForExit();

                // Read the output of the script if necessary
                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Failed to start the process.");
            }
        }
    }
}
