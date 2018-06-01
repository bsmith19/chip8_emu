using System;

namespace chip8_emu.CPU.Instructions
{
    public class InstFlow_00EE : Instruction
    {
        #region Constructor
        public InstFlow_00EE(ushort opcode) : base(opcode)
        {
        }
        #endregion

        #region Overrides
        override public Boolean Handle(CPUData systemData)
        {
            //Returns from a Subroutine, Program Counter should increase
            systemData.ProgramCounter = systemData.SystemStack.PopStack();

            // Increment the program counter (2 bytes per instruction)
            systemData.ProgramCounter += 2; 

            return true;
        }
        #endregion
    }
}