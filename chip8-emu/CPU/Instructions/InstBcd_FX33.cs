using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstBcd_FX33 : IInstruction
    {
        #region Constructor
        public InstBcd_FX33()
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