namespace CleanUpTask
{
    public class VisionFileX
    {
        public bool[,] image = new bool[,] { 
            { true, false, false, false, true },
            { true, false, false, false, true },
            { false, true, false, true, false },
            { false, false, true, false, false },
            { false, true, false, true, false },
            { true, false, false, false, true },
            { true, false, false, false, true }, 
        };

        public int CountFilledPixels()
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

        public int GetPixelCount()
        {
            return image.GetLength(0) * image.GetLength(1);
        }

    }
}
