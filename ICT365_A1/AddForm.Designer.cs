namespace ICT365_A1
{
    partial class AddForm
    {
        public string textToDisplay { get; set; }
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.EventType_Label = new System.Windows.Forms.Label();
            this.openFileDialog_NewContactPhoto = new System.Windows.Forms.OpenFileDialog();
            this.btn_Add_Person = new System.Windows.Forms.Button();
            this.btn_Add_Photo = new System.Windows.Forms.Button();
            this.btn_Add_Video = new System.Windows.Forms.Button();
            this.btn_Add_Route = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_cancel.Location = new System.Drawing.Point(203, 206);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(94, 36);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // EventType_Label
            // 
            this.EventType_Label.AutoSize = true;
            this.EventType_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventType_Label.Location = new System.Drawing.Point(45, 15);
            this.EventType_Label.Name = "EventType_Label";
            this.EventType_Label.Size = new System.Drawing.Size(418, 37);
            this.EventType_Label.TabIndex = 6;
            this.EventType_Label.Text = "What would you like to add?";
            // 
            // openFileDialog_NewContactPhoto
            // 
            this.openFileDialog_NewContactPhoto.DefaultExt = "jpeg";
            this.openFileDialog_NewContactPhoto.FileName = "new contact photo";
            this.openFileDialog_NewContactPhoto.Title = "New Contact Photo";
            // 
            // btn_Add_Person
            // 
            this.btn_Add_Person.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add_Person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Person.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Add_Person.Location = new System.Drawing.Point(97, 130);
            this.btn_Add_Person.Name = "btn_Add_Person";
            this.btn_Add_Person.Size = new System.Drawing.Size(150, 50);
            this.btn_Add_Person.TabIndex = 23;
            this.btn_Add_Person.Text = "Person";
            this.btn_Add_Person.UseVisualStyleBackColor = false;
            this.btn_Add_Person.Click += new System.EventHandler(this.Btn_Add_Person_Click);
            // 
            // btn_Add_Photo
            // 
            this.btn_Add_Photo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add_Photo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Photo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Add_Photo.Location = new System.Drawing.Point(253, 130);
            this.btn_Add_Photo.Name = "btn_Add_Photo";
            this.btn_Add_Photo.Size = new System.Drawing.Size(150, 50);
            this.btn_Add_Photo.TabIndex = 24;
            this.btn_Add_Photo.Text = "Photo";
            this.btn_Add_Photo.UseVisualStyleBackColor = false;
            this.btn_Add_Photo.Click += new System.EventHandler(this.Btn_Add_Photo_Click);
            // 
            // btn_Add_Video
            // 
            this.btn_Add_Video.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add_Video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Video.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Video.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Add_Video.Location = new System.Drawing.Point(97, 74);
            this.btn_Add_Video.Name = "btn_Add_Video";
            this.btn_Add_Video.Size = new System.Drawing.Size(150, 50);
            this.btn_Add_Video.TabIndex = 25;
            this.btn_Add_Video.Text = "Video";
            this.btn_Add_Video.UseVisualStyleBackColor = false;
            this.btn_Add_Video.Click += new System.EventHandler(this.Btn_Add_Video_Click);
            // 
            // btn_Add_Route
            // 
            this.btn_Add_Route.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add_Route.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Route.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Route.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Add_Route.Location = new System.Drawing.Point(253, 74);
            this.btn_Add_Route.Name = "btn_Add_Route";
            this.btn_Add_Route.Size = new System.Drawing.Size(150, 50);
            this.btn_Add_Route.TabIndex = 26;
            this.btn_Add_Route.Text = "Route";
            this.btn_Add_Route.UseVisualStyleBackColor = false;
            this.btn_Add_Route.Click += new System.EventHandler(this.Btn_Add_Route_Click);
            // 
            // AddForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(500, 263);
            this.Controls.Add(this.btn_Add_Route);
            this.Controls.Add(this.btn_Add_Video);
            this.Controls.Add(this.btn_Add_Photo);
            this.Controls.Add(this.btn_Add_Person);
            this.Controls.Add(this.EventType_Label);
            this.Controls.Add(this.button_cancel);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label EventType_Label;
        private System.Windows.Forms.OpenFileDialog openFileDialog_NewContactPhoto;
        private System.Windows.Forms.Button btn_Add_Person;
        private System.Windows.Forms.Button btn_Add_Photo;
        private System.Windows.Forms.Button btn_Add_Video;
        private System.Windows.Forms.Button btn_Add_Route;
    }
}