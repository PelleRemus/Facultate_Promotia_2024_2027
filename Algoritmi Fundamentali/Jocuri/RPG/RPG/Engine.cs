﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RPG
{
    public static class Engine
    {
        public static Bitmap bitmap;
        public static Graphics graphics;
        public static Character player;
        public static MapObject pineapple;
        public static List<Ingredient> ingredients;
        public static int score = 0;

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
        public static List<string> burgerRequest;

        public static void Initialize()
        {
            player = new Character(new PointF(200, 200), 80, "../../Images/spongebob.png", 8);
            pineapple = new MapObject(new Point(100, 400), 200, 400, "../../Images/pineapple.png",
                "../../Images/pineapple_transparent.png");
            ingredients = new List<Ingredient>();
            random = new Random();
            CreateNewBurgerRequest();

            for (int i = 0; i < burgerRequest.Count; i++)
            {
                player.Burger.Push(new Ingredient(new Point(), 0, 0, burgerRequest[i]));
            }
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

            ingredients.Add(new Ingredient(new Point(x, y), 80, 20, ingredientNames[index]));
        }

        public static void CreateNewBurgerRequest()
        {
            burgerRequest = new List<string>();
            burgerRequest.Add(ingredientNames[0]);

            int nrOfIngredients = random.Next(3, 8);
            for (int i = 0; i < nrOfIngredients; i++)
            {
                int index = 1;
                do
                {
                    index = random.Next(1, 8);
                } while (burgerRequest.Contains(ingredientNames[index]));

                burgerRequest.Add(ingredientNames[index]);
            }
            burgerRequest.Add(ingredientNames.Last());

            var bitmap = new Bitmap(Form1.Instance.pictureBox3.Width, Form1.Instance.pictureBox3.Height);
            var graphics = Graphics.FromImage(bitmap);

            for (int i = 0; i < nrOfIngredients + 2; i++)
            {
                var ingredient = new Ingredient(new Point(), 0, 0, burgerRequest[i]);
                graphics.DrawImage(ingredient.Image, 0, (10 - i - 1) * 50, 200, 50);
            }
            Form1.Instance.pictureBox3.Image = bitmap;
        }

        public static bool CheckIfBurgersAreTheSame()
        {
            string[] currentBurger = player.Burger.Select(x => x.Name).Reverse().ToArray();
            if (currentBurger.Length != burgerRequest.Count)
            {
                return false;
            }

            for (int i = 0; i < currentBurger.Length; i++)
            {
                if (currentBurger[i] != burgerRequest[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void ServeBurger()
        {
            if (CheckIfBurgersAreTheSame())
            {
                CreateNewBurgerRequest();
                player.Burger.Clear();
                score += 100;
                Form1.Instance.label3.Text = $"Score: {score}";
            }
        }
    }
}
