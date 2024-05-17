using Godot;
using System;

public partial class ClassAB : Node, InterfaceA, MyNamespace.InterfaceB
{
    public void SayHi()
    {
        GD.Print("Hi from ClassAB!");
    }
}
