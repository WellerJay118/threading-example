using System.Diagnostics;

namespace ThreadingExample;

public class DoTheThingsWithMultiThreading
//add chaos
{
    public List<string> Files { get; set; } = FileProcessoratorHandler.GetAllFiles();

    public void DoWork()
    {
        List<Thread> threads = new List<Thread>();
        //starts the stopwatch timer
        var watch = Stopwatch.StartNew();
        foreach (var file in Files)
        {
            //take each file, process it with a thread of its own instead of ProcessFile(file)
            //each thread processes a file of its own, one thread gets one file
        }
        watch.Stop();
        Console.WriteLine($"To process all files, it took: {watch.ElapsedMilliseconds} ms");
    }

    private void ProcessFile(string file)
    {
        FileProcessoratorHandler.ProcessFile(file);
    }
}