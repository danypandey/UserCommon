using System.Runtime.Serialization;

namespace UserCommon
{
    [DataContract]
    public class Data
    {
        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Age { get; set; }

        public Data(string id, string name, string age)
        {
            this.id = id;
            this.Name = name;
            this.Age = age;
        }

        /*public string getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getAge()
        {
            return this.Age;

        }

        public void setId(string id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(string age)
        {
            this.age = age;
        }*/
    }
}
