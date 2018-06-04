using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstTimer_FX15 : Instruction
    {

        #region Constructor
        public InstTimer_FX15(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Sets the delay timer to VX.
            systemData.DelayTimer = systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8];
            systemData.ProgramCounter += 2;
            
            return true;
        }
        #endregion
    }
}