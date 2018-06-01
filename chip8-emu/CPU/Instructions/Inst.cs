using System;
using chip8_emu.CPU;

namespace chip8_emu.CPU.Instructions
{
    abstract public class Instruction
    {
        #region ProtectedVar
        protected ushort mOpCode;
        #endregion

        #region Constructors
        protected Instruction(ushort opcode)
        {
            mOpCode = opcode;
        }
        #endregion

        #region Abstract Methods
        abstract public Boolean Handle(CPUData systemData);
        #endregion
    }
}