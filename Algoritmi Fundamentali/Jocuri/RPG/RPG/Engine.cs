using System;
using System.Collections.Generic;
using System.Drawing;

namespace RPG
{
    public static class Engine
    {
        public static Bitmap bitmap;
        public static Graphics graphics;
        public static Character player;
        public static MapObject pineapple;
        public static List<Ingredient> ingredients;

        public static Random random;
        public static Color backgroundColor = Color.CornflowerBlue;
        public static string[] ingredientNames = new string[]
        {
            "bottom_bun",
            "tomatoes",
            "salad",
            "onions",
            "patty",
            "bacon",
            "cheese",
            "pickles",
            "top_bun",
        };

        public static void Initialize()
        {
            player = new Character(new PointF(200, 200), 80, "../../Images/spongebob.png", 8);
            pineapple = new MapObject(new Point(100, 400), 200, 400, "../../Images/pineapple.png",
                "../../Images/pineapple_transparent.png");
            ingredients = new List<Ingredient>();
            random = new Random();
        }

        public static void Draw()
        {
            bitmap = new Bitmap(Form1.Instance.pictureBox1.Width, Form1.Instance.pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.Clear(backgroundColor);
            foreach (var ingredient in ingredients)
            {
                graphics.DrawImage(ingredient.Image, ingredient.Location.X,
                    ingredient.Location.Y, ingredient.Width, ingredient.Height);
            }

            graphics.DrawImage(player.Image, player.Location.X, player.Location.Y,
                player.Size, player.Size);

            pineapple.Draw(graphics);

            Form1.Instance.pictureBox1.Image = bitmap;
        }

        public static void AddRandomIngredient()
        {
            int index = random.Next(ingredientNames.Length);
            int x = random.Next(Form1.Instance.pictureBox1.Width - 80);
            int y = random.Next(Form1.Instance.pictureBox1.Height - 20);

            ingredients.Add(new Ingredient(new Point(x, y), 80, 20, $"../../Images/{ingredientNames[index]}.png"));
        }
    }
}
