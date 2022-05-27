# Introduction
Just looking into StackOveflow exception. I just was curious whether actually 1mb of stack per thread can be not enough nowdays.

# Points
You can't really handle StackOveflow using managed approach (delegating this to the CLR).  
But, ```only when it is called from OS```. In case if you throw the exception by yourself (via code) you can actually handle it in try-catch block.  

Also I was wondering whether we can change the stack size, but personally I do not see when I will need it.  
```https://stackoverflow.com/questions/54584224/is-there-a-way-to-increase-the-stack-size-in-c```  
```https://stackoverflow.com/questions/42059878/1-mb-stack-size-limit-enforced-by-the-clr-is-for-a-thread-or-the-entire-applicat```