
namespace ProjectBD
{
    partial class FormBodyDelete
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
            this.button_No = new System.Windows.Forms.Button();
            this.button_Yes = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_No
            // 
            this.button_No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_No.Location = new System.Drawing.Point(174, 68);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(133, 29);
            this.button_No.TabIndex = 7;
            this.button_No.Text = "Нет";
            this.button_No.UseVisualStyleBackColor = true;
            // 
            // button_Yes
            // 
            this.button_Yes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Yes.Location = new System.Drawing.Point(15, 68);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(133, 29);
            this.button_Yes.TabIndex = 6;
            this.button_Yes.Text = "Да";
            this.button_Yes.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 17);
            this.label.TabIndex = 5;
            this.label.Text = "TEXT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вы действительно хотите удалить объект?";
            // 
            // FormBodyDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 120);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "FormBodyDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить объект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Button button_Yes;
        public System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
    }
}