using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMath_8XY4 : Instruction
    {

        #region Constructor
        public InstMath_8XY4(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Adds VY to VX. VF is set to 1 when there's a carry, and to 0 when there isn't.
            //0xF(16) - Call location in memory
            if(systemData.CpuRegisters[(mOpCode & 0x00F0) >> 4] > (0xFF - systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8]))
            {
                 //Set carry to 1
				systemData.CpuRegisters[0xF] = 1;
            }
			else
            {
                //Set carry to 0
                systemData.CpuRegisters[0xF] = 0;					
            } 

            //add the memory locations
            systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] += systemData.CpuRegisters[(mOpCode & 0x00F0) >> 4];
			systemData.ProgramCounter += 2;

            return true;

        }
        #endregion
    }
}