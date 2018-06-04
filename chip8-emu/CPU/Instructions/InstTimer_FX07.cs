using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstTimer_FX07 : Instruction
    {

        #region Constructor
        public InstTimer_FX07(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Sets VX to the value of the delay timer.
            systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] = systemData.DelayTimer;
            systemData.ProgramCounter += 2;
            
            return true;
        }
        #endregion
    }
}