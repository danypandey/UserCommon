using System.Runtime.Serialization;

namespace UserCommon
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public int error_code { get; set; }
        [DataMember]
        public string error_message { get; set; }

        public Result()
        {
                
        }

        public Result(int error_code, string error_message)
        {
            this.error_code = error_code;
            this.error_message = error_message;
        }
    }
}