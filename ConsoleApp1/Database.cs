
using System.Collections.Generic;
using System;
using System.Diagnostics;

int index_StartCon = 0;
int index_EndCon = 1;
int index_Classification = 2;

public enum Status
{
    Success,
    failure
};


public static class Globals
{
    public static int index_StartCon = 0;
    public static int index_EndtCon = 1;
    public static int index_Classification = 2;
  
    
}

namespace ConsoleApp1
{
    
   
    
    public class Database
    {
        private List<Queue<Message>> _dBmessages; 
        private int Count_StartCon;
        private int Count_EndCon;
        private int Cont_Classification;
      
        public Database()
        {
           DBmessages = new List<Queue<Message>>();
           Queue<Message> StartCon = new Queue<Message>();
           Queue<Message> EndCon = new Queue<Message>();
           Queue<Message> Classification = new Queue<Message>();
           
           DBmessages.Add(StartCon);
           DBmessages.Add(EndCon);
           DBmessages.Add(Classification);

           CountStartCon = 0;
           CountEndCon = 0;
           ContClassification = 0;

           /*Message m = new Msgrequest(Msgtype.Request, Oprtype.StartCommunication, "12345", 2, 5);
           stc.Enqueue(m);
           Message m2 = new Msganswer(Msgtype.Answer, Oprtype.StartCommunication, "1111", 3, 3);
           stc.Enqueue(m2);

           Msganswer mans = (Msganswer) stc.Peek();*/

        }

        public List<Queue<Message>> DBmessages
        {
            get => _dBmessages;
            set => _dBmessages = value;
        }

        public int CountStartCon
        {
            get => Count_StartCon;
            set => Count_StartCon = value;
        }

        public int CountEndCon
        {
            get => Count_EndCon;
            set => Count_EndCon = value;
        }

        public int ContClassification
        {
            get => Cont_Classification;
            set => Cont_Classification = value;
        }

        public Status add(Message MsgAdd)
        {
            Status st = Status.failure;
            Message head;

            switch (MsgAdd.OperationType1)
            {
                case Oprtype.StartCommunication:
                    head = DBmessages[Globals.index_StartCon].Peek();

                    
                    if (head.MessageType1 == MsgAdd.MessageType1 &&
                        head.MessageType1 == Msgtype.Request)
                    {
                        head.Date1 = MsgAdd.Date1;
                        return Status.Success;
                    }
                    
                    if (head.MessageType1 == Msgtype.Answer &&
                        MsgAdd.MessageType1 == Msgtype.Request)
                    {
                        DBmessages[Globals.index_StartCon].Enqueue(MsgAdd);
                        CountStartCon++;
                        return Status.Success;
                    }
                        

                    if (head.MessageType1 == Msgtype.Request &&
                        MsgAdd.MessageType1 == Msgtype.Answer)
                    {
                        DBmessages[Globals.index_StartCon].Enqueue(MsgAdd);
                        CountStartCon++;
                        return Status.Success;
                    }
                       
                    
                    break;
                case Oprtype.EndCommunication:
                    head = DBmessages[Globals.index_EndtCon].Peek();
                    
                    if (head.MessageType1 == MsgAdd.MessageType1 &&
                        head.MessageType1 == Msgtype.Request)
                    {
                        head.Date1 = MsgAdd.Date1;
                        return Status.Success;
                    }
                    
                    if (head.MessageType1 == Msgtype.Answer &&
                        MsgAdd.MessageType1 == Msgtype.Request)
                    {
                        DBmessages[Globals.index_EndtCon].Enqueue(MsgAdd);
                        CountEndCon++;
                        return Status.Success;
                    }
                        

                    if (head.MessageType1 == Msgtype.Request &&
                        MsgAdd.MessageType1 == Msgtype.Answer)
                    {
                        DBmessages[Globals.index_EndtCon].Enqueue(MsgAdd);
                        CountEndCon++;
                        return Status.Success;
                    }

                    break;
                case Oprtype.Classification:
                    head = DBmessages[Globals.index_Classification].Peek();
                    
                    if (head.MessageType1 == MsgAdd.MessageType1 &&
                        head.MessageType1 == Msgtype.Request)
                    {
                        head.Date1 = MsgAdd.Date1;
                        return Status.Success;
                    }
                    
                    if (head.MessageType1 == Msgtype.Answer &&
                        MsgAdd.MessageType1 == Msgtype.Request)
                    {
                        DBmessages[Globals.index_Classification].Enqueue(MsgAdd);
                        ContClassification++;
                        return Status.Success;
                    }
                        

                    if (head.MessageType1 == Msgtype.Request &&
                        MsgAdd.MessageType1 == Msgtype.Answer)
                    {
                        DBmessages[Globals.index_Classification].Enqueue(MsgAdd);
                        ContClassification++;
                        return Status.Success;
                    }

                    break;
                
                default:
                    return st;
                    break;
            }
            
            return st;
        }
        
    }
}