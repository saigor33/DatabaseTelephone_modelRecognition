namespace Recognition
{
    partial class form_recognition
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
            this.btn_compare_photo = new System.Windows.Forms.Button();
            this.btn_found_in_the_datebase = new System.Windows.Forms.Button();
            this.btn_detect_face = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.panel_describing_events = new System.Windows.Forms.Panel();
            this.lbl_panel_value_describing_events = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_name_method = new System.Windows.Forms.Label();
            this.panel_describing_events.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_compare_photo
            // 
            this.btn_compare_photo.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_compare_photo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_compare_photo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_compare_photo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_compare_photo.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_compare_photo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_compare_photo.Location = new System.Drawing.Point(36, 62);
            this.btn_compare_photo.Name = "btn_compare_photo";
            this.btn_compare_photo.Size = new System.Drawing.Size(153, 38);
            this.btn_compare_photo.TabIndex = 0;
            this.btn_compare_photo.Text = "Compare_photo";
            this.btn_compare_photo.UseVisualStyleBackColor = false;
            this.btn_compare_photo.Click += new System.EventHandler(this.btn_compare_photo_Click);
            // 
            // btn_found_in_the_datebase
            // 
            this.btn_found_in_the_datebase.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_found_in_the_datebase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_found_in_the_datebase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_found_in_the_datebase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_found_in_the_datebase.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_found_in_the_datebase.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_found_in_the_datebase.Location = new System.Drawing.Point(36, 99);
            this.btn_found_in_the_datebase.Name = "btn_found_in_the_datebase";
            this.btn_found_in_the_datebase.Size = new System.Drawing.Size(153, 38);
            this.btn_found_in_the_datebase.TabIndex = 0;
            this.btn_found_in_the_datebase.Text = "Found in the datebase";
            this.btn_found_in_the_datebase.UseVisualStyleBackColor = false;
            this.btn_found_in_the_datebase.Click += new System.EventHandler(this.btn_found_in_the_datebase_Click);
            // 
            // btn_detect_face
            // 
            this.btn_detect_face.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_detect_face.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_detect_face.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_detect_face.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_detect_face.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_detect_face.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_detect_face.Location = new System.Drawing.Point(36, 136);
            this.btn_detect_face.Name = "btn_detect_face";
            this.btn_detect_face.Size = new System.Drawing.Size(153, 38);
            this.btn_detect_face.TabIndex = 0;
            this.btn_detect_face.Text = "Detect face";
            this.btn_detect_face.UseVisualStyleBackColor = false;
            this.btn_detect_face.Click += new System.EventHandler(this.btn_detect_face_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_exit.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_exit.Location = new System.Drawing.Point(12, 265);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 38);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_help.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_help.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_help.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_help.Location = new System.Drawing.Point(119, 265);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(101, 38);
            this.btn_help.TabIndex = 0;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // panel_describing_events
            // 
            this.panel_describing_events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_describing_events.Controls.Add(this.lbl_panel_value_describing_events);
            this.panel_describing_events.Controls.Add(this.btn_start);
            this.panel_describing_events.Controls.Add(this.lbl_name_method);
            this.panel_describing_events.Location = new System.Drawing.Point(251, 24);
            this.panel_describing_events.Name = "panel_describing_events";
            this.panel_describing_events.Size = new System.Drawing.Size(270, 226);
            this.panel_describing_events.TabIndex = 1;
            // 
            // lbl_panel_value_describing_events
            // 
            this.lbl_panel_value_describing_events.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lbl_panel_value_describing_events.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_panel_value_describing_events.Location = new System.Drawing.Point(-1, 53);
            this.lbl_panel_value_describing_events.Name = "lbl_panel_value_describing_events";
            this.lbl_panel_value_describing_events.Size = new System.Drawing.Size(270, 101);
            this.lbl_panel_value_describing_events.TabIndex = 2;
            this.lbl_panel_value_describing_events.Text = "Выберите метод распознования\r\n";
            this.lbl_panel_value_describing_events.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_start.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_start.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_start.Location = new System.Drawing.Point(53, 178);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(154, 37);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_name_method
            // 
            this.lbl_name_method.Font = new System.Drawing.Font("Gabriola", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name_method.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_name_method.Location = new System.Drawing.Point(-1, 0);
            this.lbl_name_method.Name = "lbl_name_method";
            this.lbl_name_method.Size = new System.Drawing.Size(270, 59);
            this.lbl_name_method.TabIndex = 0;
            this.lbl_name_method.Text = "Recognition";
            this.lbl_name_method.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_recognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(552, 325);
            this.Controls.Add(this.panel_describing_events);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_detect_face);
            this.Controls.Add(this.btn_found_in_the_datebase);
            this.Controls.Add(this.btn_compare_photo);
            this.Name = "form_recognition";
            this.Text = "Recognition_face";
            this.panel_describing_events.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_compare_photo;
        private System.Windows.Forms.Button btn_found_in_the_datebase;
        private System.Windows.Forms.Button btn_detect_face;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Panel panel_describing_events;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_name_method;
        private System.Windows.Forms.Label lbl_panel_value_describing_events;
    }
}

