public class Word 
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
            {
                _text = text;
                _isHidden = false;
            }
        public void Hide ()
            {
                if (!_isHidden)
                    {
                        _isHidden = true;
                        for (int i = 0; i < _text.Length; i++)
                                    {
                                        _text = _text.Replace(_text[i], '_');
                                    }
                    }
            }
        public void Show ()
            {
                if (!_isHidden)
                    {
                        _isHidden = false;
                    }
            }
        public bool IsHidden ()
            {
                if (_isHidden == true)
                    {
                        return true;
                    }
                else
                    {
                        return false;
                    }
            }
        public string GetDisplayText ()
            {
                return _text;
            }
    }