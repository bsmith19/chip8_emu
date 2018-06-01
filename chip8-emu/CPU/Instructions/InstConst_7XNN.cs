using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstConst_7XNN : Instruction
    {
        #region Constructor
        public InstConst_7XNN(ushort opcode) : base(opcode)
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