/*
Aayush Khanal
Discription: This manages the journal, it display, save and load the journal saved
        in file.
*/

using System;
using System.Collections.Generic;
using System.IO;

class Journal {
    // attributes of this class
    private string _ak_username; 
    private List<Entry> _ak_entries;
    private string _ak_filename;

    // Constructor to initialize a journal with a username
    public Journal(string _ak_username){
        this._ak_username = _ak_username;
        _ak_entries = new List<Entry>();
        _ak_filename = "journal.txt";

        // Check if the journal.txt file exists, if not create one
        if(!File.Exists(_ak_filename)){
            File.Create(_ak_filename).Close();
        }
    }

    // Method to add a new entry to the journal
    public void AddEntry(DateTime _ak_date, string _ak_prompt, string _ak_location, string _ak_response)
    {
        Entry entry = new Entry(_ak_date, _ak_prompt, _ak_location, _ak_response);
        _ak_entries.Add(entry); // Add the entry to the list of _ak_entries
    }

    //Method to display all journal entries
    public void Display(){
        foreach (Entry entry in _ak_entries){
            entry.Display(); // Display each entries
        }
    }

    // Method to save journal entries to file
    public void SaveToFile(){
        using (StreamWriter writer = new StreamWriter("journal.txt")){
            foreach(Entry entry in _ak_entries){
                // Write each entry's details to the file
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"Location: {entry.Location}");
                writer.WriteLine($"Response: {entry.Response}");
                writer.WriteLine();
            }
        }
    }

    // Method to load journal entries from a file
    public void LoadFromFile(){
        if(File.Exists(_ak_filename)){
            _ak_entries.Clear(); // Clear existing entries
            using (StreamReader reader = new StreamReader(_ak_filename)){
                while (!reader.EndOfStream){
                    DateTime _ak_date = DateTime.Parse(reader.ReadLine().Substring(6));
                    string _ak_prompt = reader.ReadLine();
                    string _ak_location = reader.ReadLine();
                    string _ak_response = reader.ReadLine();

                    Entry entry = new Entry(_ak_date, _ak_prompt, _ak_location, _ak_response);
                    _ak_entries.Add(entry); // Add the entry to the list of _ak_entries

                    reader.ReadLine(); // Consume the empty line
                }
            }
        }
    }
    public string GetUserName(){
        return _ak_username; // return the username
    }
}