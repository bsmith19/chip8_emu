using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstConst_7XNN : IInstruction
    {
        #region Constructor
        public InstConst_7XNN()
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