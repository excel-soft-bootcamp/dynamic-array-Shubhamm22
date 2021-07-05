using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicArrayProgram
{
     class DynamicNumberArray
    {
        int[] buffer;
        
        public DynamicNumberArray()
        {
            
            buffer = new int[5]; }
       

        public   DynamicNumberArray(int initialSize) { buffer = new int[initialSize]; }
          
        public int this[int index]
        {
            get { return buffer[index]; }
            set 
            { 
                if(index>=buffer.Length)
                { Array.Resize(ref buffer, index + 5);
                }
                
                buffer[index] = value; }
        }
            
        }
}
