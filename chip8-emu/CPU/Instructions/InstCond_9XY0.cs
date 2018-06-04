using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstCond_9XY0 : Instruction
    {
        #region Constructor
        public InstCond_9XY0(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // 	Skips the next instruction if VX doesn't equal VY. (Usually the next instruction is a jump to skip a code block)
            if(systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] != systemData.CpuRegisters[(mOpCode & 0x00F0)] >> 4)
            {
                systemData.ProgramCounter += 4;
            }
            else
            {
                systemData.ProgramCounter += 2;
            }

            return true;
        }
        #endregion
    }
}