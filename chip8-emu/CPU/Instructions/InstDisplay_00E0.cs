using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstDisplay_00E0 : Instruction
    {

        #region Constructor
        public InstDisplay_00E0(ushort opcode) : base(opcode)
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