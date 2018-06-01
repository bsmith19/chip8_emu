using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstSound_FX18 : IInstruction
    {

        #region Constructor
        public InstSound_FX18()
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