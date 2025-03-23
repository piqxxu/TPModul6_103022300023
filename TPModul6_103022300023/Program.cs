using TPModul6_103022300023;

class Program{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Azwa Radya Razadisya");

        for (int i = 0; i < 300; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        video.PrintVideoDetails();
    }   

}