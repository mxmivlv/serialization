using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Serialization
{
    public struct Method
    {
        public static Person person = new Person();

        public static List<Person> ListPerson = new List<Person>();
        public void Write() 
        {
            for(int i = 0; i < 10; i++) 
            {

                person.Name = $"NamePerson_{i}";
                person.Age = (i * 2);
                person.Weight = (i * 3);
                ListPerson.Add(person);
            }
        }

        public void XMLSer() 
        {
            using (FileStream BookXML = new FileStream("BookXML.xml", FileMode.OpenOrCreate)) 
            {
                 var xmlform = new XmlSerializer(typeof(List<Person>));
                 xmlform.Serialize(BookXML, ListPerson);
            }
        }

        public List<Person> XMLDes() 
        {
            List<Person> temp = new List<Person>();

            using (FileStream BookXML = new FileStream("BookXML.xml", FileMode.Open))
            {
                var xmlform = new XmlSerializer(typeof(List<Person>));
                temp = xmlform.Deserialize(BookXML) as List<Person>;
            }
            return temp;
        }

        public void JsonSer() 
        {
            using (FileStream BookJson = new FileStream("BookJSON.json", FileMode.OpenOrCreate))
            {
                var jsonform = new DataContractSerializer(typeof(List<Person>));
                jsonform.WriteObject(BookJson, ListPerson);
            }
        }

        public List<Person> JsonDes() 
        {
            List<Person> temp = new List<Person>();

            using (FileStream BookJson = new FileStream("BookJSON.json", FileMode.Open))
            {
                var JSONform = new DataContractSerializer (typeof(List<Person>));
                temp = JSONform.ReadObject(BookJson) as List<Person>;
            }
            return temp;
        }
    }
}
