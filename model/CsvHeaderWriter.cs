using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConvertToCsv
{
    public class CsvHeaderWriter
    {
        public StreamWriter streamWriter;
        private Char delimiter;
        public CsvHeaderWriter(string pathFileName, char delimiter)
        {
            streamWriter = new StreamWriter(pathFileName, append: false, encoding: Encoding.UTF8);
            this.delimiter = delimiter;
        }

        public void WriteCsv<T>(List<T> listValue)
        {
            string texto = _prepareOfList(listValue);
            try
            {
                streamWriter.WriteLine(texto);
            }
            catch 
            {
                streamWriter.Close();
            }
        }

        private string _prepareOfList<T>(List<T> list)
        {
            string text= "";
            foreach (var item in list)
            {
                text += item + Convert.ToString(delimiter);                 
            }
            return text;
        }
    }
}
