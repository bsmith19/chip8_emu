using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMem_FX55 : Instruction
    {

        #region Constructor
        public InstMem_FX55(ushort opcode) : base(opcode)
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