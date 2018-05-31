using System;
using chip8_emu.CPU;

namespace chip8_emu.CPU.Instruction
{
    public interface IInstruction
    {
        Boolean Handle(Memory memory, Stack stack);
    }
}