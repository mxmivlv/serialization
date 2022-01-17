using System;
using System.Runtime.Serialization;

namespace Serialization
{
    [DataContract]
    public struct Person
    {
        [DataMember]
        private string name;

        [DataMember]
        private int age;

        [DataMember]
        private int weight;

        [DataMember]
        public string Name { get => name; set => name = value; }

        [DataMember]
        public int Age { get => age; set => age = value; }

        [DataMember]
        public int Weight { get => weight; set => weight = value; }

        public Person(string name, int age, int weight) 
        {
            this.name = name;
            this.age = age; 
            this.weight = weight;
        }

        public string PersonPrint() 
        {
            return ($"{Name} {Age} {Weight}");
        }
        
    }
}
