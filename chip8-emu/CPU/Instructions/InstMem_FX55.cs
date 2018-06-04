using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstMem_FX55 : Instruction
    {

        #region Constructor
        public InstMem_FX55(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Stores V0 to VX (including VX) in memory starting at address I. I is increased by 1 for each value written.
            for (int i = 0; i < ((mOpCode & 0x0F00) >> 8); i++)
            {
                systemData.SystemMemory[systemData.IndexRegister + i] = systemData.CpuRegisters[i];
            }
            systemData.ProgramCounter += 2;

            //Move I to the end, not all emulators do this
            //TODO: maybe remove this
            systemData.IndexRegister += (ushort)(((mOpCode & 0x0F00) >> 8) + 1);
            return true;
        }
        #endregion
    }
}