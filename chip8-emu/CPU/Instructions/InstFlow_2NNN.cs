using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstFlow_2NNN : IInstruction
    {

        #region Constructor
        public InstFlow_2NNN()
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