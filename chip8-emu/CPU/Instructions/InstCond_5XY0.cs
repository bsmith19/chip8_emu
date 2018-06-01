using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstCond_5XY0 : Instruction
    {
        #region Constructor
        public InstCond_5XY0(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            //Must shift 8 in CpuRegister to make if X instead of X0000000 for the index
            //Must shift 4 in 2nd CPURegister since we are pull one digit closeer to the right
            //Skips the next instruction if vX == vY
            if(systemData.CpuRegisters[(mOpCode & 0x0F00) >> 8] == systemData.CpuRegisters[(mOpCode & 0x00F0) >> 4])
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