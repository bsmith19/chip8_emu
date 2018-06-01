using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstFlow_BNNN : Instruction
    {

        #region Constructor
        public InstFlow_BNNN(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            //Jumps to address of NNN plus V0, Since it a jump no PC increase
            systemData.ProgramCounter = (ushort)(systemData.CpuRegisters[0] + (mOpCode & 0x0FFF));
            return true;
        }
        #endregion
    }
}