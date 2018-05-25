using System;

namespace chip8_emu.CPU
{
    public class Memory
    {
        #region Private Members
        private Byte[] mMemory;
        private Int16 mMemorySize;
        #endregion

        #region Constructors
        public Memory(Int16 memorySize)
        {
            mMemory = new Byte[memorySize];
            mMemorySize = memorySize;
        }
        #endregion

        #region Public Methods
        public Boolean loadRom(Byte[] rom)
        {
            // Need to check if the game can actually fit in memory first..
            if(rom.Length <= mMemorySize)
            {
                for
            }
        }
    }
}