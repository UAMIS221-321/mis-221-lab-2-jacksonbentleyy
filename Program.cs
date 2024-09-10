//initialize variables (variables hold information that we assign to them)
int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwichCost = 0;
double totalToppingCost = 0;
double baseCost = 0;

//initialize constants (values that do not change/stay constant, all caps)
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

//prompt the user for # of sandwiches
//(WriteLine() displays information, ReadLine() receives info from user)
System.Console.WriteLine("How many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());
totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
System.Console.WriteLine("Sandwiches: "+numberOfSandwiches);
System.Console.WriteLine($"Sandwich subtotal: ${totalSandwichCost}");

//prompt the user for # of toppings
System.Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
System.Console.WriteLine("Toppings: "+numberOfToppings);
System.Console.WriteLine($"Toppings subtotal: ${totalToppingCost}");

//prompt the user for tip
System.Console.WriteLine("How much do you want to tip?");
tip = double.Parse(Console.ReadLine());
System.Console.WriteLine($"Tip: ${tip}");

//set variables equal to their respective values
baseCost = totalSandwichCost + totalToppingCost;

//calculate order cost + discount
double orderCost = tip + baseCost * (1 - DISCOUNT_AMOUNT);

//display cost
System.Console.WriteLine($"Your grand total is ${orderCost}!");