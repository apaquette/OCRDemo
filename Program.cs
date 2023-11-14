using IronOcr;
using OpenCvSharp;
using Emgu.CV.Text;

void ConvertToText(string imagePath)
{
    IronTesseract IronOcr = new();
    using(OcrInput input = new(imagePath))
    {
        input.DeNoise();
        input.Deskew();
        input.EnhanceResolution();
        //input.Contrast();
        input.Invert();
        var Result = IronOcr.Read(input);
        Console.WriteLine(Result.Text);
        Console.WriteLine("---------------------");
    }
}

void EdgeDetection(string imagePath)
{
    using var src = new Mat(imagePath);
    using var dst = new Mat();
    Cv2.Canny(src, dst, 50, 200);

    using (new Window("src image", src))
    using (new Window("dst image", dst))
    {
        Cv2.WaitKey();
    }
}

string[] files = Directory.GetFiles("D:\\SETU\\Project C4\\Remote Energy Meter\\OCR Demo\\OCRDemo\\Photos_Cropped");
EdgeDetection(files[2]);

//foreach(var file in files)
//{
//    EdgeDetection(file);
//    //ConvertToText(file);
//}
