using BenchmarkDotNet.Running;
using stack_overflow;

// BenchmarkRunner.Run<StackOverflowDemo>();

const int oneMbInBytes = 1000000;

//   maxStackSize:
//     The maximum stack size, in bytes, to be used by the thread, or 0 to use the default
//     maximum stack size specified in the header for the executable. Important For
//     partially trusted code, maxStackSize is ignored if it is greater than the default
//     stack size. No exception is thrown.
var myTinyThread = new Thread(new ThreadStart(() => { Task.Delay(10000000); }), oneMbInBytes * 10);
myTinyThread.IsBackground = false;
myTinyThread.Start();