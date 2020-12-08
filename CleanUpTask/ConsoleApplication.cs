using System;

namespace CleanUpTask
{
    public class ConsoleApplication
    {
        public void Run(string[] args)
        {
            var logger = new Logger();
            logger.Log("Count active pixels in imageX or imageY? press x or y and enter");

            var key = Console.ReadLine();
            while (!(key == "x" || key == "y")){
                logger.Log("invalid key. press x or y and enter");
                key = Console.ReadLine();
            }

            if(key == "x")
            {
                var visionFile = new VisionFileX();
                logger.Log("");
                for (var i = 0; i < visionFile.image.GetLength(0); i++)
                {
                    for (var j = 0; j < visionFile.image.GetLength(1); j++)
                    {
                        logger.Write(visionFile.image[i, j] ? "#" : " ");
                    }
                    logger.Write(System.Environment.NewLine);
                }
                logger.Log("");
                logger.Log($"pixels: " + visionFile.GetPixelCount());
                logger.Log($"filled pixels: " + visionFile.CountFilledPixels());
                logger.Log($"filled: " + Math.Round(visionFile.CountFilledPixels() / (decimal)visionFile.GetPixelCount(), 4).ToString("P"));
            }
            else
            {
                var visionFile = new VisionFileY();
                logger.Log("");
                for (var i = 0; i < visionFile.image.GetLength(0); i++)
                {
                    for (var j = 0; j < visionFile.image.GetLength(1); j++)
                    {
                        logger.Write(visionFile.image[i, j] ? "#" : " ");
                    }
                    logger.Write(System.Environment.NewLine);
                }
                logger.Log("");
                visionFile.PrintStats();
            }
        }
    }
}
