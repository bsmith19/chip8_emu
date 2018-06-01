using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstConst_6XNN : IInstruction
    {
        #region Constructor
        public InstConst_6XNN()
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