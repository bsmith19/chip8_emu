using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstBitOp_8XY2 : IInstruction
    {
        #region Constructor
        public InstBitOp_8XY2()
        {
        }
        #endregion

        #region Overrides
        public Boolean Handle(Memory memory, Stack stack)
        {
            return true;
        }
        #endregion
    }
}