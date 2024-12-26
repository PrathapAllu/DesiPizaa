using DesiPizza;
namespace DesiPizza.Client
{
    public static class AppDataProvider
    {
        public static List<PizzaSpecial> GetSpecials()
        {
            return new List<PizzaSpecial>
            {
                new PizzaSpecial { Id = 1, Name = "Bacon Delight", BasePrice = 12.99m, Description = "Premium bacon topped with mozzarella cheese", ImageUrl = "img/pizzas/bacon.jpg" },
                new PizzaSpecial { Id = 2, Name = "British Style", BasePrice = 11.99m, Description = "Classic British toppings on a perfectly baked crust", ImageUrl = "img/pizzas/brit.jpg" },
                new PizzaSpecial { Id = 3, Name = "Classic Cheese", BasePrice = 10.99m, Description = "Our signature cheese blend melted to perfection", ImageUrl = "img/pizzas/cheese.jpg" },
                new PizzaSpecial { Id = 4, Name = "Margherita", BasePrice = 11.99m, Description = "Fresh tomatoes and basil on a crispy crust", ImageUrl = "img/pizzas/margherita.jpg" },
                new PizzaSpecial { Id = 5, Name = "Meaty Special", BasePrice = 13.99m, Description = "A carnivore's delight with premium meat toppings", ImageUrl = "img/pizzas/meaty.jpg" },
                new PizzaSpecial { Id = 6, Name = "Mushroom Supreme", BasePrice = 11.99m, Description = "Savory mushrooms with herbs and cheese", ImageUrl = "img/pizzas/mushroom.jpg" },
                new PizzaSpecial { Id = 7, Name = "Pepperoni Classic", BasePrice = 12.99m, Description = "Spicy pepperoni with melted cheese", ImageUrl = "img/pizzas/pepperoni.jpg" },
                new PizzaSpecial { Id = 8, Name = "Garden Salad", BasePrice = 11.99m, Description = "Fresh vegetables and greens on our signature crust", ImageUrl = "img/pizzas/salad.jpg" }
            };
        }

        public static List<Topping> GetToppings()
        {
            return new List<Topping>
            {
                new Topping { Id = 1, Name = "Extra Cheese", Price = 2.50m },
                new Topping { Id = 2, Name = "Bacon", Price = 2.99m },
                new Topping { Id = 3, Name = "Mushroom", Price = 1.99m },
                new Topping { Id = 4, Name = "Pepperoni", Price = 2.50m },
                new Topping { Id = 5, Name = "Fresh Basil", Price = 1.50m },
                new Topping { Id = 6, Name = "Bell Peppers", Price = 1.50m },
                new Topping { Id = 7, Name = "Onions", Price = 1.50m },
                new Topping { Id = 8, Name = "Olives", Price = 1.99m }
            };
        }
    }
}