# UserInputTest

## Info
User interface contains two types of user input controls: <br/>
TextInput, which accepts all characters<br/>
NumericInput, which accepts only digits.

## Goal
Implement the class TextInput that contains:<br/>

* Public method void Add(char c) - adds the given character to the current value
* Public method string GetValue() - returns the current value

Implement the class NumericInput that:<br/>

* Inherits TextInput
* Overrides the Add method so that each non-numeric character is ignored

### Given Code
```C#
using System;

public class TextInput {}

public class NumericInput {}

public class UserInput
{
    public static void Main(string[] args)
    {
        //TextInput input = new NumericInput();
        //input.Add('1');
        //input.Add('a');
        //input.Add('0');
        //Console.WriteLine(input.GetValue());
    }
}
```


### For example, the following code should output "10":

```C#
TextInput input = new NumericInput();
input.Add('1');
input.Add('a');
input.Add('0');
Console.WriteLine(input.GetValue());
```
