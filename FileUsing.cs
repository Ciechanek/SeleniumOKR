using System.Text;
using System.IO;

namespace SeleniumAppCiechanMateuszOKR
{
    public class FileUsing
    {
        string filepath = "C:\\Users\\MateuszCiechan\\plik.txt";
        public void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        public string GetFilepath()
        {
            return filepath;
        }
    }
}