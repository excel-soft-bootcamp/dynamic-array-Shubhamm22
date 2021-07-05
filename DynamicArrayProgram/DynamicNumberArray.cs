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
          
        
            public void SetBuffer(int index, int value)
            {
           

                buffer[index] = value;
            }
          public   int GetBuffer(int index)
            {
                return buffer[index];
            }
        }
}
