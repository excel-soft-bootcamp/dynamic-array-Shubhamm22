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
          
        
            public void Set(int index, int value)
            {
           

                buffer[index] = value;
            }
          public   int Get(int index)
            {
                return buffer[index];
            }
        }
}
