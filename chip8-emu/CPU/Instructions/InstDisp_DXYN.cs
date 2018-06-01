using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstDisp_DXYN : IInstruction
    {

        #region Constructor
        public InstDisp_DXYN()
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