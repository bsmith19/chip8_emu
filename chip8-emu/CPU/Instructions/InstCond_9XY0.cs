using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstCond_9XY0 : Instruction
    {
        #region Constructor
        public InstCond_9XY0(ushort opcode) : base(opcode)
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