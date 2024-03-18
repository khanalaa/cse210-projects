using System;

class Reference {
    private string _ak_reference; // Private field to store the scripture reference
    private string _ak_text;     // Private field to store the scripture text


    // Method to get the scripture text from the user
    public string getText(){
        Console.Write("Enter the text of the scripture you want to memorize: ");
        _ak_text = Console.ReadLine(); 
        return _ak_text; 
   }

   // Method to get the scripture reference from the user
   public string getReference(){
        Console.Write("Write the reference of the scripture: ");
        _ak_reference = Console.ReadLine(); 
        return _ak_reference;
   }
}