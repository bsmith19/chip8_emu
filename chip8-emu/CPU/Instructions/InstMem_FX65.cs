using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMem_FX65 : Instruction
    {

        #region Constructor
        public InstMem_FX65(ushort opcode) : base(opcode)
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