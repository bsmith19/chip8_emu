using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstRand_CXNN : IInstruction
    {

        #region Constructor
        public InstRand_CXNN()
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