using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstConst_6XNN : Instruction
    {
        #region Constructor
        public InstConst_6XNN(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            //Sets VX to NN
            systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] = (Byte)(mOpCode & 0x00FF);

            //Jump to next Instr
            systemData.ProgramCounter += 2;

            return true;
        }
        #endregion
    }
}