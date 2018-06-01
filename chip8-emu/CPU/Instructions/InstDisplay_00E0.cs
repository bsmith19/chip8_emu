using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstDisplay_00E0 : IInstruction
    {

        #region Constructor
        public InstDisplay_00E0()
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