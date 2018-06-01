using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstAssign_8XY0 : Instruction
    {
        #region Constructor
        public InstAssign_8XY0(ushort opcode) : base(opcode)
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