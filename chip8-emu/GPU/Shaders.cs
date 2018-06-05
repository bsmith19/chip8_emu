using OpenTK;
using OpenTK.Graphics.OpenGL4;
using System.IO;
using System.Reflection;

namespace chip8_emu.GPU
{
    public class Shaders
    {
        #region Private Vars
        private int mVertexShader;
        private int mFragmentShader;
        private int mProgram;
        #endregion

        #region Constructors
        public Shaders()
        {
            mProgram = GL.CreateProgram();
        }
        #endregion

        #region Public Methods
        public void BuildVertexShader()
        {
            // Load the shared resource
            Assembly assembly = typeof(chip8_emu.GPU.Shaders).Assembly;
            Stream shaderFile = assembly.GetManifestResourceStream("chip8-emu.Resources.vertShader.vert");

            //parser the stream
            StreamReader shaderReader = new StreamReader(shaderFile);

            //Build Shader
            mVertexShader = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(mVertexShader, shaderReader.ReadToEnd());
            GL.CompileShader(mVertexShader);

            //Link to program
            GL.AttachShader(mProgram, mVertexShader);
        }
        public void BuildFragmentShader()
        {
            // Load the shared resource
            Assembly assembly = typeof(chip8_emu.GPU.Shaders).Assembly;
            Stream shaderFile = assembly.GetManifestResourceStream("chip8-emu.Resources.fragShader.frag");

            //parser the stream
            StreamReader shaderReader = new StreamReader(shaderFile);

            //Build shader
            mFragmentShader = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(mFragmentShader, shaderReader.ReadToEnd());
            GL.CompileShader(mFragmentShader);

            //Link to program
            GL.AttachShader(mProgram, mFragmentShader);
        }
        public void LinkProgram()
        {
            //Link the current state of the shader
            GL.LinkProgram(mProgram);

            //Cleanup any shaders
            CleanupShaders();
        }
        public void UseProgram()
        {
            GL.UseProgram(mProgram);
        }
        public void CleanupProgram()
        {
            GL.DeleteProgram(mProgram);
        }
        #endregion

        #region Private Methods
        private void CleanupShaders()
        {
            //Detach
            GL.DetachShader(mProgram, mVertexShader);
            GL.DetachShader(mProgram, mFragmentShader);

            //Delete
            GL.DeleteBuffer(mVertexShader);
            GL.DeleteBuffer(mFragmentShader);
        }
        #endregion
    }
}