namespace RS2Seminarski.WebAPI.Helpers
{
    public class FileHelper
    {
        public static byte[] ReadFile(string sPath)
        {
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader bReader = new BinaryReader(fStream);

            byte[] data = bReader.ReadBytes((int)numBytes);

            return data;
        }
    }
}
