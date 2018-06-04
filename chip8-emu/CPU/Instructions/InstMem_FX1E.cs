using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMem_FX1E : Instruction
    {

        #region Constructor
        public InstMem_FX1E(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Adds VX to I.
            // VF is set to 1 when range overflow (I+VX>0xFFF), and 0 when there isn't.
            if(systemData.IndexRegister + systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] > 0xFFF)
            {
                systemData.CpuRegisters[0xF] = 1;
            }
            else
            {
                systemData.CpuRegisters[0xF] = 0;
            }

            //Add..
            systemData.IndexRegister += systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8];
            systemData.ProgramCounter += 2;

            return true;
        }
        #endregion
    }
}