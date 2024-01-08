using Godot;
using System;

public partial class ClassA : Node, InterfaceA {
    public void SayHi() {
        GD.Print("Hi from ClassA!");
    }
}
