namespace PractWork9
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.ballsLabel = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Core Sans C 95 Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(68, 23);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Счёт: ";
            // 
            // ballsLabel
            // 
            this.ballsLabel.AutoSize = true;
            this.ballsLabel.Font = new System.Drawing.Font("Core Sans C 95 Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ballsLabel.Location = new System.Drawing.Point(592, 9);
            this.ballsLabel.Name = "ballsLabel";
            this.ballsLabel.Size = new System.Drawing.Size(182, 23);
            this.ballsLabel.TabIndex = 1;
            this.ballsLabel.Text = "Потеряно мячей: ";
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.racket.Location = new System.Drawing.Point(331, 449);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(143, 19);
            this.racket.TabIndex = 2;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(387, 411);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(32, 32);
            this.ball.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(832, 509);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.ballsLabel);
            this.Controls.Add(this.scoreLabel);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(848, 548);
            this.MinimumSize = new System.Drawing.Size(848, 548);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Арканоид";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label ballsLabel;
        private System.Windows.Forms.Panel racket;
        private System.Windows.Forms.Panel ball;
    }
}

