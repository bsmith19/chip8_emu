using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstTimer_FX07 : Instruction
    {

        #region Constructor
        public InstTimer_FX07(ushort opcode) : base(opcode)
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