using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

using chip8_emu.CPU;

namespace chip8_emu.Xunit.CPU
{
    public class MemoryTest
    {
        [Fact]
        public void LoadFontTest()
        {
            Byte[] font = { 
                0xF0, 0x90, 0x90, 0x90, 0xF0, // 0
                0x20, 0x60, 0x20, 0x20, 0x70, // 1
                0xF0, 0x10, 0xF0, 0x80, 0xF0, // 2
                0xF0, 0x10, 0xF0, 0x10, 0xF0, // 3
                0x90, 0x90, 0xF0, 0x10, 0x10, // 4
                0xF0, 0x80, 0xF0, 0x10, 0xF0, // 5
                0xF0, 0x80, 0xF0, 0x90, 0xF0, // 6
                0xF0, 0x10, 0x20, 0x40, 0x40, // 7
                0xF0, 0x90, 0xF0, 0x90, 0xF0, // 8
                0xF0, 0x90, 0xF0, 0x10, 0xF0, // 9
                0xF0, 0x90, 0xF0, 0x90, 0x90, // A
                0xE0, 0x90, 0xE0, 0x90, 0xE0, // B
                0xF0, 0x80, 0x80, 0x80, 0xF0, // C
                0xE0, 0x90, 0x90, 0x90, 0xE0, // D
                0xF0, 0x80, 0xF0, 0x80, 0xF0, // E
                0xF0, 0x80, 0xF0, 0x80, 0x80  // F
            };

            Dictionary<EMemoryPartitions, Int32> memMap = new Dictionary<EMemoryPartitions, Int32>()
            {
                {EMemoryPartitions.Font, 0},
                {EMemoryPartitions.Rom, 511}
            };
            Memory mem = new Memory(1024, memMap);
            Assert.True(mem.loadFont(font));
        }

        [Fact]
        public void LoadRomTest()
        {
            Dictionary<EMemoryPartitions, Int32> memMap = new Dictionary<EMemoryPartitions, Int32>()
            {
                {EMemoryPartitions.Font, 0},
                {EMemoryPartitions.Rom, 511}
            };

            using(BinaryReader br = new BinaryReader(File.Open("..\\..\\..\\Resources\\pong2.c8", FileMode.Open)))
            {
                Memory mem = new Memory(4096, memMap);
                Assert.True(mem.loadRom(br.ReadBytes((int)br.BaseStream.Length)));
            }

        }

        [Fact]
        public void GetOpCodeTest()
        {
            Dictionary<EMemoryPartitions, Int32> memMap = new Dictionary<EMemoryPartitions, Int32>()
            {
                {EMemoryPartitions.Font, 0},
                {EMemoryPartitions.Rom, 512}
            };

            using(BinaryReader br = new BinaryReader(File.Open("..\\..\\..\\Resources\\pong2.c8", FileMode.Open)))
            {
                Memory mem = new Memory(4096, memMap);
                Assert.True(mem.loadRom(br.ReadBytes((int)br.BaseStream.Length)));
                
                ushort opcode = mem.getOpcode(0x200);
                Assert.Equal(opcode, 0x22FC);
            }
        }
    }
}