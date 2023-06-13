
namespace ProjectBD
{
    partial class FormBodyAdd
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PosX = new System.Windows.Forms.TextBox();
            this.textBox_PosY = new System.Windows.Forms.TextBox();
            this.textBox_PosZ = new System.Windows.Forms.TextBox();
            this.textBox_RotZ = new System.Windows.Forms.TextBox();
            this.textBox_RotY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_RotX = new System.Windows.Forms.TextBox();
            this.textBox_SclZ = new System.Windows.Forms.TextBox();
            this.textBox_SclY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SclX = new System.Windows.Forms.TextBox();
            this.comboBox_Source = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Scene = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(121, 264);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(111, 35);
            this.button_Cancel.TabIndex = 23;
            this.button_Cancel.Text = "Отменить";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Add.Location = new System.Drawing.Point(12, 264);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(103, 35);
            this.button_Add.TabIndex = 22;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Position XYZ";
            // 
            // textBox_PosX
            // 
            this.textBox_PosX.Location = new System.Drawing.Point(12, 141);
            this.textBox_PosX.Name = "textBox_PosX";
            this.textBox_PosX.Size = new System.Drawing.Size(64, 22);
            this.textBox_PosX.TabIndex = 17;
            // 
            // textBox_PosY
            // 
            this.textBox_PosY.Location = new System.Drawing.Point(89, 141);
            this.textBox_PosY.Name = "textBox_PosY";
            this.textBox_PosY.Size = new System.Drawing.Size(64, 22);
            this.textBox_PosY.TabIndex = 24;
            // 
            // textBox_PosZ
            // 
            this.textBox_PosZ.Location = new System.Drawing.Point(167, 141);
            this.textBox_PosZ.Name = "textBox_PosZ";
            this.textBox_PosZ.Size = new System.Drawing.Size(64, 22);
            this.textBox_PosZ.TabIndex = 25;
            // 
            // textBox_RotZ
            // 
            this.textBox_RotZ.Location = new System.Drawing.Point(167, 186);
            this.textBox_RotZ.Name = "textBox_RotZ";
            this.textBox_RotZ.Size = new System.Drawing.Size(64, 22);
            this.textBox_RotZ.TabIndex = 29;
            // 
            // textBox_RotY
            // 
            this.textBox_RotY.Location = new System.Drawing.Point(89, 186);
            this.textBox_RotY.Name = "textBox_RotY";
            this.textBox_RotY.Size = new System.Drawing.Size(64, 22);
            this.textBox_RotY.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Rotation XYZ";
            // 
            // textBox_RotX
            // 
            this.textBox_RotX.Location = new System.Drawing.Point(12, 186);
            this.textBox_RotX.Name = "textBox_RotX";
            this.textBox_RotX.Size = new System.Drawing.Size(64, 22);
            this.textBox_RotX.TabIndex = 26;
            // 
            // textBox_SclZ
            // 
            this.textBox_SclZ.Location = new System.Drawing.Point(167, 231);
            this.textBox_SclZ.Name = "textBox_SclZ";
            this.textBox_SclZ.Size = new System.Drawing.Size(64, 22);
            this.textBox_SclZ.TabIndex = 33;
            // 
            // textBox_SclY
            // 
            this.textBox_SclY.Location = new System.Drawing.Point(89, 231);
            this.textBox_SclY.Name = "textBox_SclY";
            this.textBox_SclY.Size = new System.Drawing.Size(64, 22);
            this.textBox_SclY.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Scale XYZ";
            // 
            // textBox_SclX
            // 
            this.textBox_SclX.Location = new System.Drawing.Point(12, 231);
            this.textBox_SclX.Name = "textBox_SclX";
            this.textBox_SclX.Size = new System.Drawing.Size(64, 22);
            this.textBox_SclX.TabIndex = 30;
            // 
            // comboBox_Source
            // 
            this.comboBox_Source.FormattingEnabled = true;
            this.comboBox_Source.Location = new System.Drawing.Point(89, 51);
            this.comboBox_Source.Name = "comboBox_Source";
            this.comboBox_Source.Size = new System.Drawing.Size(142, 24);
            this.comboBox_Source.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Источник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Сцена";
            // 
            // comboBox_Scene
            // 
            this.comboBox_Scene.FormattingEnabled = true;
            this.comboBox_Scene.Location = new System.Drawing.Point(89, 86);
            this.comboBox_Scene.Name = "comboBox_Scene";
            this.comboBox_Scene.Size = new System.Drawing.Size(142, 24);
            this.comboBox_Scene.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Имя";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(89, 19);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(142, 22);
            this.textBox_Name.TabIndex = 40;
            // 
            // FormBodyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 321);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Scene);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Source);
            this.Controls.Add(this.textBox_SclZ);
            this.Controls.Add(this.textBox_SclY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_SclX);
            this.Controls.Add(this.textBox_RotZ);
            this.Controls.Add(this.textBox_RotY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_RotX);
            this.Controls.Add(this.textBox_PosZ);
            this.Controls.Add(this.textBox_PosY);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PosX);
            this.Name = "FormBodyAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить объект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_PosX;
        public System.Windows.Forms.TextBox textBox_PosY;
        public System.Windows.Forms.TextBox textBox_PosZ;
        public System.Windows.Forms.TextBox textBox_RotZ;
        public System.Windows.Forms.TextBox textBox_RotY;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_RotX;
        public System.Windows.Forms.TextBox textBox_SclZ;
        public System.Windows.Forms.TextBox textBox_SclY;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_SclX;
        public System.Windows.Forms.ComboBox comboBox_Source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox_Scene;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_Name;
    }
}