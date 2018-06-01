using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstSound_FX18 : Instruction
    {

        #region Constructor
        public InstSound_FX18(ushort opcode) : base(opcode)
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