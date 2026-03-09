using System;
using System.Reflection;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>Prints properties and methods of an object</summary>
    /// <param name="myObj">The object to inspect</param>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();
        TypeInfo typeInfo = type.GetTypeInfo();

        Console.WriteLine("{0} Properties:", type.Name);
        foreach (PropertyInfo prop in typeInfo.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine("{0} Methods:", type.Name);
        foreach (MethodInfo method in typeInfo.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
