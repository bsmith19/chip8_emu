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
            //Sets vX to the value of vY
            systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] = systemData.CpuRegisters[(mOpCode & 0x00F0) >> 4];

            //Jump to next Instr
            systemData.ProgramCounter += 2;

            return true;
        }
        #endregion
    }
}