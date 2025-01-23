class Program
{
    static void Main(string[] args)
    {

        Movie favoriteMovie = new Movie();
        favoriteMovie._title = "Star Wars: A New Hope";
        favoriteMovie._year = 1977;
        favoriteMovie._runtime = 121;
        favoriteMovie._rating = "PG";
        
        Movie otherMovie = new Movie();
        otherMovie._title = "Avatar";
        otherMovie._rating = "PG-13";
        otherMovie._runtime = 162;
        otherMovie._year = 2009;

        favoriteMovie.Display();

    }
    static void DisplayMovie(Movie aMovie)
    {
        Console.WriteLine($"(aMovie._title) -- (aMovie._year)");
    }
}