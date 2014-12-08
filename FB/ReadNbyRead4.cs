/*
The API: int read4(char *buf) reads 4 characters at a time from a file.
The return value is the actual number of characters read. For example, 
it returns 3 if there is only 3 characters left in the file.
By using the read4 API, implement the function int read(char *buf, int n) 
that reads n characters from the file.

Note: The read function will only be called once for each test case.
*/

namespace FB
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public class FBExReadN
    {
        private char[] arr;
        private int pos;

        public FBExReadN(char[] arr)
        {
            this.arr = arr;
        }

        public int ReadNbyRead4(char[] buf, int n)
        {
            char[] buffer = new char[4];
            int readBytes = 0;
            bool eof = false;

            while (!eof && readBytes < n)
            {
                int sz = this.Read4(buffer);
                if (sz < 4)
                    eof = true;
                int bytes = Math.Min(n - readBytes, sz);
                Array.Copy(buffer, 0, buf, readBytes, bytes);
                readBytes += bytes;
            }

            return readBytes;
        }

        private int Read4(char[] buf)
        {
            if (this.pos >= this.arr.Length)
                return 0;

            int bytes = Math.Min(this.arr.Length - this.pos, 4);
            Array.Copy(this.arr, this.pos, buf, 0, bytes);
            this.pos += bytes;
            return bytes;
        }
    }
}