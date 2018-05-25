using System;

namespace chip8_emu.CPU
{
    public class Stack
    {
        #region Private Members
        private ushort[] mStack;
        private ushort mStackPointer;
        #endregion
        
        #region Constructors
        public Stack(Int16 stackSize)
        {
            mStack = new ushort[stackSize];
            mStackPointer = 0x0;
        }
        #endregion

        #region Public Methods
        #endregion
    }
}