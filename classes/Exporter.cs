using Godot;
using System;

public class TestA : InterfaceA
{
    public void SayHi()
    {
        GD.Print("Hi from TestA!");
    }
}

public partial class Exporter : Node
{
    [Export]
    public InterfaceA interfaceAExport;

    [Export]
    public MyNamespace.InterfaceB interfaceBExport;

    [Export]
    public ResourceExporter resourceExporterExport;

    public override void _Ready()
    {
        interfaceAExport?.SayHi();
    }

    public void SayHi()
    {
        //interfaceExample.SayHi();
    }
}
