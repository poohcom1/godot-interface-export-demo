using Godot;

[GlobalClass]
public partial class ResourceB : Resource, MyNamespace.InterfaceB {
    public void SayHi() {
        GD.Print("Hi from ResourceB!");
    }
}