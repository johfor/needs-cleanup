using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUpTask
{

    public class VisionFileY
    {
        public bool[,] image = new bool[,] {
            { true, false, false, false, true },
            { true, false, false, false, true },
            { false, true, false, true, false },
            { false, false, true, false, false },
            { false, false, true, false, false },
            { false, false, true, false, false },
            { false, false, true, false, false },
        };

        private int CountFilledPixels()
        {
            int r = 0;
            for (var i = 0; i < image.GetLength(0); i++)
            {
                for (var j = 0; j < image.GetLength(1); j++)
                {
                    r = r + (image[i, j] ? 1 : 0);
                }
            }
            return r;
        }

        private int GetPixelCount()
        {
            return image.GetLength(0) * image.GetLength(1);
        }

        public void PrintStats()
        {
            var logger = new Logger();
            logger.Log($"pixels: " + GetPixelCount());
            logger.Log($"filled pixels: " + CountFilledPixels());
            logger.Log($"filled: " + Math.Round(CountFilledPixels() / (decimal)GetPixelCount(), 4).ToString("P"));
        }
    }
}
