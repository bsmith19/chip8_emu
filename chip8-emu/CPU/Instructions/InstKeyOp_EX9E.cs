using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstKeyOp_EX9E : IInstruction
    {
        #region Constructor
        public InstKeyOp_EX9E()
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