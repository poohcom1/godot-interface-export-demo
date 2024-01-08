using Godot;

[GlobalClass]
public partial class ResourceA : Resource, InterfaceA {
    [Export]
    public string name = "ResourceA";    

    public void SayHi() {
        GD.Print($"Hi from {name}!");
    }
}