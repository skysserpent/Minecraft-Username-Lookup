namespace MinecraftLookup
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2TextBox txtOutput;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUUID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProcessorInformation = new System.Windows.Forms.Label();
            this.lblUUID = new System.Windows.Forms.Label();
            this.lblCurrentName = new System.Windows.Forms.Label();
            this.lblFlags = new System.Windows.Forms.Label();
            this.btnLookupName = new Guna.UI2.WinForms.Guna2Button();
            this.btnLookupUUID = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Minecraft_Form = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsReturn = true;
            this.txtOutput.AcceptsTab = true;
            this.txtOutput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtOutput.BorderRadius = 8;
            this.txtOutput.BorderThickness = 3;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutput.DefaultText = "";
            this.txtOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtOutput.Location = new System.Drawing.Point(437, 18);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.PlaceholderText = "";
            this.txtOutput.SelectedText = "";
            this.txtOutput.Size = new System.Drawing.Size(411, 236);
            this.txtOutput.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtName.BorderRadius = 5;
            this.txtName.BorderThickness = 3;
            this.txtName.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtName.Location = new System.Drawing.Point(25, 20);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 10;
            // 
            // txtUUID
            // 
            this.txtUUID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtUUID.BorderRadius = 5;
            this.txtUUID.BorderThickness = 3;
            this.txtUUID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUUID.DefaultText = "";
            this.txtUUID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUUID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUUID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUUID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUUID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtUUID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtUUID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUUID.ForeColor = System.Drawing.Color.White;
            this.txtUUID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtUUID.Location = new System.Drawing.Point(25, 60);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUUID.PlaceholderText = "";
            this.txtUUID.SelectedText = "";
            this.txtUUID.Size = new System.Drawing.Size(200, 25);
            this.txtUUID.TabIndex = 11;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.lblProcessorInformation);
            this.guna2Panel2.Controls.Add(this.lblUUID);
            this.guna2Panel2.Controls.Add(this.lblCurrentName);
            this.guna2Panel2.Controls.Add(this.lblFlags);
            this.guna2Panel2.Location = new System.Drawing.Point(20, 99);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(411, 155);
            this.guna2Panel2.TabIndex = 14;
            // 
            // lblProcessorInformation
            // 
            this.lblProcessorInformation.AutoSize = true;
            this.lblProcessorInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.lblProcessorInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.lblProcessorInformation.Location = new System.Drawing.Point(152, 15);
            this.lblProcessorInformation.Name = "lblProcessorInformation";
            this.lblProcessorInformation.Size = new System.Drawing.Size(128, 21);
            this.lblProcessorInformation.TabIndex = 13;
            this.lblProcessorInformation.Text = "User Information";
            // 
            // lblUUID
            // 
            this.lblUUID.AutoSize = true;
            this.lblUUID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUUID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUUID.Location = new System.Drawing.Point(15, 50);
            this.lblUUID.Name = "lblUUID";
            this.lblUUID.Size = new System.Drawing.Size(56, 16);
            this.lblUUID.TabIndex = 17;
            this.lblUUID.Text = "UUID: ";
            // 
            // lblCurrentName
            // 
            this.lblCurrentName.AutoSize = true;
            this.lblCurrentName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentName.Location = new System.Drawing.Point(15, 85);
            this.lblCurrentName.Name = "lblCurrentName";
            this.lblCurrentName.Size = new System.Drawing.Size(153, 16);
            this.lblCurrentName.TabIndex = 18;
            this.lblCurrentName.Text = "Current username: ";
            // 
            // lblFlags
            // 
            this.lblFlags.AutoSize = true;
            this.lblFlags.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlags.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFlags.Location = new System.Drawing.Point(15, 121);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(127, 16);
            this.lblFlags.TabIndex = 19;
            this.lblFlags.Text = "Account Flags: ";
            // 
            // btnLookupName
            // 
            this.btnLookupName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnLookupName.BorderRadius = 5;
            this.btnLookupName.BorderThickness = 3;
            this.btnLookupName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLookupName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLookupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLookupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLookupName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLookupName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookupName.ForeColor = System.Drawing.Color.White;
            this.btnLookupName.Location = new System.Drawing.Point(230, 20);
            this.btnLookupName.Name = "btnLookupName";
            this.btnLookupName.Size = new System.Drawing.Size(150, 25);
            this.btnLookupName.TabIndex = 26;
            this.btnLookupName.Text = "Lookup By Name";
            this.btnLookupName.Click += new System.EventHandler(this.btnLookupName_Click_1);
            // 
            // btnLookupUUID
            // 
            this.btnLookupUUID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnLookupUUID.BorderRadius = 5;
            this.btnLookupUUID.BorderThickness = 3;
            this.btnLookupUUID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLookupUUID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLookupUUID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLookupUUID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLookupUUID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLookupUUID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookupUUID.ForeColor = System.Drawing.Color.White;
            this.btnLookupUUID.Location = new System.Drawing.Point(230, 60);
            this.btnLookupUUID.Name = "btnLookupUUID";
            this.btnLookupUUID.Size = new System.Drawing.Size(150, 25);
            this.btnLookupUUID.TabIndex = 27;
            this.btnLookupUUID.Text = "Lookup By UUID";
            this.btnLookupUUID.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 260);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(30, 18);
            this.guna2HtmlLabel1.TabIndex = 28;
            this.guna2HtmlLabel1.Text = "Skin: ";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 289);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(58, 18);
            this.guna2HtmlLabel2.TabIndex = 29;
            this.guna2HtmlLabel2.Text = "Cape URL: ";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // Minecraft_Form
            // 
            this.Minecraft_Form.BorderRadius = 30;
            this.Minecraft_Form.ContainerControl = this;
            this.Minecraft_Form.DockIndicatorTransparencyValue = 1D;
            this.Minecraft_Form.DragStartTransparencyValue = 1D;
            this.Minecraft_Form.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.Minecraft_Form.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2ControlBox1.BorderRadius = 6;
            this.guna2ControlBox1.BorderThickness = 3;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(386, 18);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 67);
            this.guna2ControlBox1.TabIndex = 30;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(872, 331);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnLookupUUID);
            this.Controls.Add(this.btnLookupName);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtUUID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Minecraft Profile Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtUUID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblProcessorInformation;
        private System.Windows.Forms.Label lblUUID;
        private System.Windows.Forms.Label lblCurrentName;
        private System.Windows.Forms.Label lblFlags;
        private Guna.UI2.WinForms.Guna2Button btnLookupName;
        private Guna.UI2.WinForms.Guna2Button btnLookupUUID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm Minecraft_Form;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}
