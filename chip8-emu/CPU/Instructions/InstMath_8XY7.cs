using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstMath_8XY7 : IInstruction
    {

        #region Constructor
        public InstMath_8XY7()
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