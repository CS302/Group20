namespace Lesson10
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_firstOp = new System.Windows.Forms.RichTextBox();
            this.rtb_secondOp = new System.Windows.Forms.RichTextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_firstOp
            // 
            this.rtb_firstOp.Location = new System.Drawing.Point(13, 13);
            this.rtb_firstOp.Name = "rtb_firstOp";
            this.rtb_firstOp.Size = new System.Drawing.Size(209, 64);
            this.rtb_firstOp.TabIndex = 0;
            this.rtb_firstOp.Text = "";
            // 
            // rtb_secondOp
            // 
            this.rtb_secondOp.Location = new System.Drawing.Point(13, 84);
            this.rtb_secondOp.Name = "rtb_secondOp";
            this.rtb_secondOp.Size = new System.Drawing.Size(209, 64);
            this.rtb_secondOp.TabIndex = 1;
            this.rtb_secondOp.Text = "";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(13, 164);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(209, 83);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Сделать все хорошо";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(98, 291);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_result.Size = new System.Drawing.Size(59, 13);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Результат";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 362);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.rtb_secondOp);
            this.Controls.Add(this.rtb_firstOp);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_firstOp;
        private System.Windows.Forms.RichTextBox rtb_secondOp;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_result;
    }
}

