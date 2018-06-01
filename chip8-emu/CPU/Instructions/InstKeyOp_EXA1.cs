using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstKeyOp_EXA1 : IInstruction
    {

        #region Constructor
        public InstKeyOp_EXA1()
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