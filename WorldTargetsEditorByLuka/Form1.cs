using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WorldTargetsEditorByLuka
{
    public partial class Form1 : Form
    {
        [DllImport("Kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, int lpNumberOfBytesRead);
        public Form1()
        {
            InitializeComponent();
        }
        int Language = 1;
        List<int> SelectedRowIndexes;
        int RowIndex;
        Graphics gr;
        WorldTargetsFile Read;
        WorldTargetsFile Second;
        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void OpenSev1_Click(object sender, EventArgs e)
        {
            if(DialogOpenSev.ShowDialog() == DialogResult.OK)
            {
                Read = new WorldTargetsFile();
                Read.ReadSevFile(new BinaryReader(File.Open(DialogOpenSev.FileName,FileMode.Open)));
                SortPoints();
            }
        }
        private void OpenTxt1_Click(object sender, EventArgs e)
        {
            if(DialogOpenClt.ShowDialog() == DialogResult.OK)
            {
                Read = new WorldTargetsFile();
                Read.ReadTxtFile(new StreamReader(DialogOpenClt.FileName,Encoding.Unicode));
                SortPoints();
            }
        }
        public void SortPoints()
        {
            TeleportsGrid.Rows.Clear();
            for (int i = 0; i < Read.TeleportAmount; i++)
            {
                TeleportsGrid.Rows.Add(i + 1, Read.TeleportList[i].ID, Read.TeleportList[i].MapName);
            }
            TeleportsGrid_CurrentCellChanged(null, null);
        }
        private void TeleportsGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if(TeleportsGrid.CurrentRow!=null)
            {
                if(TeleportsGrid.CurrentRow.Index!=-1)
                {
                    RowIndex = TeleportsGrid.CurrentRow.Index;
                    SelectedRowIndexes = new List<int>();
                    foreach (DataGridViewRow item in TeleportsGrid.SelectedRows)
                    {
                        SelectedRowIndexes.Add(item.Index);
                    }
                    Name_textbox.Text = Read.TeleportList[RowIndex].MapName;
                    ID_textbox.Text = Read.TeleportList[RowIndex].ID.ToString();
                    MapId_textbox.Text = Read.TeleportList[RowIndex].MapId.ToString();
                    Group_textbox.Text = Read.TeleportList[RowIndex].GroupId.ToString();
                    X_textbox.Text = Read.TeleportList[RowIndex].X_position.ToString();
                    Y_textbox.Text = Read.TeleportList[RowIndex].Y_position.ToString();
                    Z_textbox.Text = Read.TeleportList[RowIndex].Z_position.ToString();
                    if (gr != null)
                    {
                        float X = ((Read.TeleportList[RowIndex].X_position) + (WorldMap.Image.Width / 2)) - 10;
                        float Y = (Math.Abs((Read.TeleportList[RowIndex].Z_position) - (WorldMap.Image.Height / 2))) - 8;
                        gr.DrawImage(WorldTargetsEditorByLuka.Properties.Resources.arrow, X, Y);
                        WorldMap.ScrollTo((Convert.ToInt32(Read.TeleportList[RowIndex].X_position + (WorldMap.Image.Width / 2))) - (WorldMap.DisplayRectangle.Width / 2), Convert.ToInt32(Math.Abs(Read.TeleportList[RowIndex].Z_position - (WorldMap.Image.Height / 2))) - (WorldMap.DisplayRectangle.Height / 2));
                        WorldMap.Refresh();

                    }
                }
            }
        }
        private void LoadMap_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Application.StartupPath+"\\World.jpg",FileMode.Open,FileAccess.Read,FileShare.Read);
            WorldMap.Image = Bitmap.FromStream(fs);
            gr = Graphics.FromImage(WorldMap.Image);
        }
        private void ID_textbox_Leave(object sender, EventArgs e)
        {
            if(Read!=null && SelectedRowIndexes.Count!=0)
            {
                Control co = sender as Control;
                switch (co.Name)
                {
                    case "Name_textbox":
                        {
                            foreach (int item in SelectedRowIndexes)
                            {
                                Read.TeleportList[item].MapName = Name_textbox.Text;
                                TeleportsGrid.Rows[item].Cells[2].Value = Name_textbox.Text;
                            }
                            break;
                        }
                    case "ID_textbox":
                        {
                            foreach (int item in SelectedRowIndexes)
                            {
                                int.TryParse(ID_textbox.Text, out  Read.TeleportList[item].ID);
                                TeleportsGrid.Rows[item].Cells[1].Value = ID_textbox.Text;
                            }
                            break;
                        }
                    case "MapId_textbox":
                        {
                            foreach (int item in SelectedRowIndexes)
                            {
                                int.TryParse(MapId_textbox.Text, out  Read.TeleportList[item].MapId);
                            }
                            break;
                        }
                    case "Group_textbox":
                        {
                            foreach (int item in SelectedRowIndexes)
                            {
                                int.TryParse(Group_textbox.Text, out  Read.TeleportList[item].GroupId);
                            }
                            break;
                        }
                    case "X_textbox":
                        {
                            foreach (int item in SelectedRowIndexes)
                            {
                                float.TryParse(X_textbox.Text, out  Read.TeleportList[item].X_position);
                            }
                            break;
                        }
                    case "Y_textbox":
                        {
                            foreach (int item in SelectedRowIndexes)
                            {
                                float.TryParse(Y_textbox.Text, out  Read.TeleportList[item].Y_position);
                            }
                            break;
                        }
                    case "Z_textbox":
                        {
                            foreach (int item in SelectedRowIndexes)
                            {
                                float.TryParse(Z_textbox.Text, out  Read.TeleportList[item].Z_position);
                            }
                            break;
                        }
                }
            }
        }
        private void ID_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ID_textbox_Leave(sender, new EventArgs());
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (Read != null && TeleportsGrid.Rows.Count > 0)
            {
                TeleportsGrid.ScrollBars = ScrollBars.None;
                SelectedRowIndexes = SelectedRowIndexes.OrderBy(z => z).ToList();
                foreach (var item in SelectedRowIndexes)
                {
                    Read.TeleportAmount++;
                    FileStructure fs = new FileStructure();
                    fs.ID = Read.TeleportList[item].ID;
                    fs.MapId = Read.TeleportList[item].MapId;
                    fs.MapName = Read.TeleportList[item].MapName;
                    fs.X_position = Read.TeleportList[item].X_position;
                    fs.Y_position = Read.TeleportList[item].Y_position;
                    fs.Z_position = Read.TeleportList[item].Z_position;
                    Read.TeleportList.Add(fs);
                    TeleportsGrid.Rows.Add(Read.TeleportAmount, TeleportsGrid.Rows[item].Cells[1].Value, TeleportsGrid.Rows[item].Cells[2].Value);
                }
                TeleportsGrid.ScrollBars = ScrollBars.Vertical;
                var RowsClone = SelectedRowIndexes;
                TeleportsGrid.CurrentCell = TeleportsGrid.Rows[TeleportsGrid.Rows.Count - 1].Cells[1];
                for (int i = 1; i <= RowsClone.Count; i++)
                {
                    TeleportsGrid.Rows[TeleportsGrid.Rows.Count - i].Selected = true;
                }
                TeleportsGrid_CurrentCellChanged(null, null);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if(Read!=null && TeleportsGrid.Rows.Count!=0)
            {
                SelectedRowIndexes = SelectedRowIndexes.OrderByDescending(z => z).ToList();
                TeleportsGrid.ScrollBars = ScrollBars.None;
                int IndexBeforeRemoving = SelectedRowIndexes.Min();
                TeleportsGrid.ClearSelection();
                Read.TeleportAmount -= SelectedRowIndexes.Count;
                foreach (var Index in SelectedRowIndexes)
                {
                    Read.TeleportList.RemoveAt(Index);
                    TeleportsGrid.Rows.RemoveAt(Index);
                }
                TeleportsGrid.ScrollBars = ScrollBars.Vertical;
                if (TeleportsGrid.Rows.Count > IndexBeforeRemoving)
                {
                    TeleportsGrid.CurrentCell = TeleportsGrid.Rows[IndexBeforeRemoving].Cells[1];
                    TeleportsGrid.FirstDisplayedScrollingRowIndex = IndexBeforeRemoving;
                }
                else if (TeleportsGrid.Rows.Count != 0)
                {
                    TeleportsGrid.CurrentCell = TeleportsGrid.Rows[TeleportsGrid.Rows.Count - 1].Cells[1];
                    TeleportsGrid.FirstDisplayedScrollingRowIndex = TeleportsGrid.Rows.Count - 1;
                }
                TeleportsGrid_CurrentCellChanged(null, null);

            }
        }
        private void SaveSev_Click(object sender, EventArgs e)
        {
            if (DialogSaveSev.ShowDialog() == DialogResult.OK)
            {
                Read.WriteSevFile(new BinaryWriter(File.Create(DialogSaveSev.FileName)));
                if(Language==1)
                MessageBox.Show("Файл успешно сохранен!!....", "World Targets Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("File has been successfully saved!!....", "World Targets Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void InsertCoordinatesFromGame_Click(object sender, EventArgs e)
        {
            ClassPosition cs = GetCoordinates();
            if (cs != null)
            {
                X_textbox.Text = cs.PosX.ToString();
                Y_textbox.Text = cs.PosY.ToString();
                Z_textbox.Text = cs.PosZ.ToString();
                ID_textbox_Leave(X_textbox,null);
                ID_textbox_Leave(Y_textbox,null);
                ID_textbox_Leave(Z_textbox,null);
            }
        }
        public ClassPosition GetCoordinates()
        {
            Process[] pname = Process.GetProcessesByName("elementclient");
            if (pname.Length == 0)
            {
                if (Language == 1)
                    MessageBox.Show("Клиент игры не запущен!!...", "Клиент", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (Language == 2)
                    MessageBox.Show("Game isn't running!!...", "Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
            {
                if (Version_Combobox.SelectedIndex != -1)
                {
                    int[] Adresses = new int[3];
                    int PX = 0;
                    int PY = 0;
                    int PZ = 0;
                    Process[] Procceses = Process.GetProcessesByName("elementclient");
                    IntPtr Process_name = (IntPtr)0;
                    if (Procceses.Length > 0)
                    {
                        Process_name = Procceses[0].Handle;
                    }
                    byte[] size = new byte[4];
                    int BaseOffset = 0;
                    switch (Version_Combobox.SelectedIndex)
                    {
                        case 0:
                            {
                                Adresses[0] = 0x00C0CDEC;
                                Adresses[1] = 0x00000034;
                                Adresses[2] = 0x0000131C;
                                PX = 0x0000017C;
                                PY = 0x00000180;
                                PZ = 0x00000184;
                                break;
                            }
                        case 1:
                            {
                                Adresses[0] = 0x00B280C4;
                                Adresses[1] = 0x00000034;
                                Adresses[2] = 0x000010E8;
                                PX = 0x0000017C;
                                PY = 0x00000180;
                                PZ = 0x00000184;
                                break;
                            }
                        case 2:
                            {
                                Adresses[0] = 0x00B9029C;
                                Adresses[1] = 0x00000034;
                                Adresses[2] = 0x000011D8;
                                PX = 0x0000017C;
                                PY = 0x00000180;
                                PZ = 0x00000184;
                                break;
                            }
                        case 3:
                            {
                                Adresses[0] = 0x00C0CDEC;
                                Adresses[1] = 0x00000034;
                                Adresses[2] = 0x0000131C;
                                PX = 0x00000180;
                                PY = 0x00000184;
                                PZ = 0x00000188;
                                break;
                            }
                        case 4:
                            {
                                Adresses[0] = 0x00C392CC;
                                Adresses[1] = 0x00000034;
                                Adresses[2] = 0x00001340;
                                PX = 0x00000180;
                                PY = 0x00000184;
                                PZ = 0x00000188;
                                break;
                            }
                        case 5:
                            {

                                Adresses[0] = 0x00C76DCC;
                                Adresses[1] = 0x0000002C;
                                Adresses[2] = 0x00001420;
                                PX = 0x00000180;
                                PY = 0x00000184;
                                PZ = 0x00000188;
                                break;
                            }
                        case 6:
                            {
                                Adresses[0] = 0x00C7D20C;
                                Adresses[1] = 0x0000002C;
                                Adresses[2] = 0x00001420;
                                PX = 0x00000180;
                                PY = 0x00000184;
                                PZ = 0x00000188;
                                break;
                            }
                        case 7:
                            {
                                Adresses[0] = 0x00DA433C;
                                Adresses[1] = 0x0000001C;
                                Adresses[2] = 0x00000028;
                                PX = 0x0000003C;
                                PY = 0x00000040;
                                PZ = 0x00000044;
                                break;
                            }
                    }
                    for (int h = 0; h < Adresses.Length; h++)
                    {
                        ReadProcessMemory((IntPtr)Process_name, ((IntPtr)(BaseOffset + Adresses[h])), size, 4, 0);
                        BaseOffset = BitConverter.ToInt32(size, 0);
                    }
                    ReadProcessMemory((IntPtr)Process_name, ((IntPtr)(BaseOffset + PX)), size, 4, 0);
                    float PosX = BitConverter.ToSingle(size, 0);
                    ReadProcessMemory((IntPtr)Process_name, ((IntPtr)(BaseOffset + PY)), size, 4, 0);
                    float PosY = BitConverter.ToSingle(size, 0);
                    ReadProcessMemory((IntPtr)Process_name, ((IntPtr)(BaseOffset + PZ)), size, 4, 0);
                    float PosZ = BitConverter.ToSingle(size, 0);
                    return new ClassPosition(PosX, PosY, PosZ);
                }
                else
                {
                    if(Language==1)
                    MessageBox.Show("Версия клиента не выбрана!!...", "World Targets Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Client version isn't chosen!!...", "World Targets Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }
        }
        private void LanguageChange(object sender, EventArgs e)
        {
            Control co = sender as Control;
            if(co.Name == "Russian")
            {
                Language = 1;
                файлToolStripMenuItem.Text = "Файл";
                OpenSev.Text = "Открыть World_Targets.sev";
                Opentxt.Text = "Открыть World_Targets.txt";
                SaveSev.Text = "Сохранить World_Targets.sev";
                SaveTxt.Text = "Сохранить World_Targets.txt";
                ExitApplication.Text = "Выйти";
                Add.Text = "Добавить";
                Delete.Text = "Удалить";
                LoadMap.Text = "Загрузить изображение(World)";
                InsertCoordinatesFromGame.Text = "Вставить корды с игры";
                label7.Text = "Версия клиента";
                groupBox2.Text = "Координаты";
                groupBox1.Text = "Основное";
                label2.Text = "ID карты:"; label2.Location = new Point(13, 45);
                label3.Text = "Группа:"; label3.Location = new Point(23, 66);
            }
            else
            {
                Language = 2;
                файлToolStripMenuItem.Text = "File";
                OpenSev.Text = "Open World_Targets.sev";
                Opentxt.Text = "Open World_Targets.txt";
                SaveSev.Text = "Save World_Targets.sev";
                SaveTxt.Text = "Save World_Targets.txt";
                ExitApplication.Text = "Exit";
                Add.Text = "Clone";
                Delete.Text = "Delete";
                LoadMap.Text = "Load Image(World)";
                InsertCoordinatesFromGame.Text = "Insert cords from game";
                label7.Text = "Client version";
                groupBox2.Text = "Coordinates";
                groupBox1.Text = "Default";
                label2.Text = "Map Id:"; label2.Location = new Point(25, 45);
                label3.Text = "Group:"; label3.Location = new Point(28, 66);
            }
        }
        private void SaveTxt1_Click(object sender, EventArgs e)
        {
            if(DialogSavetxt.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(DialogSavetxt.FileName,false,Encoding.Unicode);
                Read.WriteTxtFile(sw);
                sw.Close();
            }
        }

        private void loadSecondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                Second = new WorldTargetsFile();
                Second.ReadTxtFile(new StreamReader(ofd.FileName, Encoding.UTF8));
            }
        }

        private void changeNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Read.TeleportAmount; i++)
            {
                string name = Second.TeleportList.Find(t => t.ID == Read.TeleportList[i].ID).MapName;
                Read.TeleportList[i].MapName = name;

            }
        }
    }
    public class ClassPosition
    {
        public ClassPosition(float X, float Y, float Z)
        {
            this.PosX = X;
            this.PosY = Y;
            this.PosZ = Z;
        }
        public float PosX;
        public float PosY;
        public float PosZ;
    }
}
