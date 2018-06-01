using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstFlow_BNNN : IInstruction
    {

        #region Constructor
        public InstFlow_BNNN()
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