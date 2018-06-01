using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstKeyOp_EXA1 : Instruction
    {

        #region Constructor
        public InstKeyOp_EXA1(ushort opcode) : base(opcode)
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