using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstKeyOp_FX0A : Instruction
    {

        #region Constructor
        public InstKeyOp_FX0A(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // A key press is awaited, and then stored in VX. (Blocking Operation. All instruction halted until next key event).
            return true;
        }
        #endregion
    }
}