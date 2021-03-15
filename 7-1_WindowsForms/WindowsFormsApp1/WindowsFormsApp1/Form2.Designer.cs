
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lblVictory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHead.Location = new System.Drawing.Point(190, 90);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(215, 37);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Угадай число!";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTask.Location = new System.Drawing.Point(324, 178);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(109, 39);
            this.lblTask.TabIndex = 1;
            this.lblTask.Text = "label1";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(128, 316);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(155, 24);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Введите число: ";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(289, 300);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(159, 47);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblVictory
            // 
            this.lblVictory.AutoSize = true;
            this.lblVictory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblVictory.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVictory.Location = new System.Drawing.Point(50, 189);
            this.lblVictory.Name = "lblVictory";
            this.lblVictory.Size = new System.Drawing.Size(233, 27);
            this.lblVictory.TabIndex = 10;
            this.lblVictory.Text = "Победа! Молодцом!";
            this.lblVictory.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVictory);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblHead);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lblVictory;
    }
}