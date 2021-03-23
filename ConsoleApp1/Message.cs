
namespace ConsoleApp1
{
    public enum Msgtype
    {
        Request, 
        Answer
    }
    
    public enum Oprtype
    {
        StartCommunication, 
        EndCommunication,
        Classification
    }

    public class Message
    {
        protected Msgtype messageType;
        protected Oprtype operationType;
        protected string date;

        public Message( Msgtype messageType, Oprtype operationType,string date)
        {
            this.operationType = operationType;
            this.messageType = messageType;
            this.date = date;

        }

        public Oprtype OperationType1
        {
            get => operationType;
            set => operationType = value;
        }

        public Msgtype MessageType1
        {
            get => messageType;
            set => messageType = value;
        }

        public string Date1
        {
            get => date;
            set => date = value;
        }

        public virtual string Print()
        {
            string toPrint = "";
            
            if ( messageType == Msgtype.Request)
            {
                toPrint += "Request ";
            }
            else
            {
                toPrint += "Answer ";
            }
            
            switch (operationType)
            {
                case Oprtype.Classification:
                    toPrint += "Classification ";
                    break;
                
                case Oprtype.StartCommunication:
                    toPrint += " StartCommunication ";
                    break;
                
                case Oprtype.EndCommunication:
                    toPrint += " EndCommunication ";
                    break;
                
            }

            toPrint += date;

            return toPrint;
        }
    
    }
}