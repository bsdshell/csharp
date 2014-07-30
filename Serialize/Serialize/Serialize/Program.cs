using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Xml.Serialization;

namespace Serialize
{
    public class Person
    {
        public string FirstName;
        public string LastName;
    }

    public class OtherPerson
    {
        [XmlElement("AttributeFirstName")]
        public string FirstName;
        [XmlElement("AttributeLastName")]
        public string LastName;
    }

    [XmlRoot("Root")]
    public class RootPerson
    {
        public string FirstName;
        public string LastName;
    }


    [XmlRoot("Root")]
    public class SmartPerson
    {
        [XmlElement("SmartFirstName")]
        public string FirstName;
        [XmlElement("SmartLastName")]
        public string LastName;
        [XmlIgnore] 
        public string sex;
    }


    public class SuperSmartPerson
    {
        public string FirstName;
        public string LastName;
        public Person person;
    }

    class Program
    {
        private static void Main(string[] args)
        {
            Person simplePerson = new Person();
            simplePerson.FirstName = "Tony";
            simplePerson.LastName = "Skill";

            OtherPerson otherPerson = new OtherPerson();
            otherPerson.FirstName = "other First Name";
            otherPerson.LastName = "other Last Name";

            RootPerson rootPerson = new RootPerson();
            otherPerson.FirstName = "root First Name";
            otherPerson.LastName = "root Last Name";

            
            SmartPerson smartPerson = new SmartPerson();
            smartPerson.FirstName = "Smart Tony";
            smartPerson.LastName = "Smart Skillkk";
            smartPerson.sex = "male";

            List<Person> listPerson = new List<Person>();
            Person p1 = new Person() {FirstName = "cat", LastName = "last cat"};
            Person p2 = new Person() {FirstName = "cow", LastName = "last cow" };
            Person p3 = new Person() {FirstName = "wolf", LastName = "last wolf" };

            listPerson.Add(p1);
            listPerson.Add(p2);
            listPerson.Add(p3);

            SuperSmartPerson superSmartPerson = new SuperSmartPerson();
            superSmartPerson.FirstName = "Super Smart Guy";
            superSmartPerson.LastName = "Super Silly Guy";
            superSmartPerson.person = new Person();
            superSmartPerson.person.FirstName = "John";
            superSmartPerson.person.LastName = "Lee";

            //Serialize simple class
            Serialize(simplePerson, @"simpleClass.xml");

            //Using customized root tag
            Serialize(rootPerson, @"rootClass.xml");

            //Using customized tag
            Serialize(otherPerson, @"customizedTag.xml");

            //Using ignore tag
            Serialize(smartPerson, @"ignoreTag.xml");

            //Serialize a list of class
            Serialize(listPerson, @"listTag.xml");

            //Serialize a class contains other class
            Serialize(superSmartPerson, @"classContainsClass.xml");

            Console.WriteLine();
            Console.ReadLine();
        }

        static public void Serialize<T>(T obj, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof (T));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }
    }
}
