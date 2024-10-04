public class Scripture 
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference Reference, string text)
            {
                
                string[] words = text.Split(' ');
 
                _words = new List<Word>();             
                foreach (string word in words)
                      {
                          
                          Word word1 = new Word(word);
                          _words.Add(word1);
                      }                                        
          
            }
        public void HideRandomWords(int numberToHide)
            {   
                _words[numberToHide].Hide();
                
            }

        
        public string GetDisplayText()
            {
                string oneString = "";

                foreach (Word word in _words)
                    {
                        oneString += $"{word.GetDisplayText()} ";
                    }                  
               
                return oneString;
            }
        public bool IsCompletelyHidden()
            {
                int finisher = 0; 

                foreach(Word word in _words)
                    {

                        if(!word.IsHidden())
                            {
                                finisher += 1;
                            }
                        else
                            {
                                finisher += 0;
                            }
                    }
                    return finisher > 0 ? true : false;

            }
    }