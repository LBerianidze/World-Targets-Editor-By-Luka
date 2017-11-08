using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WorldTargetsEditorByLuka
{
    class FileStructure
    {
        public int ID;
        public int MapId;
        public string MapName = "";
        public float X_position;
        public float Y_position;
        public float Z_position;
        public int GroupId;
    }
    class WorldTargetsFile
    {
        public int TeleportAmount;
        public List<FileStructure> TeleportList;
        public void ReadSevFile(BinaryReader br)
        {
            TeleportList = new List<FileStructure>();
            TeleportAmount = br.ReadInt32();
            for(int i =0;i<TeleportAmount;i++)
            {
                FileStructure fs = new FileStructure();
                fs.ID = br.ReadInt32();
                fs.MapId = br.ReadInt32();
                fs.X_position = br.ReadSingle();
                fs.Y_position = br.ReadSingle();
                fs.Z_position = br.ReadSingle();
                fs.GroupId = br.ReadInt32();
                TeleportList.Add(fs);
            }
            br.Close();
        }
        public void ReadTxtFile(StreamReader sw)
        {
            TeleportList = new List<FileStructure>();
            try
            {
                while (true)
                {
                    string[] Point = sw.ReadLine().Split(new char[] { '\"' });
                    if (Point.Count() != 0)
                    {
                        FileStructure fs = new FileStructure();
                        int.TryParse(Point[0], out fs.ID);
                        fs.MapName = Point[1];
                        int.TryParse(Point[2], out fs.MapId);
                        string[] Positions = Point[3].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        float.TryParse(Positions[0].Replace('.', ','), out fs.X_position);
                        float.TryParse(Positions[1].Replace('.', ','), out fs.Y_position);
                        float.TryParse(Positions[2].Replace('.', ','), out fs.Z_position);
                        int.TryParse(Point[4], out fs.GroupId);
                        TeleportList.Add(fs);
                        TeleportAmount++;
                    }
                }
            }
            catch(Exception ex)
            {

            }
            sw.Close();
        }
        public void WriteSevFile(BinaryWriter bw)
        {
            bw.Write(TeleportAmount);
            for(int i = 0;i<TeleportAmount;i++)
            {
                bw.Write(TeleportList[i].ID);
                bw.Write(TeleportList[i].MapId);
                bw.Write(TeleportList[i].X_position);
                bw.Write(TeleportList[i].Y_position);
                bw.Write(TeleportList[i].Z_position);
                bw.Write(TeleportList[i].GroupId);
            }
            bw.Close();
        }
        public void WriteTxtFile(StreamWriter sw)
        {
            for(int i = 0;i<TeleportAmount;i++)
            {
                string X = TeleportList[i].X_position.ToString().Replace(",", ".");
                string Y = TeleportList[i].Y_position.ToString().Replace(",", ".");
                string Z = TeleportList[i].Z_position.ToString().Replace(",", ".");
                sw.WriteLine(string.Format("{0}\t\"{1}\"\t{2}\t\"{3},{4},{5}\"\t{6}",TeleportList[i].ID,TeleportList[i].MapName,TeleportList[i].MapId,X,Y,Z,TeleportList[i].GroupId));
            }
        }
    }
}
