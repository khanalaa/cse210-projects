/*
Aayush Khanal
Purpose: To generate the random prompts, it stores prompt as List and give
        random List when needed.
*/

using System;
using System.Collections.Generic;

class Prompt{
    public List<string> _ak_prompt;

    public Prompt(){
        _ak_prompt = new List<string>();
    }
    // Method to generate a random prompt
    public string GeneratePrompt(){
        if (_ak_prompt.Count == 0){
            return "No prompts available"; // Return a message if there is not any prompts
        }
        Random random = new Random(); 
        int _ak_index = random.Next(_ak_prompt.Count); // Generate a random prompt
        return _ak_prompt[_ak_index]; // Return a randomly selected prompt
    }
}