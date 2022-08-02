using System.Diagnostics;

namespace ThreadingExample;

public class DoTheThingsWithMultiThreading
//add chaos
{
    public List<string> Files { get; set; } = FileProcessoratorHandler.GetAllFiles();

    public void DoWork()
    {
        List<Thread> threads = new List<Thread>();
        var watch = Stopwatch.StartNew();
        foreach (var file in Files)
        {
            ThreadStart threadStart = (() => { ProcessFile(file); });
            var thread = new Thread(threadStart);
            thread.Start();
            threads.Add(thread);
        }
        //wait and join all threads for stopwatch
        threads.ForEach(thread => thread.Join());
        watch.Stop();
        Console.WriteLine($"To process all files, it took: {watch.ElapsedMilliseconds} ms");
    }

    private void ProcessFile(string file)
    {
        FileProcessoratorHandler.ProcessFile(file);
    }
}