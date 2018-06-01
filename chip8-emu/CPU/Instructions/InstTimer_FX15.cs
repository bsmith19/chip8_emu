using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstTimer_FX15 : IInstruction
    {

        #region Constructor
        public InstTimer_FX15()
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