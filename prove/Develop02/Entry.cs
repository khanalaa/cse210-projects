/* 
Aayush Khanal
Discription: This program gets entry like date, prompt, location and respone then
        display it whenever needed.
*/

using System;

public class Entry
{
    public DateTime Date { get; set; } //Property for the date
    public string Prompt { get; set; } // Property for the prompt
    public string Location { get; set; } // Property for the location
    public string Response { get; set; } // Property for the response

    // Cronstructor to initialize an entry
    public Entry(DateTime _ak_date, string _ak_prompt, string _ak_location, string _ak_response)
    {
        // set the date, prompt, location and response
        Date = _ak_date; 
        Prompt = _ak_prompt;
        Location = _ak_location;
        Response = _ak_response;
    }

    // Method to display an entry
    public void Display()
    {   
        // Display the date, propmt, location and response
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public string GetResponse()
    {
        return Response;
    }
}