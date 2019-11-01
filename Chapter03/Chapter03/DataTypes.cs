using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class DataTypes
    {
    /*
        static void Main(String[] args) {

            float a = 3.145_9262_3589_7932_386f;//float 형식 변수에 값을 할당할때 숫자 뒤에 f를 붙여줘야한다.
            Console.WriteLine($"float a={a}");

            double b = 3.145_9262_3589_7932_386;
            Console.WriteLine($"double b={b}");

            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m; // m을 붙이면 decimal
            //decimal 29자리 데이터를 표현할 수 있는 소수형식 16(128)비트 범위 +-1.0*10e-28+=7.9*10e28
            Console.WriteLine($"decimal c={c}");


            char d = '사';
            char e = '과';

            Console.Write($"char d ={d}");
            Console.Write($"char e = {e}");          
            Console.WriteLine(); // 줄바꿈

            char f = 'a';
            Console.Write($"ascii of 'a' { (int)f}"); // ascii 97 출력 형변환은 (datatype)
            Console.WriteLine();
            string g = "안녕하세요"; //string 형식은 데이터 범위가 정해져 있지 않고 들어오는 텍스트의 양에 따라 달라진다.
            Console.WriteLine($"string g ={g}");




            bool h = true;
            bool i = false;
            Console.WriteLine($"bool h ={h}");
            Console.WriteLine($"bool i ={i}");
            Console.WriteLine();



            Console.WriteLine("SIZE OF DATATYPE");
            Console.WriteLine($"size of sbyte = {sizeof(sbyte)}");   //1
            Console.WriteLine($"size of byte={sizeof(byte)}");    //1
            Console.WriteLine($"size of short={sizeof(short)}");   //2
            Console.WriteLine($"size of ushort={sizeof(ushort)}");  //2
            Console.WriteLine($"size of int={sizeof(int)}");  //4
            Console.WriteLine($"size of uint={sizeof(uint)}");   // 4
            Console.WriteLine($"size of long={sizeof(long)}");    //8
            Console.WriteLine($"size of ulong={sizeof(ulong)}");   //8
            Console.WriteLine($"size of char={sizeof(char)}");    //2
            Console.WriteLine($"size of float={sizeof(float)}");  // 4
            Console.WriteLine($"size of double={sizeof(double)}"); // 8
            Console.WriteLine($"size of decimal={sizeof(decimal)}"); //16
            Console.WriteLine($"size of bool={sizeof(bool)}");    //1
            Console.WriteLine();

            //  sizeof operator (C# reference)
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/sizeof



            //object형식 부모의 데이터 형식을 받아온다 object 형식으로  상속을 받는다

            object obj1 = 123;
            object obj2 = 3.14159265_358979_32846264338327m;
            object obj3 = true;
            object obj4 = "안녕하세요";

            Console.WriteLine($"obj1={obj1}");
            Console.WriteLine($"obj2={obj2}");
            Console.WriteLine($"obj3={obj3}");
            Console.WriteLine($"obj4={obj4}");
            






        }*/
        // Types and variables
        //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables


        /*
         There are two kinds of types in C#: value types and reference types.
         Variables of value types directly contain their data whereas variables of reference types store references to their data,
         the latter being known as objects. With reference types, it is possible for two variables to reference the same object 
         and thus possible for operations on one variable to affect the object referenced by the other variable. 
         With value types, the variables each have their own copy of the data, and it is not possible for
         operations on one to affect the other (except in the case of ref and out parameter variables).

C#’s value types are further divided into
simple types, enum types, struct types, and nullable value types.
C#’s reference types are further divided
into class types, interface types, array types, and delegate types.

The following provides an overview of C#’s type system.

Value types
Simple types
Signed integral: sbyte, short, int, long
Unsigned integral: byte, ushort, uint, ulong
Unicode characters: char
IEEE binary floating-point: float, double
High-precision decimal floating-point: decimal
Boolean: bool
Enum types
User-defined types of the form enum E {...}
Struct types
User-defined types of the form struct S {...}
Nullable value types
Extensions of all other value types with a null value
Reference types
Class types
Ultimate base class of all other types: object
Unicode strings: string
User-defined types of the form class C {...}
Interface types
User-defined types of the form interface I {...}
Array types
Single- and multi-dimensional, for example, int[] and int[,]
Delegate types
User-defined types of the form delegate int D(...)
For more information about numeric types, see Integral types and Floating-point types table.

C#’s bool type is used to represent Boolean values—values that are either true or false.

Character and string processing in C# uses Unicode encoding. The char type represents a UTF-16 code unit, and the string type represents a sequence of UTF-16 code units.

C# programs use type declarations to create new types.
A type declaration specifies the name and the members of the new type.
Five of C#’s categories of types are user-definable: class types, struct types, interface types, enum types, and delegate types.

A class type defines a data structure that contains data members (fields) and function members (methods, properties, and others). 
Class types support single inheritance and polymorphism, mechanisms whereby derived classes can extend and specialize base classes.

A struct type is similar to a class type in that it represents a structure with data members and function members.
However, unlike classes, structs are value types and do not typically require heap allocation.
Struct types do not support user-specified inheritance, and all struct types implicitly inherit from type object.

An interface type defines a contract as a named set of public function members.
A class or struct that implements an interface must provide implementations of the interface’s function members. 
An interface may inherit from multiple base interfaces, and a class or struct may implement multiple interfaces.

A delegate type represents references to methods with a particular parameter list and return type.
Delegates make it possible to treat methods as entities that can be assigned to variables and passed as parameters. 
Delegates are analogous to function types provided by functional languages. 
They are also similar to the concept of function pointers found in some other languages,
but unlike function pointers, delegates are object-oriented and type-safe.

The class, struct, interface and delegate types all support generics, whereby they can be parameterized with other types.

An enum type is a distinct type with named constants. 
Every enum type has an underlying type, which must be one of the eight integral types.
The set of values of an enum type is the same as the set of values of the underlying type.

C# supports single- and multi-dimensional arrays of any type.
Unlike the types listed above, array types do not have to be declared before they can be used.
Instead, array types are constructed by following a type name with square brackets.
For example, int[] is a single-dimensional array of int, int[,] is a two-dimensional array of int,
and int[][] is a single-dimensional array of single-dimensional array of int.

Nullable value types also do not have to be declared before they can be used.
For each non-nullable value type T there is a corresponding nullable value type T?,
which can hold an additional value, null. For instance, int? is a type that can hold any 32-bit integer or the value null.

C#’s type system is unified such that a value of any type can be treated as an object. 
Every type in C# directly or indirectly derives from the object class type,
and object is the ultimate base class of all types. 
Values of reference types are treated as objects simply by viewing the values as type object.
Values of value types are treated as objects by performing boxing and unboxing operations. 
In the following example, an int value is converted to object and back again to int.
         */
    }
}
