using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstCond_3XNN : Instruction
    {

        #region Constructor
        public InstCond_3XNN(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            //Must shift 8 in CpuRegister to make if X instead of X0000000 for the index
            //Skips the next instruction if vX == NN
            if(systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] == (mOpCode & 0x00FF))
            {
                //Skip(4 bytes instead of 2)
                systemData.ProgramCounter += 4;
                return true;
            }

            //Don't Skipp
            systemData.ProgramCounter += 2;
            return true;
        }
        #endregion
    }
}