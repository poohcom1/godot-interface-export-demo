using Godot;
using System;
using TestNamespace;

[Tool]
public partial class ClassA : Node, TestNamespace.InterfaceA
{
    [Export]
    public Node nodeExample;

    [Export]
    public Resource resExample;

    [Export]
    public InterfaceA interfaceExample;

    public override void _Ready()
    {
        base._Ready();
        interfaceExample = (InterfaceA)Godot.NativeInterop.VariantUtils.ConvertTo<GodotObject>(new Godot.NativeInterop.godot_variant());
    }
}
