using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstMem_ANNN : IInstruction
    {

        #region Constructor
        public InstMem_ANNN()
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