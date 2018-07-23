using System;
using System.Runtime.InteropServices;

using OpenTK;
using OpenTK.Graphics.OpenGL4;

public class VertexBuffer
{
    private Vertex[] mBuffer;
    private Int32 mHandle;
    private Int32 mBufferSize;

    public VertexBuffer(Int32 bufferSize)
    {
        this.mBufferSize = bufferSize;
        this.mBuffer = new Vertex[this.mBufferSize];
        this.mHandle = GL.GenBuffer();
    }

    public void Bind()
    {
        GL.BindBuffer(BufferTarget.ArrayBuffer, this.mHandle);
    }
    public void SetBufferData()
    {
        Int32 vertexSize = Marshal.SizeOf(typeof(Vertex));
        GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(vertexSize * this.mBufferSize), this.mBuffer, BufferUsageHint.StreamDraw);
    }
    public void DrawBuffer()
    {
        GL.DrawArrays(PrimitiveType.Triangles, 0, this.mBufferSize);
    }
}