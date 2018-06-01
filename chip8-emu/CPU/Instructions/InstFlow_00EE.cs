using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstFlow_00EE : IInstruction
    {
        #region Constructor
        public InstFlow_00EE()
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