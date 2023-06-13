
namespace ProjectBD
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid_Source = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.источникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИсточникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сценыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid_Scene = new System.Windows.Forms.DataGridView();
            this.button_AddSource = new System.Windows.Forms.Button();
            this.button_DeleteSource = new System.Windows.Forms.Button();
            this.button_EditSource = new System.Windows.Forms.Button();
            this.button_EditBody = new System.Windows.Forms.Button();
            this.button_DeleteBody = new System.Windows.Forms.Button();
            this.button_AddBody = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid_Body = new System.Windows.Forms.DataGridView();
            this.button_EditScene = new System.Windows.Forms.Button();
            this.button_DeleteScene = new System.Windows.Forms.Button();
            this.button_AddScene = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ShowAllBody = new System.Windows.Forms.Button();
            this.показатьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Source)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Scene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Body)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Source
            // 
            this.dataGrid_Source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Source.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid_Source.Location = new System.Drawing.Point(12, 71);
            this.dataGrid_Source.Name = "dataGrid_Source";
            this.dataGrid_Source.RowHeadersWidth = 51;
            this.dataGrid_Source.RowTemplate.Height = 24;
            this.dataGrid_Source.Size = new System.Drawing.Size(450, 230);
            this.dataGrid_Source.TabIndex = 0;
            this.dataGrid_Source.Click += new System.EventHandler(this.dataGrid_Source_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.источникиToolStripMenuItem,
            this.объектыToolStripMenuItem,
            this.сценыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1395, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // источникиToolStripMenuItem
            // 
            this.источникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьИсточникToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.источникиToolStripMenuItem.Name = "источникиToolStripMenuItem";
            this.источникиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.источникиToolStripMenuItem.Text = "Источники";
            // 
            // добавитьИсточникToolStripMenuItem
            // 
            this.добавитьИсточникToolStripMenuItem.Name = "добавитьИсточникToolStripMenuItem";
            this.добавитьИсточникToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьИсточникToolStripMenuItem.Text = "Добавить";
            this.добавитьИсточникToolStripMenuItem.Click += new System.EventHandler(this.AddSource);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteSource);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.EditSource);
            // 
            // объектыToolStripMenuItem
            // 
            this.объектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem1,
            this.редактироватьToolStripMenuItem1,
            this.показатьВсеToolStripMenuItem});
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.объектыToolStripMenuItem.Text = "Объекты";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddBody);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.DeleteBody);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.EditBody);
            // 
            // сценыToolStripMenuItem
            // 
            this.сценыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem2,
            this.редактироватьToolStripMenuItem2});
            this.сценыToolStripMenuItem.Name = "сценыToolStripMenuItem";
            this.сценыToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.сценыToolStripMenuItem.Text = "Сцены";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.AddScene);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.DeleteScene);
            // 
            // редактироватьToolStripMenuItem2
            // 
            this.редактироватьToolStripMenuItem2.Name = "редактироватьToolStripMenuItem2";
            this.редактироватьToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.редактироватьToolStripMenuItem2.Text = "Редактировать";
            this.редактироватьToolStripMenuItem2.Click += new System.EventHandler(this.EditScene);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сцены";
            // 
            // dataGrid_Scene
            // 
            this.dataGrid_Scene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Scene.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid_Scene.Location = new System.Drawing.Point(673, 71);
            this.dataGrid_Scene.Name = "dataGrid_Scene";
            this.dataGrid_Scene.RowHeadersWidth = 51;
            this.dataGrid_Scene.RowTemplate.Height = 24;
            this.dataGrid_Scene.Size = new System.Drawing.Size(450, 230);
            this.dataGrid_Scene.TabIndex = 3;
            this.dataGrid_Scene.Click += new System.EventHandler(this.dataGrid_Scene_Click);
            // 
            // button_AddSource
            // 
            this.button_AddSource.Location = new System.Drawing.Point(468, 71);
            this.button_AddSource.Name = "button_AddSource";
            this.button_AddSource.Size = new System.Drawing.Size(199, 37);
            this.button_AddSource.TabIndex = 5;
            this.button_AddSource.Text = "Добавить Источник";
            this.button_AddSource.UseVisualStyleBackColor = true;
            this.button_AddSource.Click += new System.EventHandler(this.AddSource);
            // 
            // button_DeleteSource
            // 
            this.button_DeleteSource.Location = new System.Drawing.Point(468, 114);
            this.button_DeleteSource.Name = "button_DeleteSource";
            this.button_DeleteSource.Size = new System.Drawing.Size(199, 37);
            this.button_DeleteSource.TabIndex = 6;
            this.button_DeleteSource.Text = "Удалить Источник";
            this.button_DeleteSource.UseVisualStyleBackColor = true;
            this.button_DeleteSource.Click += new System.EventHandler(this.DeleteSource);
            // 
            // button_EditSource
            // 
            this.button_EditSource.Location = new System.Drawing.Point(468, 157);
            this.button_EditSource.Name = "button_EditSource";
            this.button_EditSource.Size = new System.Drawing.Size(199, 37);
            this.button_EditSource.TabIndex = 7;
            this.button_EditSource.Text = "Редактировать Источник";
            this.button_EditSource.UseVisualStyleBackColor = true;
            this.button_EditSource.Click += new System.EventHandler(this.EditSource);
            // 
            // button_EditBody
            // 
            this.button_EditBody.Location = new System.Drawing.Point(1129, 426);
            this.button_EditBody.Name = "button_EditBody";
            this.button_EditBody.Size = new System.Drawing.Size(199, 37);
            this.button_EditBody.TabIndex = 12;
            this.button_EditBody.Text = "Редактировать Объект";
            this.button_EditBody.UseVisualStyleBackColor = true;
            this.button_EditBody.Click += new System.EventHandler(this.EditBody);
            // 
            // button_DeleteBody
            // 
            this.button_DeleteBody.Location = new System.Drawing.Point(1129, 383);
            this.button_DeleteBody.Name = "button_DeleteBody";
            this.button_DeleteBody.Size = new System.Drawing.Size(199, 37);
            this.button_DeleteBody.TabIndex = 11;
            this.button_DeleteBody.Text = "Удалить Объект";
            this.button_DeleteBody.UseVisualStyleBackColor = true;
            this.button_DeleteBody.Click += new System.EventHandler(this.DeleteBody);
            // 
            // button_AddBody
            // 
            this.button_AddBody.Location = new System.Drawing.Point(1129, 340);
            this.button_AddBody.Name = "button_AddBody";
            this.button_AddBody.Size = new System.Drawing.Size(199, 37);
            this.button_AddBody.TabIndex = 10;
            this.button_AddBody.Text = "Добавить Объект";
            this.button_AddBody.UseVisualStyleBackColor = true;
            this.button_AddBody.Click += new System.EventHandler(this.AddBody);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Объекты";
            // 
            // dataGrid_Body
            // 
            this.dataGrid_Body.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Body.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid_Body.Location = new System.Drawing.Point(12, 340);
            this.dataGrid_Body.Name = "dataGrid_Body";
            this.dataGrid_Body.RowHeadersWidth = 51;
            this.dataGrid_Body.RowTemplate.Height = 24;
            this.dataGrid_Body.Size = new System.Drawing.Size(1111, 230);
            this.dataGrid_Body.TabIndex = 8;
            // 
            // button_EditScene
            // 
            this.button_EditScene.Location = new System.Drawing.Point(1129, 157);
            this.button_EditScene.Name = "button_EditScene";
            this.button_EditScene.Size = new System.Drawing.Size(199, 37);
            this.button_EditScene.TabIndex = 15;
            this.button_EditScene.Text = "Редактировать Сцену";
            this.button_EditScene.UseVisualStyleBackColor = true;
            this.button_EditScene.Click += new System.EventHandler(this.EditScene);
            // 
            // button_DeleteScene
            // 
            this.button_DeleteScene.Location = new System.Drawing.Point(1129, 114);
            this.button_DeleteScene.Name = "button_DeleteScene";
            this.button_DeleteScene.Size = new System.Drawing.Size(199, 37);
            this.button_DeleteScene.TabIndex = 14;
            this.button_DeleteScene.Text = "Удалить Сцену";
            this.button_DeleteScene.UseVisualStyleBackColor = true;
            this.button_DeleteScene.Click += new System.EventHandler(this.DeleteScene);
            // 
            // button_AddScene
            // 
            this.button_AddScene.Location = new System.Drawing.Point(1129, 71);
            this.button_AddScene.Name = "button_AddScene";
            this.button_AddScene.Size = new System.Drawing.Size(199, 37);
            this.button_AddScene.TabIndex = 13;
            this.button_AddScene.Text = "Добавить Сцену";
            this.button_AddScene.UseVisualStyleBackColor = true;
            this.button_AddScene.Click += new System.EventHandler(this.AddScene);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Источники";
            // 
            // button_ShowAllBody
            // 
            this.button_ShowAllBody.Location = new System.Drawing.Point(1129, 469);
            this.button_ShowAllBody.Name = "button_ShowAllBody";
            this.button_ShowAllBody.Size = new System.Drawing.Size(199, 37);
            this.button_ShowAllBody.TabIndex = 17;
            this.button_ShowAllBody.Text = "Показать Все Объекты";
            this.button_ShowAllBody.UseVisualStyleBackColor = true;
            this.button_ShowAllBody.Click += new System.EventHandler(this.ShowAllBody);
            // 
            // показатьВсеToolStripMenuItem
            // 
            this.показатьВсеToolStripMenuItem.Name = "показатьВсеToolStripMenuItem";
            this.показатьВсеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.показатьВсеToolStripMenuItem.Text = "Показать все";
            this.показатьВсеToolStripMenuItem.Click += new System.EventHandler(this.ShowAllBody);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 609);
            this.Controls.Add(this.button_ShowAllBody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_EditScene);
            this.Controls.Add(this.button_DeleteScene);
            this.Controls.Add(this.button_AddScene);
            this.Controls.Add(this.button_EditBody);
            this.Controls.Add(this.button_DeleteBody);
            this.Controls.Add(this.button_AddBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid_Body);
            this.Controls.Add(this.button_EditSource);
            this.Controls.Add(this.button_DeleteSource);
            this.Controls.Add(this.button_AddSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGrid_Scene);
            this.Controls.Add(this.dataGrid_Source);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Информационная система 3D сцен";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Source)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Scene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Body)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Source;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGrid_Scene;
        private System.Windows.Forms.Button button_AddSource;
        private System.Windows.Forms.Button button_DeleteSource;
        private System.Windows.Forms.Button button_EditSource;
        private System.Windows.Forms.Button button_EditBody;
        private System.Windows.Forms.Button button_DeleteBody;
        private System.Windows.Forms.Button button_AddBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid_Body;
        private System.Windows.Forms.Button button_EditScene;
        private System.Windows.Forms.Button button_DeleteScene;
        private System.Windows.Forms.Button button_AddScene;
        private System.Windows.Forms.ToolStripMenuItem источникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьИсточникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сценыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ShowAllBody;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеToolStripMenuItem;
    }
}

