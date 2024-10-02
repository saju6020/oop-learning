class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }

    public void Display() =>
        Console.WriteLine($"Pizza with {Dough} dough, {Sauce} sauce, and {Topping} topping.");
}

class PizzaBuilder
{
    private Pizza pizza;

    public PizzaBuilder() => pizza = new Pizza();

    public PizzaBuilder AddDough(string dough)
    {
        pizza.Dough = dough;
        return this;
    }

    public PizzaBuilder AddSauce(string sauce)
    {
        pizza.Sauce = sauce;
        return this;
    }

    public PizzaBuilder AddTopping(string topping)
    {
        pizza.Topping = topping;
        return this;
    }

    public Pizza Build() => pizza;
}

// Client
class Program
{
    static void Main()
    {
        var pizza = new PizzaBuilder()
                        .AddDough("Thick")
                        .AddSauce("Tomato")
                        .AddTopping("Pepperoni")
                        .Build();
        pizza.Display();
    }
}
