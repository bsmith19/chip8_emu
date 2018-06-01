using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstTimer_FX07 : IInstruction
    {

        #region Constructor
        public InstTimer_FX07()
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