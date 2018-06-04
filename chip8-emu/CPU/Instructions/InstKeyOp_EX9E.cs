using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstKeyOp_EX9E : Instruction
    {
        #region Constructor
        public InstKeyOp_EX9E(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Skips the next instruction if the key stored in VX is pressed. (Usually the next instruction is a jump to skip a code block)
            // TODO: Skip this until I have a solution for input
            return true;
        }
        #endregion
    }
}