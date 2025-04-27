using System.Diagnostics;

namespace BluePrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream("./01.sbp", FileMode.Create, FileAccess.ReadWrite);
            //BluePrintData data = new BluePrintData(fs);
            //BluePrintWriter writer = new BluePrintWriter(data);
            //writer.PrepareForWriting(10, 10, 10, CompressMode: 1);
            //writer.AddX(10);
            //writer.AddY(10);
            //writer.AddZ(10);
            //writer.AddBlockPattle("stone");
            //writer.AddBlockPattle("stone");
            //writer.AddBlockPattle("stone");
            //writer.PlaceBlockWithData("stone", 0);
            //writer.XPP();
            //writer.PlaceBlock("stone");
            //writer.AutoAddX(10002);
            //writer.PlaceBlock("stone");
            //writer.End();

            FileStream fs = new FileStream("./01.sbp", FileMode.Open, FileAccess.Read);
            BluePrintData bpdata = new BluePrintData(fs);
            BluePrintReader reader = new BluePrintReader(bpdata, true);
            reader.OnPlaceBlockWithData_CraftingID = (string craftingId, int data) =>
            {
                var x = bpdata.X;
                Debugger.Break();
            };
            reader.OnPlaceBlock_CraftingID = (string craftingId) =>
            {
                var x = bpdata.X;
                Debugger.Break();
            };
            reader.PrepareForReading();


            reader.ReadFileHeader();
            reader.ReadFormatHeader();
            reader.ReadToEnd();


            reader.ReadFormatHeader();
            reader.ReadToEnd();
        }
    }
}
