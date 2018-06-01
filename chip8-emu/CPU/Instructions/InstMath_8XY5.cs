using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMath_8XY5 : Instruction
    {

        #region Constructor
        public InstMath_8XY5(ushort opcode) : base(opcode)
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