static void MakeInfiniteRecursion(int x)
{
    Console.WriteLine(x);
    MakeInfiniteRecursion(++x);
}


static void ThrowStackOverflowViaCLR()
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

static void ThrowStackOveflowViaCode()
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

ThrowStackOveflowViaCode();

