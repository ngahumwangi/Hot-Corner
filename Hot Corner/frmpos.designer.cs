namespace Hot_Corner
{
    partial class frmpos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpos));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnorder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnhotcornerspecial = new System.Windows.Forms.Button();
            this.btnwater = new System.Windows.Forms.Button();
            this.btnbeverages = new System.Windows.Forms.Button();
            this.btnlightdishes = new System.Windows.Forms.Button();
            this.btnmain = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.userid = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.lblFull_Name = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.btnorder);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbltotal);
            this.panel3.Controls.Add(this.btnhotcornerspecial);
            this.panel3.Controls.Add(this.btnwater);
            this.panel3.Controls.Add(this.btnbeverages);
            this.panel3.Controls.Add(this.btnlightdishes);
            this.panel3.Controls.Add(this.btnmain);
            this.panel3.Location = new System.Drawing.Point(917, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 494);
            this.panel3.TabIndex = 3;
            // 
            // btnorder
            // 
            this.btnorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnorder.AutoSize = true;
            this.btnorder.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(59, 463);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(15, 18);
            this.btnorder.TabIndex = 149;
            this.btnorder.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 148;
            this.label2.Text = "BALANCE:";
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(72, 417);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(60, 18);
            this.lbltotal.TabIndex = 147;
            this.lbltotal.Text = "TOTAL";
            this.lbltotal.TextChanged += new System.EventHandler(this.lbltotal_TextChanged);
            // 
            // btnhotcornerspecial
            // 
            this.btnhotcornerspecial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnhotcornerspecial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhotcornerspecial.Location = new System.Drawing.Point(7, 339);
            this.btnhotcornerspecial.Name = "btnhotcornerspecial";
            this.btnhotcornerspecial.Size = new System.Drawing.Size(166, 75);
            this.btnhotcornerspecial.TabIndex = 7;
            this.btnhotcornerspecial.Text = "HOTCORNER SPECIALS";
            this.btnhotcornerspecial.UseVisualStyleBackColor = true;
            this.btnhotcornerspecial.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button13_MouseUp);
            // 
            // btnwater
            // 
            this.btnwater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnwater.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnwater.Location = new System.Drawing.Point(7, 261);
            this.btnwater.Name = "btnwater";
            this.btnwater.Size = new System.Drawing.Size(166, 72);
            this.btnwater.TabIndex = 6;
            this.btnwater.Text = "WATER";
            this.btnwater.UseVisualStyleBackColor = true;
            this.btnwater.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button9_MouseUp);
            // 
            // btnbeverages
            // 
            this.btnbeverages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbeverages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbeverages.Location = new System.Drawing.Point(10, 166);
            this.btnbeverages.Name = "btnbeverages";
            this.btnbeverages.Size = new System.Drawing.Size(166, 80);
            this.btnbeverages.TabIndex = 4;
            this.btnbeverages.Text = "BEVERAGES";
            this.btnbeverages.UseVisualStyleBackColor = true;
            this.btnbeverages.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // btnlightdishes
            // 
            this.btnlightdishes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlightdishes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlightdishes.Location = new System.Drawing.Point(10, 81);
            this.btnlightdishes.Name = "btnlightdishes";
            this.btnlightdishes.Size = new System.Drawing.Size(166, 79);
            this.btnlightdishes.TabIndex = 3;
            this.btnlightdishes.Text = "LIGHT DISHES SNACKS";
            this.btnlightdishes.UseVisualStyleBackColor = true;
            this.btnlightdishes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // btnmain
            // 
            this.btnmain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmain.Location = new System.Drawing.Point(10, 4);
            this.btnmain.Name = "btnmain";
            this.btnmain.Size = new System.Drawing.Size(166, 71);
            this.btnmain.TabIndex = 0;
            this.btnmain.Text = "MAIN DISHES";
            this.btnmain.UseVisualStyleBackColor = true;
            this.btnmain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnmain_MouseUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(972, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "FOOD CATEGORY";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 519);
            this.panel1.TabIndex = 6;
            // 
            // groupBox25
            // 
            this.groupBox25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox25.BackgroundImage")));
            this.groupBox25.Controls.Add(this.groupBox27);
            this.groupBox25.Controls.Add(this.lblFull_Name);
            this.groupBox25.Controls.Add(this.label75);
            this.groupBox25.Controls.Add(this.label74);
            this.groupBox25.Controls.Add(this.lblUsername);
            this.groupBox25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox25.Location = new System.Drawing.Point(12, 528);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(391, 53);
            this.groupBox25.TabIndex = 141;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Login Details";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.userid);
            this.groupBox27.Controls.Add(this.lblUID);
            this.groupBox27.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox27.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox27.Location = new System.Drawing.Point(275, 16);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(113, 34);
            this.groupBox27.TabIndex = 8;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "User ID";
            // 
            // userid
            // 
            this.userid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userid.Location = new System.Drawing.Point(3, 16);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(107, 15);
            this.userid.TabIndex = 5;
            this.userid.Text = "userid";
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUID.Location = new System.Drawing.Point(3, 16);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(0, 13);
            this.lblUID.TabIndex = 4;
            // 
            // lblFull_Name
            // 
            this.lblFull_Name.AutoSize = true;
            this.lblFull_Name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFull_Name.Location = new System.Drawing.Point(83, 16);
            this.lblFull_Name.Name = "lblFull_Name";
            this.lblFull_Name.Size = new System.Drawing.Size(46, 13);
            this.lblFull_Name.TabIndex = 7;
            this.lblFull_Name.Text = "fullname";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label75.Location = new System.Drawing.Point(20, 16);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(41, 13);
            this.label75.TabIndex = 6;
            this.label75.Text = " Name:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label74.Location = new System.Drawing.Point(20, 34);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(55, 13);
            this.label74.TabIndex = 5;
            this.label74.Text = "Username";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsername.Location = new System.Drawing.Point(83, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(33, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Login";
            // 
            // groupBox28
            // 
            this.groupBox28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox28.BackgroundImage")));
            this.groupBox28.Controls.Add(this.lblRole);
            this.groupBox28.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox28.Location = new System.Drawing.Point(12, 587);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(180, 53);
            this.groupBox28.TabIndex = 140;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "User Category(You Logged in as)";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRole.Location = new System.Drawing.Point(12, 25);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(24, 13);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "role";
            // 
            // ListView1
            // 
            this.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView1.AllowColumnReorder = true;
            this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListView1.AutoArrange = false;
            this.ListView1.BackColor = System.Drawing.Color.Thistle;
            this.ListView1.CheckBoxes = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.orderqty,
            this.name,
            this.cost});
            this.ListView1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ListView1.FullRowSelect = true;
            this.ListView1.HideSelection = false;
            this.ListView1.HoverSelection = true;
            this.ListView1.Location = new System.Drawing.Point(409, 525);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(533, 137);
            this.ListView1.TabIndex = 142;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // orderqty
            // 
            this.orderqty.Text = "ORDER QTY";
            this.orderqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderqty.Width = 124;
            // 
            // name
            // 
            this.name.Text = "NAME";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 242;
            // 
            // cost
            // 
            this.cost.Text = "COST";
            this.cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cost.Width = 160;
            // 
            // btnremove
            // 
            this.btnremove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(948, 600);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(161, 53);
            this.btnremove.TabIndex = 146;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnremove_MouseUp);
            // 
            // btnsub
            // 
            this.btnsub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(323, 587);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(77, 67);
            this.btnsub.TabIndex = 147;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsub_MouseUp_1);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(247, 587);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(70, 67);
            this.btnadd.TabIndex = 145;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnadd_MouseUp_1);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.Location = new System.Drawing.Point(1032, 525);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(77, 69);
            this.button12.TabIndex = 149;
            this.button12.Text = "CANCEL";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button12_MouseUp);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.Location = new System.Drawing.Point(948, 525);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 69);
            this.button11.TabIndex = 148;
            this.button11.Text = "ORDER";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button11_MouseUp_1);
            // 
            // frmpos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1215, 685);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.groupBox25);
            this.Controls.Add(this.groupBox28);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnbeverages;
        private System.Windows.Forms.Button btnlightdishes;
        private System.Windows.Forms.Button btnmain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnhotcornerspecial;
        private System.Windows.Forms.Button btnwater;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.GroupBox groupBox27;
        public System.Windows.Forms.Label userid;
        public System.Windows.Forms.Label lblUID;
        public System.Windows.Forms.Label lblFull_Name;
        public System.Windows.Forms.Label label75;
        public System.Windows.Forms.Label label74;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBox28;
        public System.Windows.Forms.Label lblRole;
        public System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ColumnHeader orderqty;
        internal System.Windows.Forms.ColumnHeader name;
        internal System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label btnorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotal;

    }
}