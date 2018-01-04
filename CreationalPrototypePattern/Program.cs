﻿using PrototypePattern.CopyConstructors;
using PrototypePattern.CopyThroughSerialization;
using PrototypePattern.ICloneableIsBad;
using static System.Console;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // ICLONEABLE IS ILL-SPECIFIED

            //var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));

            //var jane = (Person)john.Clone();
            //jane.Address.HouseNumber = 321; // oops, John is now at 321

            //// this doesn't work
            ////var jane = john;

            //// but clone is typically shallow copy
            //jane.Names[0] = "Jane";

            //WriteLine(john);
            //WriteLine(jane);

            // COPY CONSTRUCTORS
            //var john = new Employee("John", new CopyConstructors.Address("123 London Road", "London", "UK"));

            ////var chris = john;
            //var chris = new Employee(john);

            //chris.Name = "Chris";
            //WriteLine(john); // oops, john is called chris
            //WriteLine(chris);

            // COPY THROUGH SERIALIZATION
            Foo foo = new Foo { Stuff = 42, Whatever = "abc" };

            //Foo foo2 = foo.DeepCopy(); // crashes without [Serializable]
            Foo foo2 = foo.DeepCopyXml();

            foo2.Whatever = "xyz";
            WriteLine(foo);
            WriteLine(foo2);

            ReadLine();
        }
    }
}
