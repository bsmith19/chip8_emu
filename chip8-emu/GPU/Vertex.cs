using System;
using OpenTK;

public struct Vertex
{
    public Int32 Size { get {return (3 + 4) * 4; } }

    private Vector3 mPosition;
    private Color mColor;

    public Vertex(Vector3 pos, Color color)
    {
        mPosition = pos;
        mColor = color;
    }
}