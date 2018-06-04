using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstBcd_FX33 : Instruction
    {
        #region Constructor
        public InstBcd_FX33(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Stores the binary-coded decimal representation of VX, with the most significant of three digits at the address in I, 
            // the middle digit at I plus 1, and the least significant digit at I plus 2. 
            // (In other words, take the decimal representation of VX, place the hundreds digit in memory at location in I, 
            // the tens digit at location I+1, and the ones digit at location I+2.)
            systemData.SystemMemory[systemData.IndexRegister] = (Byte)(systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] / 100);
            systemData.SystemMemory[systemData.IndexRegister + 1] = (Byte)((systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] / 10) % 10);
            systemData.SystemMemory[systemData.IndexRegister + 2] = (Byte)((systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] % 100) % 10);
            systemData.ProgramCounter += 2;
            			
            return true;
        }
        #endregion
    }
}