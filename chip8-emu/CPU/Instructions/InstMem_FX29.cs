using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMem_FX29 : Instruction
    {

        #region Constructor
        public InstMem_FX29(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Sets I to the location of the sprite for the character in VX. Characters 0-F (in hexadecimal) are represented by a 4x5 font.
            systemData.IndexRegister = (ushort)(systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] * 0x5);
            systemData.ProgramCounter += 2;

            return true;
        }
        #endregion
    }
}