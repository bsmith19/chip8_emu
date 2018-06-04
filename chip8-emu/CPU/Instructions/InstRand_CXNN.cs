using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstRand_CXNN : Instruction
    {

        #region Constructor
        public InstRand_CXNN(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Sets VX to the result of a bitwise AND operation on a random number (Typically: 0 to 255) and NN.
            Random rand = new Random();
            systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] = (Byte)((mOpCode & 0x00FF) & rand.Next(0, 255));
            systemData.ProgramCounter += 2;
            
            return true;
        }
        #endregion
    }
}