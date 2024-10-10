using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _listVideos = new();

        Video video1 = new Video("Shoes Confort","Josh Roca", 3);
        
        
        Comment comment1 = new Comment("Pedr0", "las mejores Zapatillas");
        
        Comment comment2 = new Comment("Ali__ana", "terrible producto"); 
        
        Comment comment3 = new Comment("Sphiaoxox", "my family and I, love this product");
        
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        
        Video video2 = new Video("Cosmetics Ze","Amelia Zambrano", 4);
        
        Comment comment4 = new Comment("Luc23", "I loved it since I saw it");
        Comment comment5 = new Comment("Marvf", "me encanto Muchas gracias");
        Comment comment6 = new Comment("twsf", "No bad");
        
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        
        Video video3 = new Video("ByeBye pores","Johanna Smith", 11);
        
        Comment comment7 = new Comment("Nzinc", "Pretty imprecive");
        Comment comment8 = new Comment("Ant00", "Best video EVER");
        Comment comment9 = new Comment("Luccia", "Awesome");
        Comment comment10 = new Comment("Lukas", "It works realy fast");
        
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        
        
        _listVideos.Add(video1);
        _listVideos.Add(video2);
        _listVideos.Add(video3);
        
        foreach(Video video in _listVideos)
            {
                //display the title, author, length, number of comments
                
                Console.WriteLine($"\n\ntitle: {video._title} author: {video._author} lenght: {video._length}(seconds) number of comments: {video.NumberComments()}");
                foreach(Comment comment in video._comments)
                    {
                        Console.WriteLine($"\ncommenter's name: {comment._peoplesName} text: {comment._textComment}");
                    }
            } 
    }
}