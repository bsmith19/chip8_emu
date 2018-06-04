using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstBitOp_8XYE : Instruction
    {

        #region Constructor
        public InstBitOp_8XYE(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // TODO: This instruction might be wrong and want vX on 0xF instead of vY and vX shifted into vX
            // 	Shifts VY left by one and copies the result to VX. VF is set to the value of the most significant bit of VY before the shift.
            systemData.CpuRegisters[0xF] = (Byte)(systemData.CpuRegisters[(mOpCode & 0x00F0) >> 4] >> 7);
            systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] = (Byte)(systemData.CpuRegisters[(mOpCode & 0x00F0) >> 4] << 1);
            systemData.ProgramCounter += 2;
            
            return true;
        }
        #endregion
    }
}