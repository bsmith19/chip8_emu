using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstRand_CXNN : Instruction
    {

        #region Constructor
        public InstRand_CXNN(ushort opcode) : base(opcode)
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