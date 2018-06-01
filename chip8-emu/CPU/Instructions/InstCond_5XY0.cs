using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstCond_5XY0 : IInstruction
    {
        #region Constructor
        public InstCond_5XY0()
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