namespace ConsoleApp1
{
    
    public class Msgrequest : Message
    {
        //classification represented by a number 1 - 5, -1 - no classification
        private int classification;
        
        // classification represented by a number , -1 - no urgency
        private int urgency;
        
        
        public Msgrequest(Oprtype operationType, Msgtype messageType, string date,
                            int classification, int urgency) 
                            : base( operationType,  messageType,  date)
        {
            this.classification = classification;
            this.urgency = urgency;
        }
        
        public int Classification1
        {
            get => classification;
            set => classification = value;
        }

        public int Urgency1
        {
            get => urgency;
            set => urgency = value;
        }
    }
}