public class Video
    {
        public string _title;
        public string _author;

        public int _lenght; 

        public List<Comment> _comments = new();


        public Video(string title, string author, int length)
            {
                _title = title;
                _author = author;
                _lenght = length * 60;// convert the minutes in seconds
                _comments = new();
            }
        public int NumberComments()
            {
                int count = 0;
                foreach (Comment comment in _comments)
                    {
                        count += 1;
                    }
                return count;
            }

    }


