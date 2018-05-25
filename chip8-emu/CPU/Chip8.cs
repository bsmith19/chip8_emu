using System;

namespace chip8_emu.CPU
{
    public class Chip8
    {
        #region Private Properties
        private Stack Stack { get; set; }
        private Memory Memory { get; set; }
        #endregion

        #region Private Members
        private Byte[] mCpuRegisters;
        private ushort mProgramCounter;
        private ushort mIndexRegister;
        #endregion

        #region Timers
        private Byte soundTimer;
        private Byte delayTimer;
        #endregion

        #region Constructors
        public Chip8()
        {
            mProgramCounter = 0x200;
            mIndexRegister = 0;
        }
        #endregion
    }
}