using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using PhoneNumbers;


namespace ICT365_A1
{
    public partial class MapForm : Form
    {

        private PointLatLng sp;
        private static string home;
        public string Home { get => home; set => home = value; }
        public PointLatLng SelectedPoint { get => sp; set => sp = value; }
        public MapConfig mapConfig;
        public AddForm addForm;
        public AddPerson addPerson;
        public SearchForm searchForm;



        /// <summary>
        /// 
        /// </summary>
        public MapForm()
        {
            InitializeComponent();




            Hindsight_Map.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            Hindsight_Map.ShowCenter = false;
            //Console.WriteLine(GMaps.Instance.MemoryCache.Capacity.ToString());
            //Console.WriteLine(GMaps.Instance.MemoryCache.Size.ToString());
            //GMaps.Instance.Mode = AccessMode.ServerAndCache;
            //GMaps.Instance.Mode = AccessMode.CacheOnly;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void MapForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("MapForm_Load");


            mapConfig = new MapConfig();
            mapConfig.LoadData();


            Home = "Perth, Australia";
            Hindsight_Map.SetPositionByKeywords(Home);
            Hindsight_Map.Overlays.Add(mapConfig.UpdateOverlays());

        }
        private void Hindsight_Map_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hindsight_Map_Load");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked ADD button");
            addForm = new AddForm(SelectedPoint);
            addForm.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked HOME button");
            Home = "Perth, Australia";
            Hindsight_Map.SetPositionByKeywords(Home);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimelineButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("clicked TIMELINE button");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("clicked CONTACTS button");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LayersButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("clicked LAYERS button");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked SEARCH button");
            SearchForm searchForm = new SearchForm();

