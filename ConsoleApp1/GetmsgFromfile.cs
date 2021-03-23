
using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
    
    //The class reads the messages from the file and inserts the information into the data structure
     class GetmsgFromfile
    {
        private string JsonString;
        private MyJsonTypes Allobj;
        private Database dbMessages;

        //allobj suppose to contain all the json info in list of MyJsonType
        public GetmsgFromfile()
        {
            this.JsonString = File.ReadAllText( @"C:\Users\valer\Desktop\Messages.json");
            this.Allobj = JsonConvert.DeserializeObject<MyJsonTypes>(JsonString);
            this.dbMessages = new Database();
        }
        
        // the function creates the msgs from allobj and insert to the data structure
        public void CreateandInsertmsg()
        {
            Message MsgAdd;
            Status st;
            Msgprovider provider ;
            
            for (int i = 0; i < Allobj.Objs.Count; i++)
            {
                provider = new Msgprovider(Allobj.Objs[i].MymessageType, Allobj.Objs[i].MyoperationType,
                    Allobj.Objs[i].Mytime, Allobj.Objs[i].MySubDocument);
                st = dbMessages.add(provider.createMessage());
            }
            
        }
        

       
    }
    
    
    // The classes required to retrieve information from a file and turn it into a list of objects
    public class MyJsonTypes
    {
        public List<MyJsonType> Objs { get; }

       
    }
    public class MyJsonType
    {

        public string MyoperationType { get; set; }

        public string MymessageType { get; set; }
        
        public string Mytime { get; set; }

        public MyDetails MySubDocument { get; set; }
    }
    public class MyDetails
    {
        public int Detail1 { get; set; }
        public int Detail2 { get; set; }
    }
}