using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ProjectBD
{
    public partial class FormMain : Form
    {
        // состояние показа Объектов
        enum BodyViewType { Source, Scene, All };
        BodyViewType currentBodyView = BodyViewType.All;

        // строка соединения с БД
        string ConnectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WORK\Учёба\Работа\ProjectBD\ProjectBD\MyDataBase.mdf;Integrated Security=True";
        
        public FormMain()
        {
            InitializeComponent();
            FillSource();
            FillBody();
            FillScene();
        }

        // заполнение полей БД
        private void FillSource()
        {
            // сформировать строку запроса SQL
            string SqlText = "SELECT * FROM [Source]";

            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnectionStr);
            DataSet ds = new DataSet();

            da.Fill(ds, "[Source]");
            dataGrid_Source.DataSource = ds.Tables["[Source]"].DefaultView;
        }
        private void FillScene()
        {
            // сформировать строку запроса SQL
            string SqlText = "SELECT * FROM [Scene]";

            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnectionStr);
            DataSet ds = new DataSet();

            da.Fill(ds, "[Scene]");
            dataGrid_Scene.DataSource = ds.Tables["[Scene]"].DefaultView;
        }
        private void FillBody()
        {
            string SqlText;
            int index;
            string ID;

            // сформировать строку запроса SQL связанную с таблицей Источников
            if (currentBodyView == BodyViewType.Source)
            {
                index = dataGrid_Source.CurrentRow.Index;
                ID = dataGrid_Source[0, index].Value.ToString();

                SqlText = "SELECT * FROM [Body],[Source] WHERE (([Body].ID_Source = ";
                SqlText += ID + ") AND ([Source].ID_Source = " + ID + "))";
            }
            // сформировать строку запроса SQL связанную с таблицей Сцен
            else if (currentBodyView == BodyViewType.Scene)
            {
                index = dataGrid_Scene.CurrentRow.Index;
                ID = dataGrid_Scene[0, index].Value.ToString();

                SqlText = "SELECT * FROM [Body],[Scene] WHERE (([Body].ID_Scene = ";
                SqlText += ID + ") AND ([Scene].ID_Scene = " + ID + "))";
            }
            // сформировать обычную строку запроса SQL
            else
            {
                SqlText = "SELECT * FROM [Body]";
            }

            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnectionStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Body]");
            dataGrid_Body.DataSource = ds.Tables["[Body]"].DefaultView;
        }
        private void ShowAllBody(object sender, EventArgs e)
        {
            currentBodyView = BodyViewType.All;
            FillBody();
        }

        // метод для обработки команд запросов SQL
        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection cn;
            SqlCommand cmd;

            cn = new SqlConnection(ConnectionStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = SqlText;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        // Добавить Источник
        private void AddSource(object sender, EventArgs e)
        {
            string SqlText;
            FormSourceAdd f = new FormSourceAdd();

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Source] ([Name], [Address], [Description]) VALUES (";
                SqlText += "\'" + f.textBox_Name.Text + "\', ";
                SqlText += "\'" + f.textBox_Address.Text + "\', ";
                SqlText += "\'" + f.richTextBox_Description.Text + "\')";

                MyExecuteNonQuery(SqlText);
                FillSource();
            }
        }
        // Редактировать Источник
        private void EditSource(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Source] SET ";
            string ID_Source, name, address, description;

            n = dataGrid_Source.Rows.Count;
            if (n == 1) return;

            FormSourceEdit f = new FormSourceEdit();

            index = dataGrid_Source.CurrentRow.Index;
            ID_Source = dataGrid_Source[0, index].Value.ToString();
            name = dataGrid_Source[1, index].Value.ToString().Trim();
            address = dataGrid_Source[2, index].Value.ToString().Trim();
            description = dataGrid_Source[3, index].Value.ToString().Trim();

            f.textBox_Name.Text = name;
            f.textBox_Address.Text = address;
            f.richTextBox_Description.Text = description;

            if (f.ShowDialog() == DialogResult.OK)
            {
                name = f.textBox_Name.Text;
                address = f.textBox_Address.Text;
                description = f.richTextBox_Description.Text;
                SqlText += "Name = \'" + name + "\', Address = \'" + address + "\', Description = \'" + description + "\' ";
                SqlText += "WHERE [Source].ID_Source = " + ID_Source;
                MyExecuteNonQuery(SqlText);
                FillSource();
            }
        }
        // Удалить Источник
        private void DeleteSource(object sender, EventArgs e)
        {
            int index, n;
            string ID_Source;
            string name;
            string SqlText = "DELETE FROM [Source] WHERE [Source].ID_Source = ";

            n = dataGrid_Source.Rows.Count;
            if (n == 1) return;

            FormSourceDelete f = new FormSourceDelete();

            index = dataGrid_Source.CurrentRow.Index;
            ID_Source = dataGrid_Source[0, index].Value.ToString();

            SqlText += ID_Source;

            name = dataGrid_Source[1, index].Value.ToString().Trim();
            f.label.Text = ID_Source + " - " + name;

            if (f.ShowDialog() == DialogResult.OK)
            {
                MyExecuteNonQuery(SqlText);
                FillSource();
            }
        }


        // Добавить Тело
        private void AddBody(object sender, EventArgs e)
        {
            string SqlText;
            int index;
            string ID_Source;
            string ID_Scene;

            FormBodyAdd f = new FormBodyAdd();

            // Source COMBOBOX
            index = dataGrid_Source.CurrentRow.Index;
            ID_Source = dataGrid_Source[0, index].Value.ToString();

            f.textBox_PosX.Text = 0.0f.ToString();
            f.textBox_PosY.Text = 0.0f.ToString();
            f.textBox_PosZ.Text = 0.0f.ToString();
            f.textBox_RotX.Text = 0.0f.ToString();
            f.textBox_RotY.Text = 0.0f.ToString();
            f.textBox_RotZ.Text = 0.0f.ToString();
            f.textBox_SclX.Text = 1.0f.ToString();
            f.textBox_SclY.Text = 1.0f.ToString();
            f.textBox_SclZ.Text = 1.0f.ToString();

            // Source COMBOBOX
            for (int i = 0; i < dataGrid_Source.RowCount - 1; i++)
                f.comboBox_Source.Items.Add(dataGrid_Source[1, i].Value.ToString().Trim());
            f.comboBox_Source.SelectedIndex = index;

            f.textBox_Name.Text = dataGrid_Source[1, index].Value.ToString().Trim();

            // Scene COMBOBOX
            index = dataGrid_Scene.CurrentRow.Index;
            ID_Scene = dataGrid_Scene[0, index].Value.ToString();

            for (int i = 0; i < dataGrid_Scene.RowCount - 1; i++)
                f.comboBox_Scene.Items.Add(dataGrid_Scene[1, i].Value.ToString().Trim());
            f.comboBox_Scene.SelectedIndex = index;

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Body] ([Name], [ID_Source], [ID_Scene], [PositionX], [PositionY], [PositionZ], [RotationX], [RotationY], [RotationZ], [ScaleX], [ScaleY], [ScaleZ]) VALUES (";

                SqlText += "\'" + f.textBox_Name.Text + "\', ";

                SqlText += dataGrid_Source[0, f.comboBox_Source.SelectedIndex].Value.ToString() + ", ";
                SqlText += dataGrid_Scene[0, f.comboBox_Scene.SelectedIndex].Value.ToString() + ", ";

                SqlText += "\'" + f.textBox_PosX.Text + "\', ";
                SqlText += "\'" + f.textBox_PosY.Text + "\', ";
                SqlText += "\'" + f.textBox_PosZ.Text + "\', ";

                SqlText += "\'" + f.textBox_RotX.Text + "\', ";
                SqlText += "\'" + f.textBox_RotY.Text + "\', ";
                SqlText += "\'" + f.textBox_RotZ.Text + "\', ";

                SqlText += "\'" + f.textBox_SclX.Text + "\', ";
                SqlText += "\'" + f.textBox_SclY.Text + "\', ";
                SqlText += "\'" + f.textBox_SclZ.Text + "\')";

                MyExecuteNonQuery(SqlText);
                FillBody();
            }
        }
        // Редактировать тело
        private void EditBody(object sender, EventArgs e)
        {
            int index, n, tmpi;
            string SqlText = "UPDATE [Body] SET ";
            string ID_Body, name, ID_Source, ID_Scene, PosX, PosY, PosZ, RotX, RotY, RotZ, SclX, SclY, SclZ;

            n = dataGrid_Source.Rows.Count;
            if (n == 1) return;

            FormBodyEdit f = new FormBodyEdit();

            index = dataGrid_Body.CurrentRow.Index;
            ID_Body = dataGrid_Body[0, index].Value.ToString();
            name = dataGrid_Body[1, index].Value.ToString().Trim();
            ID_Source = dataGrid_Body[2, index].Value.ToString().Trim();
            ID_Scene = dataGrid_Body[3, index].Value.ToString().Trim();

            PosX = dataGrid_Body[4, index].Value.ToString().Trim();
            PosY = dataGrid_Body[5, index].Value.ToString().Trim();
            PosZ = dataGrid_Body[6, index].Value.ToString().Trim();
            RotX = dataGrid_Body[7, index].Value.ToString().Trim();
            RotY = dataGrid_Body[8, index].Value.ToString().Trim();
            RotZ = dataGrid_Body[9, index].Value.ToString().Trim();
            SclX = dataGrid_Body[10, index].Value.ToString().Trim();
            SclY = dataGrid_Body[11, index].Value.ToString().Trim();
            SclZ = dataGrid_Body[12, index].Value.ToString().Trim();

            f.textBox_Name.Text = name;

            // Source COMBOBOX
            for (int i = 0; i < dataGrid_Source.RowCount - 1; i++)
                f.comboBox_Source.Items.Add(dataGrid_Source[1, i].Value.ToString().Trim());
            for (tmpi = 0; dataGrid_Source[0, tmpi].Value.ToString() != dataGrid_Body[2, index].Value.ToString(); tmpi++) { }
            f.comboBox_Source.SelectedIndex = tmpi;

            // Scene COMBOBOX
            for (int i = 0; i < dataGrid_Scene.RowCount - 1; i++)
                f.comboBox_Scene.Items.Add(dataGrid_Scene[1, i].Value.ToString().Trim());
            for (tmpi = 0; dataGrid_Scene[0, tmpi].Value.ToString() != dataGrid_Body[3, index].Value.ToString(); tmpi++) { }
            f.comboBox_Scene.SelectedIndex = tmpi;

            f.textBox_PosX.Text = PosX;
            f.textBox_PosY.Text = PosY;
            f.textBox_PosZ.Text = PosZ;
            f.textBox_RotX.Text = RotX;
            f.textBox_RotY.Text = RotY;
            f.textBox_RotZ.Text = RotZ;
            f.textBox_SclX.Text = SclX;
            f.textBox_SclY.Text = SclY;
            f.textBox_SclZ.Text = SclZ;

            if (f.ShowDialog() == DialogResult.OK)
            {
                name = f.textBox_Name.Text;
                ID_Source = dataGrid_Source[0, f.comboBox_Source.SelectedIndex].Value.ToString();
                ID_Scene = dataGrid_Scene[0, f.comboBox_Scene.SelectedIndex].Value.ToString();

                PosX = f.textBox_PosX.Text;
                PosY = f.textBox_PosY.Text;
                PosZ = f.textBox_PosZ.Text;
                RotX = f.textBox_RotX.Text;
                RotY = f.textBox_RotY.Text;
                RotZ = f.textBox_RotZ.Text;
                SclX = f.textBox_SclX.Text;
                SclY = f.textBox_SclY.Text;
                SclZ = f.textBox_SclZ.Text;

                SqlText += "Name = \'" + name + "\', ID_Source = \'" + ID_Source + "\', ID_Scene = \'" + ID_Scene + "\', ";
                SqlText += "PositionX = \'" + PosX + "\', PositionY = \'" + PosY + "\', PositionZ = \'" + PosZ + "\', ";
                SqlText += "RotationX = \'" + RotX + "\', RotationY = \'" + RotY + "\', RotationZ = \'" + RotZ + "\', ";
                SqlText += "ScaleX = \'" + SclX + "\', ScaleY = \'" + SclY + "\', ScaleZ = \'" + SclZ + "\' ";
                SqlText += "WHERE [Body].ID_Body = " + ID_Body;
                MyExecuteNonQuery(SqlText);
                FillBody();
            }
        }
        // Удалить Тело
        private void DeleteBody(object sender, EventArgs e)
        {
            int index, n;
            string ID_Body;
            string name;
            string SqlText = "DELETE FROM [Body] WHERE [Body].ID_Body = ";

            n = dataGrid_Body.Rows.Count;
            if (n == 1) return;

            FormBodyDelete f = new FormBodyDelete();

            index = dataGrid_Body.CurrentRow.Index;
            ID_Body = dataGrid_Body[0, index].Value.ToString();

            SqlText += ID_Body;

            name = dataGrid_Body[1, index].Value.ToString().Trim();
            f.label.Text = name;

            if (f.ShowDialog() == DialogResult.OK)
            {
                MyExecuteNonQuery(SqlText);
                FillBody();
            }
        }

        // Добавить Сцену
        private void AddScene(object sender, EventArgs e)
        {
            string SqlText;
            FormSceneAdd f = new FormSceneAdd();

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Scene] ([Name], [Description]) VALUES (";
                SqlText += "\'" + f.textBox_Name.Text + "\', ";
                SqlText += "\'" + f.richTextBox_Description.Text + "\')";

                MyExecuteNonQuery(SqlText);
                FillScene();
            }
        }
        // Редактировать сцену
        private void EditScene(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Scene] SET ";
            string ID_Scene, name, description;

            n = dataGrid_Scene.Rows.Count;
            if (n == 1) return;

            FormSceneEdit f = new FormSceneEdit();

            index = dataGrid_Scene.CurrentRow.Index;
            ID_Scene = dataGrid_Scene[0, index].Value.ToString();
            name = dataGrid_Scene[1, index].Value.ToString().Trim();
            description = dataGrid_Scene[2, index].Value.ToString().Trim();

            f.textBox_Name.Text = name;
            f.richTextBox_Description.Text = description;

            if (f.ShowDialog() == DialogResult.OK)
            {
                name = f.textBox_Name.Text;
                description = f.richTextBox_Description.Text;
                SqlText += "Name = \'" + name + "\', Description = \'" + description + "\' ";
                SqlText += "WHERE [Scene].ID_Scene = " + ID_Scene;
                MyExecuteNonQuery(SqlText);
                FillScene();
            }
        }
        // Удалить сцену
        private void DeleteScene(object sender, EventArgs e)
        {
            int index, n;
            string ID_Scene;
            string name;
            string SqlText = "DELETE FROM [Scene] WHERE [Scene].ID_Scene = ";

            n = dataGrid_Scene.Rows.Count;
            if (n == 1) return;

            FormSceneDelete f = new FormSceneDelete();

            index = dataGrid_Scene.CurrentRow.Index;
            ID_Scene = dataGrid_Scene[0, index].Value.ToString();

            SqlText += ID_Scene;

            name = dataGrid_Scene[1, index].Value.ToString().Trim();
            f.label.Text = ID_Scene + " - " + name;

            if (f.ShowDialog() == DialogResult.OK)
            {
                MyExecuteNonQuery(SqlText);
                FillScene();
            }
        }

        // Обновить сетку тел
        private void dataGrid_Source_Click(object sender, EventArgs e)
        {
            int n = dataGrid_Source.RowCount;
            int row = dataGrid_Source.CurrentRow.Index;

            if (n == (row + 1)) return;
            currentBodyView = BodyViewType.Source;
            FillBody();
        }

        private void dataGrid_Scene_Click(object sender, EventArgs e)
        {
            int n = dataGrid_Scene.RowCount;
            int row = dataGrid_Scene.CurrentRow.Index;

            if (n == (row + 1)) return;
            currentBodyView = BodyViewType.Scene;
            FillBody();
        }
    }
}
