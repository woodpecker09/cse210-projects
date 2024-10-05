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
                          
                          Word newWord = new Word(word);
                          _words.Add(newWord);
                      }                                        
          
            }
        public void HideRandomWords(int numberToHide)
            {           
                        int count = _words.Count();
                        Random random = new Random();
                        int index = random.Next(2, count);
                        for (int i = 0; i < numberToHide; i++)
                            {
                                //I create this loop in order to know if the word was already hidden
                                //and if it was, it select another random number from the index
                                //until a new random index appers and is not a word that has been alreary hidden 
                                while(_words[index].IsHidden() && !IsCompletelyHidden())
                                    {
                                        index = random.Next(2, count);
                                    }
                                _words[index].Hide();
                            }
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
                if (finisher > 2)
                    {
                        return false;
                    }
                else
                    {
                        return true;
                    }
            }
    }