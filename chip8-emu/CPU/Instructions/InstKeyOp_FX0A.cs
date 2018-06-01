using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstKeyOp_FX0A : IInstruction
    {

        #region Constructor
        public InstKeyOp_FX0A()
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