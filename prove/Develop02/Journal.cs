
using System.IO;
public class Journal
    {
        public List<Entry> _entries = new List<Entry>(); 


        public void AddEntry(Entry newEntry)
            {
                newEntry = new Entry();
                PromptGenerator prompt = new PromptGenerator();
                newEntry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText); 
                newEntry._entryText = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();
                _entries.Add(newEntry);
            }
        public void DisplayAll()
            {
                foreach (Entry index in _entries )
                    {
                        index.Display();
                    }
            }
            
        public void SaveToFile(string file)
            {
                
                using (StreamWriter output = new StreamWriter(file))
                    {
                        

                        foreach (Entry index in _entries )
                            {
                                output.WriteLine($"{index._date}~{index._promptText}~{index._entryText}");
                            }
                        
                    }
            }
        public void LoadFromFile (string file)
            {   
                _entries.Clear();
                List<Entry> newjournal = new List<Entry>();
                string[] lines = System.IO.File.ReadAllLines(file);
                int countStrings = -1; 
                    foreach(string line in lines)
                        {   
                            countStrings += 1;
                            Entry newJournal = new();
                            newjournal.Add(newJournal);
                            string[] parts = line.Split("~");
                            newjournal[countStrings]._date = parts[0];
                            newjournal[countStrings]._promptText = parts[1];
                            newjournal[countStrings]._entryText = parts[2];
                        }
                _entries = newjournal;
            }
        
    }