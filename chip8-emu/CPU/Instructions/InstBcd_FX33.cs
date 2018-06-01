using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstBcd_FX33 : Instruction
    {
        #region Constructor
        public InstBcd_FX33(ushort opcode) : base(opcode)
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