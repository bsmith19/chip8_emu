using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstBitOp_8XY3 : IInstruction
    {
        #region Constructor
        public InstBitOp_8XY3()
        {
        }
        #endregion

        #region Overrides
        public Boolean Handle(CPUData systemData)
        {
            return true;
        }
        #endregion
    }
}