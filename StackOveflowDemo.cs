using BenchmarkDotNet.Attributes;

namespace stack_overflow
{
    public class StackOverflowDemo
    {
        [Benchmark]
        public void ThrowStackOverflowViaCLR()
        {
            try
            {
                MakeInfiniteRecursion(1);
            }
            catch(StackOverflowException exe)
            {
                // Won't work. Only if the host env will specifically allow stack overflow exception to be handled.
                Console.WriteLine(exe);
            }
        }

        public void ThrowStackOveflowViaCode()
        {
            try
            {
                throw new StackOverflowException("Its me, stack oveflow exception!");
            }
            catch(StackOverflowException exe)
            {
                // This works.
                Console.WriteLine(exe);
            }
        }

        private void MakeInfiniteRecursion(int x)
        {
            Console.WriteLine(x);
            MakeInfiniteRecursion(++x);
        }
    }
}
