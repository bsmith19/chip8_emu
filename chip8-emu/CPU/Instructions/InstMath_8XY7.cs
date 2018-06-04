using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMath_8XY7 : Instruction
    {

        #region Constructor
        public InstMath_8XY7(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Sets VX to VY minus VX. VF is set to 0 when there's a borrow, and 1 when there isn't.
        	if(systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] > systemData.CpuRegisters[(mOpCode & 0x00F0) >> 4])
            {
                // set the borrow here
				systemData.CpuRegisters[0xF] = 0;
            }
			else
            {
                //no borrow, continue on
                systemData.CpuRegisters[0xF] = 1;	
            }

            // subtract here
            systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] = (Byte)(systemData.CpuRegisters[(mOpCode & 0x00F0) >> 4] - systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8]);
			systemData.ProgramCounter += 2;
            
            return true;
        }
        #endregion
    }
}