using Godot;

public partial class Caller : Node
{
    [Export(PropertyHint.Interface)]
    public Node classA;
}
