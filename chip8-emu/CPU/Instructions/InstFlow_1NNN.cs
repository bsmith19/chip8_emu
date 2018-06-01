using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstFlow_1NNN : Instruction
    {

        #region Constructor
        public InstFlow_1NNN(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            //Jumps to address at NNN, Since your already jumping don't increase the PC
            systemData.ProgramCounter = (ushort)(mOpCode & 0x0FFF);
            return true;
        }
        #endregion
    }
}