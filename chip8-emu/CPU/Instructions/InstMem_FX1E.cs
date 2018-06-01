using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMem_FX1E : Instruction
    {

        #region Constructor
        public InstMem_FX1E(ushort opcode) : base(opcode)
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