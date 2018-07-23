using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace chip8_emu.GPU
{
    public class GraphicsWindow : GameWindow
    {
        #region Private Members
        private Shaders mShader;
        private Vector2[] vertices; //TODO: remove
        private Vector4[] color; //TODO: remove
        private int vbo; //TODO: remove
        private int vao; //TODO: remove
        #endregion

        #region Constructors
        public GraphicsWindow(int width, int height)
            : base(width, height)
        {
            this.Title = "Chip8_Emulator - OpenGL Ver: " + GL.GetString(StringName.Version) + " FPS: " + this.RenderFrequency;
            this.mShader = new Shaders();
        }
        #endregion

        #region Overriden Event Handlers
        override protected void OnResize(System.EventArgs e)
        {
            // base class
            base.OnResize(e);

            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);
        }
        override protected void OnLoad(System.EventArgs e)
        {
            // Callback on initial window loading
            // Build the shaders...
            this.mShader.BuildFragmentShader();
            this.mShader.BuildVertexShader();
            this.mShader.LinkProgram();

            //Clear the screen with blue..
            GL.ClearColor(Color.CornflowerBlue);

            // pass the event to the base class
            base.OnLoad(e);

            //TEMP build vertex vector
            vertices = new Vector2[6]
            {
                new Vector2(0, 0),
                new Vector2(100, 0),
                new Vector2(100,100),
                new Vector2(0,0),
                new Vector2(100, 100),
                new Vector2(0, 100)
            };
            color = new Vector4[6]
            {
                new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
            };
            vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);

            vao = GL.GenVertexArray();
            GL.BindVertexArray(vao);
            GL.EnableVertexAttribArray(0);
            GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, (System.IntPtr)(Vector2.SizeInBytes * vertices.Length), vertices, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, 0, 0);
        }
        override protected void OnUpdateFrame(FrameEventArgs e)
        {
            // Update stuff per frame like keyboards
        }
        override protected void OnRenderFrame(FrameEventArgs e)
        {
            // pass event to the base class
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            //Set the program/shaders
            mShader.UseProgram();

            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

            // Swap to the buffer we just drew
            SwapBuffers();
        }
        #endregion
    }
}