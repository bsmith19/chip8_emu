using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstFlow_1NNN : IInstruction
    {

        #region Constructor
        public InstFlow_1NNN()
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