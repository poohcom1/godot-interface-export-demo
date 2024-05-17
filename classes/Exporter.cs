using Godot;
using System;

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
}
