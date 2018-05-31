using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstMem_FX55 : IInstruction
    {
        #region Private Vars
        private Memory mMemory;
        private Stack mStack;
        #endregion

        #region Constructor
        public InstMem_FX55(Memory memory, Stack stack)
        {
            this.mMemory = memory;
            this.mStack = stack;
        }
        #endregion

        #region Overrides
        public Boolean Handle(Memory memory)
        {
            return true;
        }
        #endregion
    }
}