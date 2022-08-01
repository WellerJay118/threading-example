using ThreadingExample;

FileProcessoratorHandler.CreateTestFiles(10, 1000);

var nonThreadingExample = new NonThreadingExample();
nonThreadingExample.DoWork();

var threadingExample = new DoTheThingsWithMultiThreading();