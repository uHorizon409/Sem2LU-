//Class
//Blueprint / template that defines the structure & behaviour that objects are created from
//User-defined datatypes serves as a proto-type for all objects
//Can have constructors & destructors

//~MethodName(){ }




//Objects
//instance of a class
//object will have its own set of properties dervied from the class template
// new keyword
// ClassName objectName = new ClassName();

Person person1 = new Person();
person1.Name = "John";
person1.Age = 30;
person1.Greet();

//Reference Type / Variables
//holds the reference (memory address) of an object
//does not hold the actual object data
//multiple references can point to the same object


Person person3 = new Person();
Person person2 = person3; //person2 now references the same object as person3
person3.Name = "Alice";
Console.WriteLine(person2.Name); //Output: Alice

person2.Age = 25;
Console.WriteLine(person3.Age); //Output: 25

public class Person
{
    //properties
    public string Name { get; set; }
    public int Age { get; set; }
    //method
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }

}
