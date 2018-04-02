namespace Back_end.Models
{
  
    public class ExceptionBusiness : System.Exception
    {
        public ExceptionBusiness() { }
        public ExceptionBusiness(string message) : base(message) { }
        public ExceptionBusiness(string message, System.Exception inner) : base(message, inner) { }
        protected ExceptionBusiness(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
 
}