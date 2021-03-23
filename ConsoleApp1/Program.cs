using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetmsgFromfile parseInfo = new GetmsgFromfile();
            parseInfo.CreateandInsertmsg();
        }
    }
    
   
}