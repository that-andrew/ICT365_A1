namespace ICT365_A1
{
    partial class SearchForm
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
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_numberOfResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.SystemColors.Window;
            this.button_search.Location = new System.Drawing.Point(480, 217);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(94, 36);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.AcceptsReturn = true;
            this.textBox_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox_Search.Location = new System.Drawing.Point(12, 12);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(562, 44);
            this.textBox_Search.TabIndex = 2;
            this.textBox_Search.Text = "Enter Search Term...";
            this.textBox_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Search.WordWrap = false;
            this.textBox_Search.Click += new System.EventHandler(this.TextBox_Search_Click);
            this.textBox_Search.TextChanged += new System.EventHandler(this.Search_Textbox_Changed);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 114);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(562, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_cancel.Location = new System.Drawing.Point(12, 217);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(94, 36);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // label_numberOfResults
            // 
            this.label_numberOfResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_numberOfResults.AutoSize = true;
            this.label_numberOfResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberOfResults.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_numberOfResults.Location = new System.Drawing.Point(187, 82);
            this.label_numberOfResults.Name = "label_numberOfResults";
            this.label_numberOfResults.Size = new System.Drawing.Size(212, 29);
            this.label_numberOfResults.TabIndex = 6;
            this.label_numberOfResults.Text = "No Results Found.";
            this.label_numberOfResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_numberOfResults.Visible = false;
            // 
            // SearchForm
            // 
            this.AcceptButton = this.button_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label_numberOfResults);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_search);
            this.Name = "SearchForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Events";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.Controls.SetChildIndex(this.button_search, 0);
            this.Controls.SetChildIndex(this.textBox_Search, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.button_cancel, 0);
            this.Controls.SetChildIndex(this.label_numberOfResults, 0);
            this.Controls.SetChildIndex(this.Hindsight_Map, 0);
            this.Controls.SetChildIndex(this.lbl_lat_value, 0);
            this.Controls.SetChildIndex(this.lbl_long_Value, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_numberOfResults;
    }
}