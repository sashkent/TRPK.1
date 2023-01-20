namespace TRPK._1
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
            this.components = new System.ComponentModel.Container();
            this.invisibleEdit1 = new TRPK._1.InvisibleEdit(this.components);
            this.invisibleEdit2 = new TRPK._1.InvisibleEdit(this.components);
            this.SuspendLayout();
            // 
            // invisibleEdit1
            // 
            this.invisibleEdit1.Location = new System.Drawing.Point(140, 88);
            this.invisibleEdit1.Name = "invisibleEdit1";
            this.invisibleEdit1.Size = new System.Drawing.Size(135, 20);
            this.invisibleEdit1.TabIndex = 0;
            this.invisibleEdit1.AcceptsTabChanged += new System.EventHandler(this.invisibleEdit1_AcceptsTabChanged);
            this.invisibleEdit1.MouseEnter += new System.EventHandler(this.invisibleEdit1_AcceptsTabChanged);
            // 
            // invisibleEdit2
            // 
            this.invisibleEdit2.Location = new System.Drawing.Point(170, 151);
            this.invisibleEdit2.Name = "invisibleEdit2";
            this.invisibleEdit2.Size = new System.Drawing.Size(100, 20);
            this.invisibleEdit2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 235);
            this.Controls.Add(this.invisibleEdit2);
            this.Controls.Add(this.invisibleEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InvisibleEdit invisibleEdit1;
        private InvisibleEdit invisibleEdit2;
    }
}

