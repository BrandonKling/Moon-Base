namespace Moonbase_Alpha
{
    partial class FormMain
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
        //objects in my program
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RoomNameBox = new System.Windows.Forms.TextBox();
            this.Location = new System.Windows.Forms.GroupBox();
            this.RoomDescriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Excavation = new System.Windows.Forms.Button();
            this.Earth = new System.Windows.Forms.Button();
            this.Hazardous = new System.Windows.Forms.Button();
            this.VehicleYard = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Location.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoomNameBox
            // 
            this.RoomNameBox.AccessibleName = "Area Desciption";
            this.RoomNameBox.Location = new System.Drawing.Point(19, 55);
            this.RoomNameBox.Name = "RoomNameBox";
            this.RoomNameBox.ReadOnly = true;
            this.RoomNameBox.Size = new System.Drawing.Size(336, 23);
            this.RoomNameBox.TabIndex = 1;
            this.RoomNameBox.Text = "Serenity Base Alpha";
            this.RoomNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Location.Controls.Add(this.RoomDescriptionBox);
            this.Location.Controls.Add(this.label2);
            this.Location.Controls.Add(this.label1);
            this.Location.Controls.Add(this.RoomNameBox);
            this.Location.Location = new System.Drawing.Point(1610, 416);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(376, 303);
            this.Location.TabIndex = 2;
            this.Location.TabStop = false;
            this.Location.Text = "Location Information";
            this.Location.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RoomDescriptionBox
            // 
            this.RoomDescriptionBox.Location = new System.Drawing.Point(19, 148);
            this.RoomDescriptionBox.Multiline = true;
            this.RoomDescriptionBox.Name = "RoomDescriptionBox";
            this.RoomDescriptionBox.ReadOnly = true;
            this.RoomDescriptionBox.Size = new System.Drawing.Size(336, 134);
            this.RoomDescriptionBox.TabIndex = 3;
            this.RoomDescriptionBox.Text = "This is Serenity base from the ridge to the north. You can see our advanced Biodo" +
    "me, vehicle operations center, and main living area.";
            this.RoomDescriptionBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.Home);
            this.groupBox1.Controls.Add(this.Excavation);
            this.groupBox1.Controls.Add(this.Earth);
            this.groupBox1.Controls.Add(this.Hazardous);
            this.groupBox1.Controls.Add(this.VehicleYard);
            this.groupBox1.Location = new System.Drawing.Point(150, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Nav Device";
            // 
            // Excavation
            // 
            this.Excavation.BackColor = System.Drawing.SystemColors.Info;
            this.Excavation.Location = new System.Drawing.Point(70, 165);
            this.Excavation.Name = "Excavation";
            this.Excavation.Size = new System.Drawing.Size(60, 60);
            this.Excavation.TabIndex = 3;
            this.Excavation.Text = "Excavation Site";
            this.Excavation.UseVisualStyleBackColor = false;
            this.Excavation.Click += new System.EventHandler(this.South_Click);
            // 
            // Earth
            // 
            this.Earth.BackColor = System.Drawing.SystemColors.Info;
            this.Earth.Location = new System.Drawing.Point(105, 98);
            this.Earth.Name = "Earth";
            this.Earth.Size = new System.Drawing.Size(60, 60);
            this.Earth.TabIndex = 2;
            this.Earth.Text = "Earth View";
            this.Earth.UseVisualStyleBackColor = false;
            this.Earth.Click += new System.EventHandler(this.button3_Click);
            // 
            // Hazardous
            // 
            this.Hazardous.BackColor = System.Drawing.SystemColors.Info;
            this.Hazardous.Location = new System.Drawing.Point(35, 98);
            this.Hazardous.Name = "Hazardous";
            this.Hazardous.Size = new System.Drawing.Size(60, 60);
            this.Hazardous.TabIndex = 1;
            this.Hazardous.Text = "Hazardous Waste";
            this.Hazardous.UseVisualStyleBackColor = false;
            this.Hazardous.Click += new System.EventHandler(this.button2_Click);
            // 
            // VehicleYard
            // 
            this.VehicleYard.BackColor = System.Drawing.SystemColors.Info;
            this.VehicleYard.Location = new System.Drawing.Point(70, 32);
            this.VehicleYard.Name = "VehicleYard";
            this.VehicleYard.Size = new System.Drawing.Size(60, 60);
            this.VehicleYard.TabIndex = 0;
            this.VehicleYard.Text = "Vehicle Yard";
            this.VehicleYard.UseVisualStyleBackColor = false;
            this.VehicleYard.Click += new System.EventHandler(this.North_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.GrayText;
            this.Home.Location = new System.Drawing.Point(136, 221);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(58, 23);
            this.Home.TabIndex = 4;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase_Alpha.Properties.Resources.Mars_Base;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2032, 985);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Location);
            this.Name = "FormMain";
            this.Text = "Sereniy Base Alpha";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox RoomNameBox;
        private GroupBox Location;
        public Label label1;
        private Label label2;
        private TextBox RoomDescriptionBox;
        private GroupBox groupBox1;
        private Button Excavation;
        private Button Earth;
        private Button Hazardous;
        private Button VehicleYard;
        private Button Home;
    }
}