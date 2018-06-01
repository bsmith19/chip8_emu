using System;
using System.Collections.Generic;

namespace chip8_emu.CPU
{
    public class Chip8
    {
        #region Private Properties
        private CPUData SystemStorage { get; set;}
        #endregion

        #region Timers
        private Byte soundTimer;
        private Byte delayTimer;
        #endregion

        #region Constructors
        public Chip8(short stackSize, short memorySize, int programSpace)
        {
            // TODO: This shouldnt be constant, should be read in from the memory map
            SystemStorage.ProgramCounter = 0x200;
            SystemStorage.IndexRegister = 0;

            // The memory layout is specfic to this CPU, so it can be defined here
            SystemStorage.SystemStack = new Stack(stackSize);
            SystemStorage.SystemMemory = new Memory(memorySize, new Dictionary<EMemoryPartitions, int>() 
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
            ushort opCode = SystemStorage.SystemMemory.getOpcode(SystemStorage.ProgramCounter);

            //Pick Correct action for opcode
            Instructions.Instruction inst = Instructions.InstructionFactory.buildInstruction(opCode);
            Boolean ok = inst.Handle(SystemStorage);

            //Update timers (sound and video)

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