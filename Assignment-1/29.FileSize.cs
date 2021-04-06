using System;

namespace HelloWorld{
    class FileSize
    {
        public void fileSize(string fileName){
            System.IO.FileInfo fi = new System.IO.FileInfo(fileName);  
            long size = fi.Length;  
            Console.WriteLine("File Size in Bytes: {0}", size);  
        }

    }
}