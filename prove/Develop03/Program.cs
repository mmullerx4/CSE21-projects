using System;

class Program
{

    static void Main(string[] args)
    {
        string text =  "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no  commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth the";
        // (*access type) (Class Type) (Object Name) = new (Constructor(Parameters))
        Reference reference = new Reference("1 Nephi", "3", "7", "8");
        Scripture scripture = new Scripture(text);
    }

}