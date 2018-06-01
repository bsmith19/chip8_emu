using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstBitOp_8XYE : IInstruction
    {

        #region Constructor
        public InstBitOp_8XYE()
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