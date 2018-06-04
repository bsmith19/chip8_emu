using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstBitOp_8XY6 : Instruction
    {
        #region Constructor
        public InstBitOp_8XY6(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Shifts VY right by one and stores the result to VX (VY remains unchanged). 
            // VF is set to the value of the least significant bit of VY before the shift
            systemData.CpuRegisters[0xF] = (Byte)(systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] & 0x1);
			systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] >>= 1;
			systemData.ProgramCounter += 2;

            return true;
        }
        #endregion
    }
}