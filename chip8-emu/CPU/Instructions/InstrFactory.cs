using System;

namespace chip8_emu.CPU.Instruction
{
    static class InstructionFactory
    {
        public static IInstruction buildInstruction(ushort opcode)
        {
            // Decode Opcode and match inst type
            switch(opcode & 0xF000)
            {
                case 0x0000:
                    switch(opcode & 0x000F)
                    {
                        case 0x0000:
                            return new InstDisplay_00E0();
                        case 0x000E:
                            return new InstFlow_00EE();
                        default:
                            return null;
                    }
                case 0x1000:
                    return new InstFlow_1NNN();
                case 0x2000:
                    return new InstFlow_2NNN();
                case 0x3000:
                    return new InstCond_3XNN();
                case 0x4000:
                    return new InstCond_4XNN();
                case 0x5000:
                    return new InstCond_5XY0();
                case 0x6000:
                    return new InstConst_6XNN();
                case 0x7000:
                    return new InstConst_7XNN();
                case 0x8000:
                    switch(opcode & 0x000F)
                    {
                        case 0x0000:
                            return new InstAssign_8XY0();
                        case 0x0001:
                            return new InstBitOp_8XY1();
                        case 0x0002:
                            return new InstBitOp_8XY2();
                        case 0x0003:
                            return new InstBitOp_8XY3();
                        case 0x0004:
                            return new InstMath_8XY4();
                        case 0x0005:
                            return new InstMath_8XY5();
                        case 0x0006:
                            return new InstBitOp_8XY6();
                        case 0x0007:
                            return new InstMath_8XY7();
                        case 0x000E:
                            return new InstBitOp_8XYE();
                        default:
                            return null;
                    }
                case 0x9000:
                    return new InstCond_9XY0();
                case 0xA000:
                    return new InstMem_ANNN();
                case 0xB000:
                    return new InstFlow_BNNN();
                case 0xC000:
                    return new InstRand_CXNN();
                case 0xD000:
                    return new InstDisp_DXYN();
                case 0xE000:
                    switch(opcode & 0x000F)
                    {
                        case 0x000E:
                            return new InstKeyOp_EX9E();
                        case 0x0001:
                            return new InstKeyOp_EXA1();
                        default:
                            return null;
                    }
                case 0xF000:
                    switch(opcode & 0x000F)
                    {
                        case 0x0007:
                            return new InstTimer_FX07();
                        case 0x000A:
                            return new InstKeyOp_FX0A();
                        case 0x0005:
                            switch(opcode & 0x00F0)
                            {
                                case 0x0010:
                                    return new InstTimer_FX15();
                                case 0x0050:
                                    return new InstMem_FX55();
                                case 0x0060:
                                    return new InstMem_FX65();
                                default:
                                    return null;
                            }
                        case 0x0008:
                            return new InstSound_FX18();
                        case 0x000E:
                            return new InstMem_FX1E();
                        case 0x0009:
                            return new InstMem_FX29();
                        case 0x0003:
                            return new InstBcd_FX33();
                        default:
                            return null;
                    }
                default:
                    return null;
            }
        }
    }
}