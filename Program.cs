namespace inheritance_Brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {   // makes a new obj and set Esrd and title
            fighting myfighting = new fighting("T", "guilty gear");
            //calls the describe method from the game class useing the myfighting obj
            Console.WriteLine(myfighting.Describe());
           //calls the play game method
            myfighting.PlayGame();
        }
    }
}
