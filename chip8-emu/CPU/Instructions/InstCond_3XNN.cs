using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstCond_3XNN : IInstruction
    {

        #region Constructor
        public InstCond_3XNN()
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