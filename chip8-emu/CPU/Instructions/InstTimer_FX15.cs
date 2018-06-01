using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstTimer_FX15 : Instruction
    {

        #region Constructor
        public InstTimer_FX15(ushort opcode) : base(opcode)
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