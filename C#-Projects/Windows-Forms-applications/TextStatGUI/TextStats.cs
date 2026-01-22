
using static System.Formats.Asn1.AsnWriter;
using System.Data;
using System.Net.NetworkInformation;
using System;

using System.Text.RegularExpressions;
using System.Linq;
using System.Reflection.Metadata;

public class TextStats {

    private string Text { get; set; }
    public int NumberOfSentences { get; private set; }
    public int NumberOfWords { get; private set; }
    public int NumberOfUniqueWords { get; private set; }
    public Dictionary<string, int> WordDictionary { get; private set; }


    public TextStats(string text) {
        this.Text = text;
    }

    // This method allows me to use the private methods and call them in the other class
    public void ProccessText() {
        AnalyzeText();
    }

    private void AnalyzeText() {

        // Splits the users text into a list
        List<string> splitText = new List<string>(Text.Split().ToList());

        // Counts the Number of Sentences base on the amount of Punctuations the Text has
        foreach (string word in splitText) {
            if (word.Contains("!") || word.Contains("?") || word.Contains(".") || word.Contains(";")) {
                NumberOfSentences++;
            }
        }

        RemovePunctuation();

        List<string> ModifiedText = new List<string>(Text.Split().ToList());

        NumberOfUniqueWords = ModifiedText.Distinct().Count(); 

        WordDictionary = new Dictionary<string, int>();

        foreach (string word in ModifiedText) {
            if (WordDictionary.ContainsKey(word)) {
                WordDictionary[word]++; // Counts amount of occurances 
            } else {
                WordDictionary.Add(word, 1); // Adds only the unique word to Dictonary to be only outputted
            }
        }

        WordDictionary = WordDictionary.OrderByDescending(sort => sort.Value).ToDictionary(); // sorts the num value of the dictonary
       
    }
    private void RemovePunctuation() {

        Text = Text.ToLower();

        Text = Regex.Replace(Text, @"[!?.',;]", ""); // Removes all the punctuation 
        Text = Regex.Replace(Text, "\\s+", " "); // Replaces one or more whitespace
                                                 // characters with just one so we dont miss extra spaces
        Text = Regex.Replace(Text, @"[1234567890]", "");


        List<string> splitText = new List<string>(Text.Split());
        
        NumberOfWords = splitText.Count;

    }
        

        
}
