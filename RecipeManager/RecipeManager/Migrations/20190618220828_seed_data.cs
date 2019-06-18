using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeManager.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "ID", "Author", "CookTime", "Description", "IsSaved", "Notes", "ServingSize", "Title" },
                values: new object[,]
                {
                    { 1, "Clarice", null, "Tasty, tangy crackers", false, "Good for parties", 20, "Welcome Wafers" },
                    { 2, "Clarice", null, "Rice balls with a variety of toppings", false, null, 8, "Rice Balls" },
                    { 3, "Clarice", null, "It's a Ice Cream Sunday, it doesn't need a description", false, null, 2, "Ice Cream Sunday" },
                    { 4, "Clarice", null, "Traditional Rice and Broth dish from Louisiana", false, "Grandma's recipe", 8, "Chicken Gumbo" },
                    { 5, "Clarice", null, "Perfectly cooked chicken with a crispy skin", false, "Be wary of cook time. It can depend on the oven, or the size of the chicken.", 4, "Thyme Roasted Chicken" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "Name", "Notes", "Quantity", "RecipeID" },
                values: new object[,]
                {
                    { 1, "Oyster Crackers", null, "Two bags or 2 lbs", 1 },
                    { 21, "White Wine", "Optional", "1 cup", 5 },
                    { 23, "Whole, raw chicken", null, "One", 5 },
                    { 20, "Fresh Thyme", null, "4-6 sprigs", 5 },
                    { 19, "Butter", null, "1/2 cup", 5 },
                    { 18, "Chicken stock", "Home made is better", "6 qts", 4 },
                    { 17, "Onion", null, "1 large", 4 },
                    { 16, "Oil or Butter, or other fat", "I prefer butter", "1/2 cup", 4 },
                    { 15, "Flour", null, "1/2 cup", 4 },
                    { 14, "Whole, roasted, broken down chicken", null, "One", 4 },
                    { 13, "Marichino Cherry", null, "2", 3 },
                    { 12, "Sprinkles", null, "To Taste", 3 },
                    { 10, "Your favorite Ice Cream", null, "1 pint or 6 scoops", 3 },
                    { 9, "Seaweed", null, "4 sheets, cut in half", 2 },
                    { 11, "Chocolate Fudge Sauce", "Heated slightly", "1/2 cup", 3 },
                    { 2, "Tony Chachere's", "A louisianan seasoning", "1 tbsp", 1 },
                    { 7, "Salted Salmon", null, "4 oz", 2 },
                    { 3, "Lemon Pepper", null, "1 tsp", 1 },
                    { 6, "Uncooked Sushi Rice", null, "2 cups", 2 },
                    { 4, "Dill", "dried works best", "3 tbsp", 1 },
                    { 5, "Ranch Dressing Packet", "I like hidden valley", "1", 1 },
                    { 22, "Vegitable Oil", null, "1/2 cup", 1 },
                    { 8, "Pickled Plums / Umeboshi", null, "2 - 3 depending on how much you like pickled plum", 2 }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "RecipeID", "StepNumber", "Detail" },
                values: new object[,]
                {
                    { 2, 1, "Cook rice according to manufacturer instructions, or in a rice cooker. While rice is cooking, bake salted salmon at 350 degrees for 15 minutes or until done." },
                    { 5, 2, "Once butter is cool enough to touch, carefully coat chicken in the thyme butter. If possible, get the butter under the skin as well. Reserve leftover butter." },
                    { 5, 1, "Prehead oven to 350. In a small pan, add butter and thyme leaves. Remove from heat once butter is completely melted, and allow to cool slightly" },
                    { 4, 3, "Add chicken, and salt to taste. Serve over rice with Gumbo File" },
                    { 4, 2, "Once onions are cooked, add in 1/2 cup of chicken stock. Stir until there are no lumps. Gradually add the rest of the chicken stock. Bring to a boil and allow to cook until all flavors have mingled (20 minutes)" },
                    { 4, 1, "In a large, thick bottomed pot, add butter and flour. Stir constantly over medium heat until flour becomes a dark golden brown. Add chopped onions. Cook until onions are tender." },
                    { 1, 2, "Mix together Ranch, Lemon Pepper, Tony Chachere's, and Dill" },
                    { 1, 3, "Pour crackers into 9 X 13 pan. Mix crackers and oil" },
                    { 1, 4, "Add seasoning to oiled crackers. Mix well" },
                    { 3, 3, "Add a cherry on top and enjoy!" },
                    { 3, 2, "Pour chocolate sauce over ice cream. Sprinkle on the sprinkles." },
                    { 3, 1, "Scoop IceCream into two bowls, three scoops each." },
                    { 1, 5, "Bake for 15 minutes, stirring frequently. Let cool before eating" },
                    { 5, 3, "Pour wine into a 2 and a half to three inch wide glass jar. Place the glass jar in a deep lipped baking sheet or pirex baking dish. Carefully slide the chicken onto the glass jar." },
                    { 2, 4, "When ready to eat, wrap rice ball in seaweed and enjoy." },
                    { 2, 3, "Dip hands in water, then coat in salt. Pick up a handful of rice slightly larger than a golf ball. (Note: Size isn't super important. If you want a larger rice ball, add more rice). Gently press rice flat into your hand, making a slight indent in the center of the rice. Add your filling (salmon or umeboshi). Add a golf ball sized peice of rice on top of filling and pack into a triangle shape" },
                    { 2, 2, "When rice is done cooking, remove from pot and transfer onto a baking sheet. Fan with a peice of cardboard until rice is cool enough to touch. (But don't let it get cold.) While rice and fish are cooling, prepare a small bowl of salt and a bowl of water." },
                    { 1, 1, "Preheat oven to 325 degrees" },
                    { 5, 4, "Bake chicken for 30 minutes for each pound. Add more butter to chicken halfway through baking. Allow to rest before cutting." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumns: new[] { "RecipeID", "StepNumber" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
