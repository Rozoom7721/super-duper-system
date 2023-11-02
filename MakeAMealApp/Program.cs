namespace MakeAMealApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meals meals = new Meals();
            List<Meals> mealList = new List<Meals>();
            
            Console.WriteLine("Hello, World!");
        }
        class Meals
        {
            public string mealName;
            public string mealDescription;
            public string mealRecipe;
            public int mealCal;

            public void Initialize(string name, string description, string recipe, int cal)
            {
                mealName = name;
                mealDescription = description;
                mealRecipe = recipe;
                mealCal = cal;
            }
        }
    }
}