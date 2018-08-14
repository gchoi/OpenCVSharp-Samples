using OpenCvSharp;

namespace OpenCVSharpSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            var src = new Mat(@"D:\Projects\COGNEX\SDC-LaserCut\Samples\20180601\BPL_CUT_Normal\OK_A3NE1Q7CVC1AP020_R2_2018-05-15_22-12-28-2211.jpg", ImreadModes.Unchanged);
            var flipped = src.Flip(0);

            using (var window = new Window("window", image: flipped, flags: WindowMode.AutoSize))
            {
                Cv2.WaitKey();
            }
        }

    }
}