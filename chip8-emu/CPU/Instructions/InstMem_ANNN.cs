using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMem_ANNN : Instruction
    {

        #region Constructor
        public InstMem_ANNN(ushort opcode) : base(opcode)
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