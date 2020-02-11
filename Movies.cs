using System;
namespace Lab_11
{
    public class Movies
    {



        public Movies(string category, string title)
        {
            Category = category;
            Title = title;
        }

        private string Category { get; set; }
        private string Title { get; set; }

        string[] category = { "Animated", "Drama", "Horror", "Sci-Fi" };


        Movies movie = new Movies("Animated", "Drama", "Horror", "Sci-Fi");

            if ("userIput" == movie.Category)
            {
                return movie
            }


            List < Movies > names = new List<Movies>()
{
                new Movies("Animated", "Toy Story"),
                new Movies("Animated", "Elmo's World")
                new Movies("Animated", "Bug's Life")

};


        List<Movies> names = new List<Movies>()
            {
                new Movies("Animated", "Toy Story"),
                new Movies("Animated", "Elmo's World")
                new Movies("Animated", "Bug's Life")

            };

    }








    }

}




