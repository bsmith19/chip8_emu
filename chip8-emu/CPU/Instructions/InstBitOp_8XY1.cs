using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstBitOp_8XY1 : Instruction
    {

        #region Constructor
        public InstBitOp_8XY1(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            //Sets VX to VX or VY. (Bitwise OR operation)
            systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] = (Byte)(systemData.CpuRegisters[(mOpCode & 0x00F0) >> 4] | systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8]);

            //Jump to next Instr
            systemData.ProgramCounter += 2;

            return true;
        }
        #endregion
    }
}