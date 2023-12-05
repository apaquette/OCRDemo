using IronOcr;

Rectangle contentArea = new(x: 385, y: 415, width: 280, height: 70);

void ConvertToText(string imagePath)
{
    IronTesseract IronOcr = new();
    using(OcrInput input = new(imagePath, contentArea))
    {
        var Result = IronOcr.Read(input);
        Console.WriteLine(imagePath);
        Console.WriteLine(Result.Text);
        Console.WriteLine("---------------------");
    }
}

string[] files = Directory.GetFiles("D:\\SETU\\Project C4\\Remote Energy Meter\\OCR Demo\\OCRDemo\\Photos_Artificial\\Temp_artificial");
foreach (var file in files)
{
    ConvertToText(file);
}