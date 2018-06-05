using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace chip8_emu.GPU
{
    public class GraphicsWindow : GameWindow
    {
        #region Private Members
        private Shaders mShader;
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
            // Window is Resized
        }
        override protected void OnLoad(System.EventArgs e)
        {
            // Callback on initial window loading
            // Build the shaders...
            this.mShader.BuildFragmentShader();
            this.mShader.BuildVertexShader();
            this.mShader.LinkProgram();
        }
        override protected void OnUpdateFrame(FrameEventArgs e)
        {
            // Update stuff per frame like keyboards
        }
        override protected void OnRenderFrame(FrameEventArgs e)
        {
            //Clear the screen with blue..
            GL.ClearColor(Color.CornflowerBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            //Set the program/shaders
            mShader.UseProgram();

            GL.DrawArrays(PrimitiveType.Points, 0, 1);
            GL.PointSize(10);

            // Swap to the buffer we just drew
            SwapBuffers();
        }
        #endregion
    }
}