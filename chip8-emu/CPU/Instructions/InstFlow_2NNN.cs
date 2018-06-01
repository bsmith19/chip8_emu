using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstFlow_2NNN : Instruction
    {

        #region Constructor
        public InstFlow_2NNN(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            // Calls subroutine at NNN
            //Push current location on stack and jump to NNN
            if(systemData.SystemStack.PushStack(systemData.ProgramCounter))
            {
                //Jump to NNN
                systemData.ProgramCounter = (ushort)(mOpCode & 0x0FFF);
                return true;
            }
            // Stack Overflow, Fail
            return false;
        }
        #endregion
    }
}