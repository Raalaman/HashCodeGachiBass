using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GachiBass.Models
{
    public class LibrarySignup 
    {
        private readonly Object outputLock = new Object();
        public void SignUpProcess(Library libarary, List<Book> books)
        {
            if (Monitor.TryEnter(outputLock))
            {
                try
                {
                    
                }
                finally
                {
                    Monitor.Exit(outputLock);
                }
            }
        }
    }
}
