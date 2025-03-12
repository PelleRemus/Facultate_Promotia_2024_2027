using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SortariVizual
{
    public static class Engine
    {
        public static PictureBox display;
        public static TextBox textBox;
        public static Stopwatch stopWatch;

        public static void Initialize(PictureBox pb, TextBox tb)
        {
            display = pb;
            textBox = tb;
            Resources.GenerateRainbow();
            Resources.ShowRainbow();
        }

        public static void Swap(int i, int j)
        {
            (Resources.rainbow[i], Resources.rainbow[j]) = (Resources.rainbow[j], Resources.rainbow[i]);
            UpdatePositionsVisually(i, j);
        }

        public static void UpdatePositionsVisually(int i, int j)
        {
            Resources.ShowRainbow();
            Resources.DrawBlack(i);
            Resources.DrawBlack(j);
            display.Update();
            UpdateStopWatch();
        }

        public static void Shuffle()
        {
            Random r = new Random();
            for (int i = 1; i < Resources.n; i++)
            {
                int index = r.Next(i);
                Swap(i, index);
            }
        }

        public static void Bubble()
        {
            bool hasSwapped;
            do
            {
                hasSwapped = false;
                for (int i = 0; i < Resources.n - 1; i++)
                {
                    if (Resources.rainbow[i].value > Resources.rainbow[i + 1].value)
                    {
                        hasSwapped = true;
                        Swap(i, i + 1);
                    }
                }
            } while (hasSwapped);
        }

        public static void Insertion()
        {
            for (int i = 1; i < Resources.n; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (Resources.rainbow[j].value > Resources.rainbow[j + 1].value)
                    {
                        Swap(j, j + 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void Selection()
        {
            for (int i = 0; i < Resources.n; i++)
            {
                int min = i;
                for (int j = i; j < Resources.n; j++)
                {
                    if (Resources.rainbow[j].value < Resources.rainbow[min].value)
                    {
                        min = j;
                    }
                    UpdatePositionsVisually(i, j);
                }
                Swap(i, min);
            }
        }

        public static void QuickSort(int left, int right)
        {
        }

        public static void RestartStopwatch()
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        public static void UpdateStopWatch()
        {
            float timeInSeconds = (float)stopWatch.ElapsedMilliseconds / 1000;
            textBox.Text = $"{timeInSeconds.ToString("0.000")} s";
            textBox.Update();
        }

        public static void StopStopWatch()
        {
            stopWatch.Stop();
        }
    }
}