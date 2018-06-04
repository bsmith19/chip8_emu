using System;
using System.Collections.Generic;

namespace chip8_emu.CPU
{
    public enum EMemoryPartitions
    {
        Font = 0,
        Rom
    }

    public class Memory
    {
        #region Private Members
        private Byte[] mMemory;
        private Int32 mMemorySize;
        private Dictionary<EMemoryPartitions, Int32> mMemoryMap;
        #endregion

        #region Constructors
        public Memory(Int16 memorySize, Dictionary<EMemoryPartitions, Int32> memoryMap)
        {
            mMemory = new Byte[memorySize];
            mMemorySize = memorySize;
            mMemoryMap = memoryMap;
        }
        #endregion

        #region Public Methods
        public Boolean loadRom(Byte[] rom)
        {
            // Need to check if the game can actually fit in memory first..
            Int32 romAvailSize = mMemorySize - mMemoryMap[EMemoryPartitions.Rom];
            if(rom.Length <= romAvailSize)
            {
                for(Int32 i = 0; i < rom.Length; i++)
                {
                    mMemory[mMemoryMap[EMemoryPartitions.Rom] + i] = rom[i];
                }

                return true;
            }

            return false;
        }
        public Boolean loadFont(Byte[] font)
        {
            // Need to check if the font can actually fit in the preallocated memory first..
            Int32 fontAvailSize = mMemorySize - mMemoryMap[EMemoryPartitions.Font];
            if(font.Length <= fontAvailSize)
            {
                for(Int32 i = 0; i <= font.Length; i++)
                {
                    mMemory[mMemoryMap[EMemoryPartitions.Font] + i] = font[i];
                }

                return true;
            }

            return false;
        }
        public ushort getOpcode(ushort programCounter)
        {
            //Opcode is 2 bytes, so we need to pull them both out
            Byte opP1 = mMemory[programCounter];
            Byte opP2 = mMemory[programCounter + 1];

            //Merge two parts to one opcode
            ushort opCode = (ushort)(opP1 << 8 | opP2);
            return opCode;
        }
        #endregion

        #region Overloaded Operators
        //Overload this class to have an [] index operator
        public Byte this[int key]
        {
            get
            {
                return this.mMemory[key];
            }
            set
            {
                this.mMemory[key] = value;
            }
        }
        #endregion
    }
}