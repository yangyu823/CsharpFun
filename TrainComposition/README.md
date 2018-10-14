# TrainComposition

## Info
A TrainComposition is built by attaching and detaching wagons from the left and the right sides.

For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13,<br/>
again from the left, we get a composition of two wagons (13 and 7 from left to right).<br/>
Now the first wagon that can be detached from the right is 7 <br/>
and the first that can be detached from the left is 13.<br/>

![Image of Yaktocat](https://www.testdome.com/Files/Resources/12362/da06e51d-f8c1-4e10-bb01-2832bd040824.png)<br/>

Implement a TrainComposition that models this problem.

### Given Code

```C#
using System;

public class TrainComposition
{
    public void AttachWagonFromLeft(int wagonId)
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public void AttachWagonFromRight(int wagonId)
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public int DetachWagonFromLeft()
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public int DetachWagonFromRight()
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public static void Main(string[] args)
    {
        TrainComposition tree = new TrainComposition();
        tree.AttachWagonFromLeft(7);
        tree.AttachWagonFromLeft(13);
        Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        Console.WriteLine(tree.DetachWagonFromLeft()); // 13
    }
}
```
