using System.Collections.Generic;
using System;
using System.Diagnostics;


namespace ConsoleApp1
{
    public class Msgprovider
    {
        private string type;
        private string operation;
        private string date;
        private MyDetails Details;

        public Msgprovider(string type, string operation, string date, MyDetails Details)
        {
            this.type = type;
            this.operation = operation;
            this.date = date;
            this.Details = Details;
        }

        public Message createMessage()
        {
            Factory msgFactory = new Factory();
            Message newMsg =  Factory.getMsg(type, operation, date, Details);
            return newMsg;
        }
        
       


    }

    public class Factory
    {
         
        public static Message getMsg(string type, string operation, string date, MyDetails details)
        {
            //Message product = null;
            switch (operation)
            {
                case "start_communication":
                    if (operation == "request")
                    {
                        createProduct1 c = new createProduct1(date, details);
                        return c.createProduct();
                    }
                    else
                    {
                        createProduct4 c = new createProduct4(date, details);
                        return c.createProduct();
                    }
                    break;
                
                case "end_communication":
                    if (operation == "request")
                    {
                        createProduct2 c = new createProduct2(date, details);
                        return c.createProduct();
                    }
                    else
                    {
                        createProduct5 c = new createProduct5(date, details);
                        return c.createProduct();
                    }
                    break;
                
                case "Classification":
                    if (operation == "request")
                    {
                        createProduct3 c = new createProduct3(date, details);
                        return c.createProduct();
                    }
                    else
                    {
                        createProduct6 c = new createProduct6(date, details);
                        return c.createProduct();
                    }
                    break;
                
                
                default:
                    return null;
                    break;
            }
            
        }
    }

   
    public interface Product
    {
        Message createProduct();
    }

    public class createProduct1 : Product
    {
        private string date;
        private MyDetails details;
        public createProduct1(string date, MyDetails details)
        {
            this.date = date;
            this.details = details;
        }

        public  Message createProduct()
        {
            Message prod = new Msgrequest(Msgtype.Request, Oprtype.StartCommunication, date,
                details.Detail1, details.Detail1);
            return prod;
        }
    }
    
    public class createProduct2 : Product
    {
        private string date;
        private MyDetails details;
        public createProduct2(string date, MyDetails details)
        {
            this.date = date;
            this.details = details;
        }

        public  Message createProduct()
        {
            Message prod = new Msgrequest(Msgtype.Request, Oprtype.EndCommunication, date,
                details.Detail1, details.Detail1);
            return prod;
        }
    }
    
    public class createProduct3 : Product
    {
        
        private string date;
        private MyDetails details;
        public createProduct3(string date, MyDetails details)
        {
            this.date = date;
            this.details = details;
        }

        public  Message createProduct()
        {
            Message prod = new Msgrequest(Msgtype.Request, Oprtype.Classification, date,
                details.Detail1, details.Detail1);
            return prod;
        }
    }
    
    public class createProduct4 : Product
    {
        private string date;
        private MyDetails details;
        public createProduct4(string date, MyDetails details)
        {
            this.date = date;
            this.details = details;
        }

        public  Message createProduct()
        {
            Message prod = new Msganswer(Msgtype.Answer, Oprtype.StartCommunication, date,
                details.Detail1, details.Detail1);
            return prod;
        }
    }
    
    public class createProduct5 : Product
    {
        private string date;
        private MyDetails details;
        public createProduct5(string date, MyDetails details)
        {
            this.date = date;
            this.details = details;
        }

        public  Message createProduct()
        {
            Message prod = new Msganswer(Msgtype.Answer, Oprtype.EndCommunication, date,
                details.Detail1, details.Detail1);
            return prod;
        }
    }
    
    public class createProduct6 : Product
    {
        private string date;
        private MyDetails details;
        public createProduct6(string date, MyDetails details)
        {
            this.date = date;
            this.details = details;
        }

        public  Message createProduct()
        {
            Message prod = new Msganswer(Msgtype.Answer, Oprtype.Classification, date,
                details.Detail1, details.Detail1);
            return prod;
        }
    }
    
    
}