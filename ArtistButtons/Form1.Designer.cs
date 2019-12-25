namespace ArtistButtons
{
    partial class Form1
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
            this.Under = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CtrlC = new System.Windows.Forms.Button();
            this.CtrlV = new System.Windows.Forms.Button();
            this.CtrlX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Under
            // 
            this.Under.Location = new System.Drawing.Point(-1, -2);
            this.Under.Name = "Under";
            this.Under.Size = new System.Drawing.Size(206, 141);
            this.Under.TabIndex = 0;
            this.Under.Text = "Ctrl+Z";
            this.Under.UseVisualStyleBackColor = true;
            this.Under.Click += new System.EventHandler(this.Under_Click);
            // 
            // Redo
            // 
            this.Redo.Location = new System.Drawing.Point(-1, 145);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(206, 135);
            this.Redo.TabIndex = 1;
            this.Redo.Text = "Ctrl+Y";
            this.Redo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thx for using";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "behance.net/mexalim";
            // 
            // CtrlC
            // 
            this.CtrlC.Location = new System.Drawing.Point(-1, 302);
            this.CtrlC.Name = "CtrlC";
            this.CtrlC.Size = new System.Drawing.Size(206, 68);
            this.CtrlC.TabIndex = 5;
            this.CtrlC.Text = "Ctrl+C";
            this.CtrlC.UseVisualStyleBackColor = true;
            this.CtrlC.Click += new System.EventHandler(this.CtrlC_Click);
            // 
            // CtrlV
            // 
            this.CtrlV.Location = new System.Drawing.Point(-1, 376);
            this.CtrlV.Name = "CtrlV";
            this.CtrlV.Size = new System.Drawing.Size(206, 60);
            this.CtrlV.TabIndex = 6;
            this.CtrlV.Text = "Ctrl+V";
            this.CtrlV.UseVisualStyleBackColor = true;
            this.CtrlV.Click += new System.EventHandler(this.CtrlV_Click);
            // 
            // CtrlX
            // 
            this.CtrlX.Location = new System.Drawing.Point(-1, 442);
            this.CtrlX.Name = "CtrlX";
            this.CtrlX.Size = new System.Drawing.Size(206, 56);
            this.CtrlX.TabIndex = 7;
            this.CtrlX.Text = "Ctrl+X";
            this.CtrlX.UseVisualStyleBackColor = true;
            this.CtrlX.Click += new System.EventHandler(this.CtrlX_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(204, 572);
            this.Controls.Add(this.CtrlX);
            this.Controls.Add(this.CtrlV);
            this.Controls.Add(this.CtrlC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.Under);
            this.Name = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctrlz;
        private System.Windows.Forms.Button ctrly;
        private System.Windows.Forms.Button Space;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Under;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CtrlC;
        private System.Windows.Forms.Button CtrlV;
        private System.Windows.Forms.Button CtrlX;
    }
}

