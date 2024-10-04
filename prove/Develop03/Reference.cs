public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;
        public Reference(string book, int chapter, int verse)
            {
                _book = book;
                _chapter = chapter;
                _verse = verse;
                _endVerse = 0;

            }
        public Reference(string book, int chapter, int startVerse, int endVerse)
            {
                _book = book;
                _chapter = chapter;
                _verse = startVerse;
                _endVerse = endVerse;
            }

        public string GetDisplayText()
            {
                string firstWord = _book.Substring(0, _book.IndexOf(' ')); 
                string noFirstWord = _book.Replace($"{firstWord} ", "");
                if (_endVerse == 0)
                    {
                        Console.WriteLine($"{firstWord} {_chapter}:{_verse} {noFirstWord}");

                    } 
                else
                    {
                        Console.WriteLine($"{firstWord} {_chapter}:{_verse}-{_endVerse} {noFirstWord}");
                    }
                
                return noFirstWord;
            }

    }