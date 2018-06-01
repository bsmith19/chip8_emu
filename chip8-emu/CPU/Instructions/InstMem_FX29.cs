using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMem_FX29 : Instruction
    {

        #region Constructor
        public InstMem_FX29(ushort opcode) : base(opcode)
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