            searchForm.ShowDialog();
        }

        private void Gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Console.WriteLine("Marker " + item.Tag.ToString() + " was clicked.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hindsight_Map_MouseMove(object sender, MouseEventArgs e)
        {
            //3RD-PARTY CODE REFFERENCE
            // link.awgm.co/5 
            base.OnMouseMove(e);
            sp = new PointLatLng();

            double X = Hindsight_Map.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = Hindsight_Map.FromLocalToLatLng(e.X, e.Y).Lat;

            string longitude = X.ToString();
            string latitude = Y.ToString();
            lbl_long_Value.Text = longitude;
            sp.Lng = X;
            lbl_lat_value.Text = latitude;
            sp.Lat = Y;
            //Console.WriteLine(SelectedPoint.ToString());
            //Console.WriteLine(sp.ToString());
            SelectedPoint = sp;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hindsight_Map_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked on Map");

        }
        private void Hindsight_Map_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine("Double Clicked on Map");
            addForm = new AddForm(SelectedPoint);

            addForm.ShowDialog();
        }
        private void Hindsight_Map_OnMapZoomChanged()
        {
            Console.WriteLine("Hindsight_Map_OnMapZoomChanged");
        }
        private void Hindsight_Map_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("Hindsight_Map_Leave");

        }

        private void InitializeComponent()
        {
            this.toolStrip_bottom = new System.Windows.Forms.ToolStrip();
            this.button_Add = new System.Windows.Forms.ToolStripButton();
            this.button_Timeline = new System.Windows.Forms.ToolStripButton();
            this.button_contacts = new System.Windows.Forms.ToolStripButton();
            this.button_home = new System.Windows.Forms.ToolStripButton();
            this.button_Layers = new System.Windows.Forms.ToolStripButton();
            this.button_Search = new System.Windows.Forms.ToolStripButton();
            this.panel_Map = new System.Windows.Forms.Panel();
            this.Hindsight_Map = new GMap.NET.WindowsForms.GMapControl();
            this.lbl_lat_value = new System.Windows.Forms.Label();
            this.lbl_Lat = new System.Windows.Forms.Label();
            this.lbl_long = new System.Windows.Forms.Label();
            this.lbl_long_Value = new System.Windows.Forms.Label();
            this.toolStrip_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_bottom
            // 
            this.toolStrip_bottom.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip_bottom.CanOverflow = false;
            this.toolStrip_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_bottom.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStrip_bottom.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip_bottom.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_Add,
            this.button_Timeline,
            this.button_contacts,
            this.button_home,
            this.button_Layers,
            this.button_Search});
            this.toolStrip_bottom.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip_bottom.Location = new System.Drawing.Point(0, 494);
            this.toolStrip_bottom.Name = "toolStrip_bottom";
            this.toolStrip_bottom.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip_bottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_bottom.Size = new System.Drawing.Size(1067, 37);
            this.toolStrip_bottom.Stretch = true;
            this.toolStrip_bottom.TabIndex = 2;
            this.toolStrip_bottom.Text = "Map_Menu";
            // 
            // button_Add
            // 
            this.button_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_Add.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(57, 34);
            this.button_Add.Text = "Add";
            this.button_Add.ToolTipText = "Add processEvent new Event";
            this.button_Add.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button_Timeline
            // 
            this.button_Timeline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_Timeline.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Timeline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_Timeline.Name = "button_Timeline";
            this.button_Timeline.Size = new System.Drawing.Size(99, 34);
            this.button_Timeline.Text = "Timeline";
            this.button_Timeline.Visible = false;
            this.button_Timeline.Click += new System.EventHandler(this.TimelineButton_Click);
            // 
            // button_contacts
            // 
            this.button_contacts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_contacts.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_contacts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_contacts.Name = "button_contacts";
            this.button_contacts.Size = new System.Drawing.Size(100, 34);
            this.button_contacts.Text = "Contacts";
            this.button_contacts.Visible = false;
            this.button_contacts.Click += new System.EventHandler(this.ContactsButton_Click);
            // 
            // button_home
            // 
            this.button_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_home.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(77, 34);
            this.button_home.Text = "Home";
            this.button_home.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // button_Layers
            // 
            this.button_Layers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_Layers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Layers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_Layers.Name = "button_Layers";
            this.button_Layers.Size = new System.Drawing.Size(78, 34);
            this.button_Layers.Text = "Layers";
            this.button_Layers.Visible = false;
            this.button_Layers.Click += new System.EventHandler(this.LayersButton_Click);
            // 
            // button_Search
            // 
            this.button_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_Search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(82, 34);
            this.button_Search.Text = "Search";
            this.button_Search.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // panel_Map
            // 
            this.panel_Map.AutoSize = true;
            this.panel_Map.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Map.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_Map.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel_Map.Location = new System.Drawing.Point(0, 0);
            this.panel_Map.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Map.Name = "panel_Map";
            this.panel_Map.Size = new System.Drawing.Size(0, 0);
            this.panel_Map.TabIndex = 3;
            // 
            // Hindsight_Map
            // 
            this.Hindsight_Map.Bearing = 0F;
            this.Hindsight_Map.CanDragMap = true;
            this.Hindsight_Map.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Hindsight_Map.EmptyTileColor = System.Drawing.Color.LightGray;
            this.Hindsight_Map.GrayScaleMode = false;
            this.Hindsight_Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Hindsight_Map.LevelsKeepInMemmory = 5;
            this.Hindsight_Map.Location = new System.Drawing.Point(0, -1);
            this.Hindsight_Map.MarkersEnabled = true;
            this.Hindsight_Map.MaxZoom = 18;
            this.Hindsight_Map.MinZoom = 3;
            this.Hindsight_Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Hindsight_Map.Name = "Hindsight_Map";
            this.Hindsight_Map.NegativeMode = false;
            this.Hindsight_Map.PolygonsEnabled = true;
            this.Hindsight_Map.RetryLoadTile = 0;
            this.Hindsight_Map.RoutesEnabled = true;
            this.Hindsight_Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Hindsight_Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Hindsight_Map.ShowTileGridLines = false;
            this.Hindsight_Map.Size = new System.Drawing.Size(1067, 492);
            this.Hindsight_Map.TabIndex = 1;
            this.Hindsight_Map.Zoom = 13D;
            this.Hindsight_Map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.Gmap_OnMarkerClick);
            this.Hindsight_Map.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.Hindsight_Map_OnMapZoomChanged);
            this.Hindsight_Map.DoubleClick += new System.EventHandler(this.Hindsight_Map_DoubleClick);
            this.Hindsight_Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hindsight_Map_MouseMove);
            // 
            // lbl_lat_value
            // 
            this.lbl_lat_value.AutoSize = true;
            this.lbl_lat_value.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_lat_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lat_value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_lat_value.Location = new System.Drawing.Point(79, 9);
            this.lbl_lat_value.Name = "lbl_lat_value";
            this.lbl_lat_value.Size = new System.Drawing.Size(12, 16);
            this.lbl_lat_value.TabIndex = 5;
            this.lbl_lat_value.Text = "-";
            // 
            // lbl_Lat
            // 
            this.lbl_Lat.AutoSize = true;
            this.lbl_Lat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Lat.Location = new System.Drawing.Point(12, 9);
            this.lbl_Lat.Name = "lbl_Lat";
            this.lbl_Lat.Size = new System.Drawing.Size(61, 16);
            this.lbl_Lat.TabIndex = 6;
            this.lbl_Lat.Text = "Lattitude:";
            this.lbl_Lat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_long
            // 
            this.lbl_long.AutoSize = true;
            this.lbl_long.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_long.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_long.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_long.Location = new System.Drawing.Point(3, 25);
            this.lbl_long.Name = "lbl_long";
            this.lbl_long.Size = new System.Drawing.Size(70, 16);
            this.lbl_long.TabIndex = 8;
            this.lbl_long.Text = "Longitude:";
            this.lbl_long.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_long_Value
            // 
            this.lbl_long_Value.AutoSize = true;
            this.lbl_long_Value.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_long_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_long_Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_long_Value.Location = new System.Drawing.Point(79, 25);
            this.lbl_long_Value.Name = "lbl_long_Value";
            this.lbl_long_Value.Size = new System.Drawing.Size(12, 16);
            this.lbl_long_Value.TabIndex = 7;
            this.lbl_long_Value.Text = "-";
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 531);
            this.Controls.Add(this.lbl_long);
            this.Controls.Add(this.lbl_long_Value);
            this.Controls.Add(this.lbl_Lat);
            this.Controls.Add(this.lbl_lat_value);
            this.Controls.Add(this.Hindsight_Map);
            this.Controls.Add(this.panel_Map);
            this.Controls.Add(this.toolStrip_bottom);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hindsight";
            this.Shown += new System.EventHandler(this.MapForm_Load);
            this.toolStrip_bottom.ResumeLayout(false);
            this.toolStrip_bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}