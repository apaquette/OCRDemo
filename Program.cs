using IronOcr;

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

string[] files = Directory.GetFiles("D:\\SETU\\Project C4\\Remote Energy Meter\\OCR Demo\\OCRDemo\\Photos_Cropped");
foreach(var file in files)
{
    ConvertToText(file);
}
