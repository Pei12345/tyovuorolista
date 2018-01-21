using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyovuoroLista.DAL
{
    public class PeriodiDAL
    {
        public static DataTable LoadBinaryFileToDataTable(string filePath)
        {
            try
            {
                DataTable dt;
                using (BinaryReader bw = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    int columns = bw.ReadInt32();
                    int rows = bw.ReadInt32();

                    dt = CreateEmptyDataTable(columns, rows);

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (bw.ReadBoolean())
                            {
                                dt.Rows[i][j] = bw.ReadString();
                            }
                            else bw.ReadBoolean();
                        }
                    }
                }
                return dt;
            }
            catch { }
            return null;
            
        }

        private static DataTable CreateEmptyDataTable(int columns, int rows)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < columns; i++)
            {
                dt.Columns.Add();
            }

            for (int i = 0; i < rows; i++)
            {
                dt.Rows.Add();
            }
            return dt;
        }

        public static void SaveDataTableToBinaryFile(DataTable dataTableToSave, string filePath)
        {
            try {                
                using (BinaryWriter bw = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    bw.Write(dataTableToSave.Columns.Count);
                    bw.Write(dataTableToSave.Rows.Count);
                    foreach (DataRow dr in dataTableToSave.Rows)
                    {
                        for (int j = 0; j < dataTableToSave.Columns.Count; j++)
                        {
                            object val = dr[j];
                            if (val == null)
                            {
                                bw.Write(false);
                                bw.Write(false);
                            }
                            else
                            {
                                bw.Write(true);
                                bw.Write(val.ToString());
                            }
                        }
                    }
                }
            }
            catch { }
        }

        public static string[] GetSavedPeriodFilePaths()
        {
            string[] periodiKansio = Directory.GetFiles(".\\Periodit\\");
            return periodiKansio;
        }


        public static void SaveDictionaryToFile(Dictionary<string, string> comments, string file)
        {
            try
            {
                var binaryFormatter = new BinaryFormatter();
                var targetFile = new FileInfo(".\\kommentit\\comments_" + file);

                using (var binaryFile = targetFile.Create())
                {
                    binaryFormatter.Serialize(binaryFile, comments);
                    binaryFile.Flush();
                }
            }
            catch (Exception) { }
        }

        public static Dictionary<string, string> LoadDictionaryFromFile(string file)
        {
            try {
                var binaryFormatter = new BinaryFormatter();
                var targetFile = new FileInfo(".\\kommentit\\comments_" + file);

                using (var binaryFile = targetFile.OpenRead())
                {
                    return (Dictionary<string, string>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch(Exception) { return new Dictionary<string, string>(); }
        }

        public static List<string> LoadPeriodSkeletonFile()
        {
            try
            {
                string file = ".\\shiftSkeleton.txt";
                List<string> list = new List<string>();

                if (File.Exists(file))
                    foreach (string line in File.ReadLines(file))
                    {
                        list.Add(line);
                    }
                else
                    File.Create(file);

                return list;
            }
            catch { return null; }
        }        
    }
}
