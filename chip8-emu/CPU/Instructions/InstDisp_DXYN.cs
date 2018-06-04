using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstDisp_DXYN : Instruction
    {

        #region Constructor
        public InstDisp_DXYN(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Draws a sprite at coordinate (VX, VY) that has a width of 8 pixels and a height of N pixels. 
            // Each row of 8 pixels is read as bit-coded starting from memory location I; I value doesn’t change after the execution of this instruction. 
            // As described above, VF is set to 1 if any screen pixels are flipped from set to unset when the sprite is drawn, and to 0 if that doesn’t happen
            // TODO: Must implement this after I have a solution to drawing
            return true;
        }
        #endregion
    }
}