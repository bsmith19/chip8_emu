using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstKeyOp_EXA1 : Instruction
    {

        #region Constructor
        public InstKeyOp_EXA1(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            //  the next instruction if the key stored in VX isn't pressed. (Usually the next instruction is a jump to skip a code block)
            // TODO: comeback to this once input is figured out
            return true;
        }
        #endregion
    }
}