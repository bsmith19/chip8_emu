using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstKeyOp_EX9E : Instruction
    {
        #region Constructor
        public InstKeyOp_EX9E(ushort opcode) : base(opcode)
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