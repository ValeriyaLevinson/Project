namespace ConsoleApp1
{
    
    public class Msganswer : Message
    {
        // -1 - no error code
        private int ErrorCode;
        
        // -1 - no confirmation code
        private int ConfirmCode;

        public Msganswer(Oprtype operationType, Msgtype messageType, string date, int errorCode, int confirmCode) 
            : base(operationType, messageType, date)
        {
            this.ErrorCode = errorCode;
            this.ConfirmCode = confirmCode;
        }
        
        public int ErrorCode1
        {
            get => ErrorCode;
            set => ErrorCode = value;
        }
        
        public int ConfirmCode1
        {
            get => ConfirmCode;
            set => ConfirmCode = value;
        }

    }
}