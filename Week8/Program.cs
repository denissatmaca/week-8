
string[] tvShows = { "Firefly", "Office", "Last of Us", "Friends", "Twin Peaks", "House", "Stranger Things" };
string[] food = { "sushi", "pizza", "Chinese takeaway", "burger and chips", "chicken wings", "chips", "popcorn" };
string[] drinks = { "mineral water", "Coca-cola", "apple juice", "milk", "beer" };

string randomMovie = PickRandomFromArray(tvShows);
string randomFood = PickRandomFromArray(food);
string randomDrink = PickRandomFromArray(drinks);

Console.WriteLine($"I recommend you to watch {randomMovie} tonight ");
Console.WriteLine($"Order some {randomFood} and {randomDrink}.");

//PickRandomFromArray(tvShows);
//PickRandomFromArray(food);
//PickRandomFromArray(drinks);

//Random rnd = new Random();

//int randomIndex = rnd.Next(0, tvShows.Length);


//string randomMovie = tvShows[randomIndex];

//Console.WriteLine(randomMovie);

//randomIndex = rnd.Next(0,food.Length);
//string randomFood = food[randomIndex];
//Console.WriteLine(randomFood);

//randomIndex = rnd.Next(0, drinks.Length);   
//string randomDrink = drinks[randomIndex];
//Console.WriteLine(randomDrink);

static string  PickRandomFromArray(string[] someArray){
    Random rnd= new Random();
    
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomElement = someArray[randomIndex];
    return randomElement;
    
}