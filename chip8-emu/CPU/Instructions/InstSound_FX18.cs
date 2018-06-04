using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstSound_FX18 : Instruction
    {

        #region Constructor
        public InstSound_FX18(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Sets the sound timer to VX.
            systemData.SoundTimer = systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8];
            systemData.ProgramCounter += 2;
            
            return true;
        }
        #endregion
    }
}