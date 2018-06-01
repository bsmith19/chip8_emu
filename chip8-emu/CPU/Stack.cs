using System;

namespace chip8_emu.CPU
{
    public class Stack
    {
        #region Private Members
        private ushort[] mStack;
        private Int16 mStackSize;
        private ushort mStackPointer;
        #endregion
        
        #region Constructors
        public Stack(Int16 stackSize)
        {
            mStackSize = stackSize;
            mStack = new ushort[mStackSize];
            mStackPointer = 0x0;
        }
        #endregion

        #region Public Methods
        public ushort PopStack()
        {
            if(mStackPointer > 0x0)
            {
                // Decrement the stack pointer and get the new pc value
                mStackPointer--;
                ushort newPC = mStack[mStackPointer];

                //Erase the old stack value
                mStack[mStackPointer] = 0x0;

                return newPC;
            }
            return 0x0;
        }
        public Boolean PushStack(ushort programCounter)
        {
            //Verify we arn't overflowing the stack...
            if(mStackPointer < mStackSize)
            {
                //Set it and move the stack pointer up
                mStack[mStackPointer] = programCounter;
                mStackPointer++;

                return true;
            }
            return false;
        }
        #endregion
    }
}