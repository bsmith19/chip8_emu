using System;
using System.Collections.Generic;

namespace chip8_emu.CPU
{
    public class Chip8
    {
        #region Private Properties
        private Stack SystemStack { get; set; }
        private Memory SystemMemory { get; set; }
        #endregion

        #region Private Members
        private Byte[] mCpuRegisters;
        private ushort mProgramCounter;
        private ushort mIndexRegister;
        #endregion

        #region Timers
        private Byte soundTimer;
        private Byte delayTimer;
        #endregion

        #region Constructors
        public Chip8(short stackSize, short memorySize, int programSpace)
        {
            // TODO: This shouldnt be constant, should be read in from the memory map
            mProgramCounter = 0x200;
            mIndexRegister = 0;

            // The memory layout is specfic to this CPU, so it can be defined here
            SystemStack = new Stack(stackSize);
            SystemMemory = new Memory(memorySize, new Dictionary<EMemoryPartitions, int>() 
            {
                { EMemoryPartitions.Font, programSpace - 1 },
                { EMemoryPartitions.Rom, programSpace }
            });
        }
        #endregion

        #region Public Methods
        public Boolean emulateCycle()
        {
            //Fetch Opcode
            ushort opCode = SystemMemory.getOpcode(mProgramCounter);

            //Pick Correct action for opcode
            Instruction.IInstruction inst = Instruction.InstructionFactory.buildInstruction(opCode, SystemMemory, SystemStack);
            Boolean ok = inst.Handle();

            //Update timers (sound and video)

            // Increment the program counter (2 bytes per instruction)
            mProgramCounter += 2; 

            return ok;
        }
        #endregion
    }

    public class CPUData
    {
        public Stack SystemStack { get; set; }
        public Memory SystemMemory { get; set; }
        public Byte[] CpuRegisters { get; set; }
        public ushort ProgramCounter { get; set; }
        public ushort IndexRegister { get; set; }
    }
}