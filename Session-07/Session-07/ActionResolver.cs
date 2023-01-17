using System;


public enum ActionEnum
{
    Convert,
    Uppercase,
    Reverse
}

public class ActionResolver
{
    //Properties
    public MessageLogger Logger { get; set; }

    //Methods
    public void Execute()
    {
    }
}
