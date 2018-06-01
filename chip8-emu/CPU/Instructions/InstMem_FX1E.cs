using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstMem_FX1E : IInstruction
    {

        #region Constructor
        public InstMem_FX1E()
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