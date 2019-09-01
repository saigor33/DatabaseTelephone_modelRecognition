namespace Recognition
{
    partial class form_help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_help));
            this.lbl_panel_value_describing_events = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_panel_value_describing_events
            // 
            this.lbl_panel_value_describing_events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_panel_value_describing_events.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lbl_panel_value_describing_events.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_panel_value_describing_events.Location = new System.Drawing.Point(12, 18);
            this.lbl_panel_value_describing_events.Name = "lbl_panel_value_describing_events";
            this.lbl_panel_value_describing_events.Size = new System.Drawing.Size(528, 109);
            this.lbl_panel_value_describing_events.TabIndex = 3;
            this.lbl_panel_value_describing_events.Text = resources.GetString("lbl_panel_value_describing_events.Text");
            this.lbl_panel_value_describing_events.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 109);
            this.label1.TabIndex = 3;
            this.label1.Text = "Метод Found in the datebase осуществляет поиск лиц в базе данных. Для работы необ" +
                "ходимо загрузить фото в приложение и и нажать \"Found\" после чего произойдёт выво" +
                "д информации а человеке на экран\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 109);
            this.label2.TabIndex = 3;
            this.label2.Text = "Метод Detect face ищет лица на фотографиях и выделяет рамками";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_exit.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_exit.Location = new System.Drawing.Point(424, 378);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 38);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Автор: Складчиков И.А.";
            // 
            // form_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(552, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_panel_value_describing_events);
            this.Name = "form_help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_panel_value_describing_events;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
    }
}