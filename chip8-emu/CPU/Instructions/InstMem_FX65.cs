using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstMem_FX65 : IInstruction
    {

        #region Constructor
        public InstMem_FX65()
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