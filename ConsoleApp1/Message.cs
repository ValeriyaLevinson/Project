
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
        protected Oprtype operationType;
        protected Msgtype messageType;
        protected string date;

        public Message(Oprtype operationType, Msgtype messageType, string date)
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
    }
}