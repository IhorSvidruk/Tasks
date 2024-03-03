using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //Task 1


    class ReflectFields
    {
        public static string Name;
        public static int MeasureX, MeasureY, MeasureZ;

        public static void OutputFields()
        {
            Type type = typeof(ReflectFields);
            foreach (FieldInfo fi in type.GetFields())
            {
                if (fi.FieldType.Name == "Int32")
                    Console.WriteLine($"{fi.Name} (int) = {fi.GetValue(fi)}");
                else
                    Console.WriteLine($"{fi.Name} (string) = {fi.GetValue(fi)}");

            }
        }

    }

    //Task 2


    class ReflectMethod
    {
        public static class Methods
        {
            public static void Hello(string parameter)
            {
                Console.WriteLine("Hello:parameter={0}", parameter);
            }

            public static void Welcome(string parameter)
            {
                Console.WriteLine("Welcome:parameter={0}", parameter);
            }

            public static void Bye(string parameter)
            {
                Console.WriteLine("Bye:parameter={0}", parameter);
            }

        }
        public static void InvokeMethod(string[] parameters)
        {
            var type = typeof(Methods).GetMethods(BindingFlags.Public | BindingFlags.Static);

            foreach (var mth in type)
            {
                foreach (var p in parameters)
                {
                    mth.Invoke(new object(), new object[] { p });
                }
            }
        }
    }

    //Task 3

    class ReflectProperties
    {
        public class TestProperties
        {
            public string FirstName { get; set; }
            internal string LastName { get; set; }
            protected int Age { get; set; }
            private string PhoneNumber { get; set; }
        }

        public static void WriteProperties()
        {
            var properties = typeof(TestProperties).GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (var property in properties)
            {
                Console.WriteLine($"Property name: {property.Name}");
                Console.WriteLine($"Property type: {property.PropertyType}");
                Console.WriteLine($"Read-Write:    {property.CanRead && property.CanWrite}");
                Dictionary<string, bool> dictionary = new Dictionary<string, bool>()
                {
                    { "Public", property.GetMethod.IsPublic },
                    { "Private", property.GetMethod.IsPrivate },
                    { "Protected", property.GetMethod.IsFamily },
                    { "Internal", property.GetMethod.IsAssembly },

                };
                Console.WriteLine($"Accessibility: {dictionary.First(f => f.Value == true).Key}\n");

            }
        }

    }

    //Task 4


    public class ReflectorAssembly
    {
        public class LargeBox
        {
            public static void UnPackingBox(string size) =>
                Console.WriteLine("I am unpacking {0} box.", size);

            public static void InBox(string size) =>
                Console.WriteLine("I am in {0} box.", size);

        }

        public class Box
        {
            public static void UnPackingBox(string size) =>
                Console.WriteLine("I am unpacking {0} box.", size);

            public static void InBox(string size) =>
                Console.WriteLine("I am in {0} box.", size);
        }

        public class SmallBox
        {
            public static void UnPackingBox(string size) =>
                Console.WriteLine("I am unpacking {0} box.", size);

            public static void InBox(string size) =>
                Console.WriteLine("I am in {0} box.", size);
        }

        public interface ILookingForBox
        {
            public void LookForBox(string size);
        }

        public interface IPackingBox
        {
            public void PackBox(string size);
        }

        public static void WriteAssemblies()
        {
            var types = Assembly.GetCallingAssembly().DefinedTypes;
            foreach (var type in types)
            {
                if (type.Name != "Reflector" && type.Name != "Task")
                {
                    string inType = "";
                    if (type.IsInterface)
                    {
                        inType = "Interface";
                    }
                    else
                    {
                        inType = "Class";
                    }

                    Console.WriteLine("{0}: {1}", inType, type.Name);
                    MethodInfo[] methodInfo = type.GetMethods(BindingFlags.Static | BindingFlags.Instance |
                                                              BindingFlags.Public | BindingFlags.DeclaredOnly);

                    foreach (MethodInfo item in methodInfo)
                    {
                        Console.WriteLine("Method: {0}", item.Name);
                        if (!item.Name.Contains("WriteAssemblies"))
                        {
                            if (type.Name.Contains("Small"))
                            {
                                item.Invoke(null, new object[] { "small" });
                            }
                            else if (type.Name.Contains("Large"))
                            {
                                item.Invoke(null, new object[] { "large" });
                            }
                            else if (type.Name == "Box")
                            {
                                item.Invoke(null, new object[] { "middle" });
                            }
                        }
                    }
                }

            }
        }

    }


    //Task 5


    public class ReflectFullClass
    {
        static ReflectFullClass()
        {
            WriteAllInClass(typeof(MyClass));
        }

        public static void WriteAllInClass(Type type)
        {
            Console.WriteLine($"Hello, {type.Name}!");

            var fields = type.GetFields();
            var properties = type.GetProperties();
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                              .Where(method => !method.Name.StartsWith("get_") && !method.Name.StartsWith("set_"));

            var interfaces = GetInterfacesWithExplicitImplementations(type);

            Console.WriteLine($"There are {fields.Length} fields in {type.Name}:");
            Console.WriteLine(string.Join(", ", fields.Select(field => field.Name)));

            Console.WriteLine($"There are {properties.Length} properties in {type.Name}:");
            Console.WriteLine(string.Join(", ", properties.Select(property => property.Name)));

            Console.WriteLine($"There are {methods.Count()} methods in {type.Name}:");
            Console.WriteLine(string.Join(", ", methods.Select(method => method.Name)));

            Console.WriteLine($"There are {interfaces.Count()} interfaces in {type.Name}:");
            Console.WriteLine(string.Join(", ", interfaces.Select(interfaceType => interfaceType.Name)));
        }

        private static List<Type> GetInterfacesWithExplicitImplementations(Type type)
        {
            var interfaces = type.GetInterfaces().ToList();

            foreach (var iface in interfaces.ToList())
            {
                var methods = iface.GetMethods();
                foreach (var method in methods)
                {
                    var explicitImplementation = type.GetInterfaceMap(iface).TargetMethods
                        .Any(targetMethod => targetMethod == method);

                    if (explicitImplementation)
                    {
                        interfaces.Remove(iface);
                        interfaces.Add(iface);
                        break;
                    }
                }
            }

            return interfaces;
        }
    }

    public class MyClass : ImyInterfaceOne, ImyInterfaceTwo, ImyInterfaceThree
    {
        public string myfieldOne = ""; // Initialize or mark as readonly
        public string myfieldTwo = ""; // Initialize or mark as readonly

        public int myPropertyOne { get; set; }
        public string myPropertyTwo { get; set; }
        public double myPropertyThree { get; set; }

        void ImyInterfaceOne.myMethodOne() { }
        void ImyInterfaceTwo.myMethodTwo() { }
    }

    public interface ImyInterfaceOne { void myMethodOne(); }
    public interface ImyInterfaceTwo { void myMethodTwo(); }
    public interface ImyInterfaceThree { }
}
