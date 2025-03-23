using TPModul6_103022300023;

class Program{
    static void Main()
    {

            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Muhammad Azwa Radya Razadisya");

            video.IncreasePlayCount(3);
            video.IncreasePlayCount(10);
            video.IncreasePlayCount(23);

            video.PrintVideoDetails();
    }
}