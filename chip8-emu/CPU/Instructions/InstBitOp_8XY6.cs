using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstBitOp_8XY6 : Instruction
    {
        #region Constructor
        public InstBitOp_8XY6(ushort opcode) : base(opcode)
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