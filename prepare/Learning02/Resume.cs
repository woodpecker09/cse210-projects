public class Resume 
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        public void DisplayResume ()
            {
                Console.WriteLine($"Name: {_name}");

                 Console.WriteLine($"Jobs: ");                
                foreach (Job i in _jobs)
                    {
                        i.DisplayJobDetails ();
                    }
            }
    }