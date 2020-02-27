namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenSecondFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenSecondFormButton
            // 
            this.OpenSecondFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSecondFormButton.Location = new System.Drawing.Point(12, 12);
            this.OpenSecondFormButton.Name = "OpenSecondFormButton";
            this.OpenSecondFormButton.Size = new System.Drawing.Size(410, 387);
            this.OpenSecondFormButton.TabIndex = 0;
            this.OpenSecondFormButton.Text = "Открыть вторую форму";
            this.OpenSecondFormButton.UseVisualStyleBackColor = true;
            this.OpenSecondFormButton.Click += new System.EventHandler(this.OpenSecondFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.OpenSecondFormButton);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenSecondFormButton;
    }
}

