using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstDisp_DXYN : Instruction
    {

        #region Constructor
        public InstDisp_DXYN(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            return true;
        }
        #endregion
    }
}