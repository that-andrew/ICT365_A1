namespace ICT365_A1
{
    partial class MapForm
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

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip_bottom;
        private System.Windows.Forms.ToolStripButton button_Add;
        private System.Windows.Forms.ToolStripButton button_Timeline;
        private System.Windows.Forms.Panel panel_Map;
        private System.Windows.Forms.ToolStripButton button_contacts;
        private System.Windows.Forms.ToolStripButton button_Layers;
        private System.Windows.Forms.ToolStripButton button_Search;
        private System.Windows.Forms.ToolStripButton button_home;
        private System.Windows.Forms.Label lbl_Lat;
        private System.Windows.Forms.Label lbl_long;
        public System.Windows.Forms.Label lbl_lat_value;
        public System.Windows.Forms.Label lbl_long_Value;
        public GMap.NET.WindowsForms.GMapControl Hindsight_Map;
    }
}

