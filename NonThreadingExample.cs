using System.Diagnostics;

namespace ThreadingExample;

public class NonThreadingExample
{
    //our nonthreading work will go here
    
    //files we will work with
    public List<string> Files { get; set; } = FileProcessoratorHandler.GetAllFiles();

    public void DoWork()
    {
        //starts the stopwatch timer
        var watch = Stopwatch.StartNew();
        foreach (var file in Files)
        {
            ProcessFile(file);
        }
        watch.Stop();
        Console.WriteLine($"To process all files, it took: {watch.ElapsedMilliseconds} ms");
    }

    private void ProcessFile(string file)
    {
        FileProcessoratorHandler.ProcessFile(file);
    }
}