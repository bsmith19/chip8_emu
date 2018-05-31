using System;

namespace chip8_emu.CPU.Instruction
{
    public class InstAssign_8XY0 : IInstruction
    {
        #region Constructor
        public InstAssign_8XY0()
        {
        }
        #endregion

        #region Overrides
        public Boolean Handle(Memory memory, Stack stack)
        {
            return true;
        }
        #endregion
    }
}