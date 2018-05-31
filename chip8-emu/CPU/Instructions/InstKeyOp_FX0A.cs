using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstKeyOp_FX0A : IInstruction
    {
        #region Private Vars
        private Memory mMemory;
        private Stack mStack;
        #endregion

        #region Constructor
        public InstKeyOp_FX0A(Memory memory, Stack stack)
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