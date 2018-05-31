using System;

namespace chip8_emu.CPU.Instruction
{
    static class InstructionFactory
    {
        public static IInstruction buildInstruction(ushort opcode, Memory mem, Stack st)
        {
            // Decode Opcode and match inst type
            switch(opcode & 0xF000)
            {
                case 0x0000:
                    switch(opcode & 0x000F)
                    {
                        case 0x0000:
                            return new InstDisplay_00E0(mem, st);
                        case 0x000E:
                            return new InstFlow_00EE(mem, st);
                        default:
                            return null;
                    }
                case 0x1000:
                    return new InstFlow_1NNN(mem, st);
                case 0x2000:
                    return new InstFlow_2NNN(mem, st);
                case 0x3000:
                    return new InstCond_3XNN(mem, st);
                case 0x4000:
                    return new InstCond_4XNN(mem, st);
                case 0x5000:
                    return new InstCond_5XY0(mem, st);
                case 0x6000:
                    return new InstConst_6XNN(mem, st);
                case 0x7000:
                    return new InstConst_7XNN(mem, st);
                case 0x8000:
                    switch(opcode & 0x000F)
                    {
                        case 0x0000:
                            return new InstAssign_8XY0(mem, st);
                        case 0x0001:
                            return new InstBitOp_8XY1(mem, st);
                        case 0x0002:
                            return new InstBitOp_8XY2(mem, st);
                        case 0x0003:
                            return new InstBitOp_8XY3(mem, st);
                        case 0x0004:
                            return new InstMath_8XY4(mem, st);
                        case 0x0005:
                            return new InstMath_8XY5(mem, st);
                        case 0x0006:
                            return new InstBitOp_8XY6(mem, st);
                        case 0x0007:
                            return new InstMath_8XY7(mem, st);
                        case 0x000E:
                            return new InstBitOp_8XYE(mem, st);
                        default:
                            return null;
                    }
                case 0x9000:
                    return new InstCond_9XY0(mem, st);
                case 0xA000:
                    return new InstMem_ANNN(mem, st);
                case 0xB000:
                    return new InstFlow_BNNN(mem, st);
                case 0xC000:
                    return new InstRand_CXNN(mem, st);
                case 0xD000:
                    return new InstDisp_DXYN(mem, st);
                case 0xE000:
                    switch(opcode & 0x000F)
                    {
                        case 0x000E:
                            return new InstKeyOp_EX9E(mem, st);
                        case 0x0001:
                            return new InstKeyOp_EXA1(mem, st);
                        default:
                            return null;
                    }
                case 0xF000:
                    switch(opcode & 0x000F)
                    {
                        case 0x0007:
                            return new InstTimer_FX07(mem, st);
                        case 0x000A:
                            return new InstKeyOp_FX0A(mem, st);
                        case 0x0005:
                            switch(opcode & 0x00F0)
                            {
                                case 0x0010:
                                    return new InstTimer_FX15(mem, st);
                                case 0x0050:
                                    return new InstMem_FX55(mem, st);
                                case 0x0060:
                                    return new InstMem_FX65(mem, st);
                                default:
                                    return null;
                            }
                        case 0x0008:
                            return new InstSound_FX18(mem, st);
                        case 0x000E:
                            return new InstMem_FX1E(mem, st);
                        case 0x0009:
                            return new InstMem_FX29(mem, st);
                        case 0x0003:
                            return new InstBcd_FX33(mem, st);
                        default:
                            return null;
                    }
                default:
                    return null;
            }
        }
    }
}