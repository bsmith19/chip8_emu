using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstCond_4XNN : IInstruction
    {

        #region Constructor
        public InstCond_4XNN()
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