﻿namespace lucidcode.LucidScribe.Plugin.NeuroSky.MindSet
{
  partial class PortForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortForm));
      this.pnlPlugins = new lucidcode.Controls.Panel3D();
      this.lstPorts = new System.Windows.Forms.ListView();
      this.mnuPortsList = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuRefreshPorts = new System.Windows.Forms.ToolStripMenuItem();
      this.lstImg = new System.Windows.Forms.ImageList(this.components);
      this.Panel3D4 = new lucidcode.Controls.Panel3D();
      this.Label5 = new System.Windows.Forms.Label();
      this.Label6 = new System.Windows.Forms.Label();
      this.panel3D3 = new lucidcode.Controls.Panel3D();
      this.chkTCMP = new System.Windows.Forms.CheckBox();
      this.label8 = new System.Windows.Forms.Label();
      this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panel3D5 = new lucidcode.Controls.Panel3D();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbThreshold = new System.Windows.Forms.ComboBox();
      this.pnlPlugins.SuspendLayout();
      this.mnuPortsList.SuspendLayout();
      this.Panel3D4.SuspendLayout();
      this.panel3D3.SuspendLayout();
      this.panel3D5.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlPlugins
      // 
      this.pnlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlPlugins.BackColor = System.Drawing.Color.White;
      this.pnlPlugins.Controls.Add(this.lstPorts);
      this.pnlPlugins.Controls.Add(this.Panel3D4);
      this.pnlPlugins.Location = new System.Drawing.Point(12, 12);
      this.pnlPlugins.Name = "pnlPlugins";
      this.pnlPlugins.Size = new System.Drawing.Size(359, 284);
      this.pnlPlugins.TabIndex = 5;
      // 
      // lstPorts
      // 
      this.lstPorts.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.lstPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lstPorts.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstPorts.ContextMenuStrip = this.mnuPortsList;
      this.lstPorts.LargeImageList = this.lstImg;
      this.lstPorts.Location = new System.Drawing.Point(3, 25);
      this.lstPorts.MultiSelect = false;
      this.lstPorts.Name = "lstPorts";
      this.lstPorts.Size = new System.Drawing.Size(353, 256);
      this.lstPorts.TabIndex = 8;
      this.lstPorts.TileSize = new System.Drawing.Size(150, 32);
      this.lstPorts.UseCompatibleStateImageBehavior = false;
      this.lstPorts.View = System.Windows.Forms.View.Tile;
      this.lstPorts.SelectedIndexChanged += new System.EventHandler(this.lstPlaylists_SelectedIndexChanged);
      this.lstPorts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstPlaylists_MouseMove);
      // 
      // mnuPortsList
      // 
      this.mnuPortsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefreshPorts});
      this.mnuPortsList.Name = "contextMenuStrip1";
      this.mnuPortsList.Size = new System.Drawing.Size(114, 26);
      // 
      // mnuRefreshPorts
      // 
      this.mnuRefreshPorts.Name = "mnuRefreshPorts";
      this.mnuRefreshPorts.Size = new System.Drawing.Size(113, 22);
      this.mnuRefreshPorts.Text = "&Refresh";
      this.mnuRefreshPorts.Click += new System.EventHandler(this.mnuRefresh_Click);
      // 
      // lstImg
      // 
      this.lstImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImg.ImageStream")));
      this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
      this.lstImg.Images.SetKeyName(0, "Graph.Plugin2.bmp");
      // 
      // Panel3D4
      // 
      this.Panel3D4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.Panel3D4.BackColor = System.Drawing.Color.SteelBlue;
      this.Panel3D4.Controls.Add(this.Label5);
      this.Panel3D4.Controls.Add(this.Label6);
      this.Panel3D4.Location = new System.Drawing.Point(0, 0);
      this.Panel3D4.Name = "Panel3D4";
      this.Panel3D4.Size = new System.Drawing.Size(359, 24);
      this.Panel3D4.TabIndex = 4;
      // 
      // Label5
      // 
      this.Label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
      this.Label5.ForeColor = System.Drawing.Color.White;
      this.Label5.Image = ((System.Drawing.Image)(resources.GetObject("Label5.Image")));
      this.Label5.Location = new System.Drawing.Point(3, 3);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(19, 19);
      this.Label5.TabIndex = 4;
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label6
      // 
      this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.Label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
      this.Label6.ForeColor = System.Drawing.Color.White;
      this.Label6.Location = new System.Drawing.Point(24, 3);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(332, 19);
      this.Label6.TabIndex = 3;
      this.Label6.Text = "Select port to connect";
      this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel3D3
      // 
      this.panel3D3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3D3.BackColor = System.Drawing.Color.LightSteelBlue;
      this.panel3D3.Controls.Add(this.chkTCMP);
      this.panel3D3.Controls.Add(this.label8);
      this.panel3D3.Controls.Add(this.cmbAlgorithm);
      this.panel3D3.Controls.Add(this.label2);
      this.panel3D3.Controls.Add(this.panel3D5);
      this.panel3D3.Controls.Add(this.cmbThreshold);
      this.panel3D3.Location = new System.Drawing.Point(12, 302);
      this.panel3D3.Name = "panel3D3";
      this.panel3D3.Size = new System.Drawing.Size(359, 106);
      this.panel3D3.TabIndex = 37;
      // 
      // chkTCMP
      // 
      this.chkTCMP.Location = new System.Drawing.Point(99, 84);
      this.chkTCMP.Name = "chkTCMP";
      this.chkTCMP.Size = new System.Drawing.Size(151, 17);
      this.chkTCMP.TabIndex = 283;
      this.chkTCMP.Text = "TCMP";
      this.chkTCMP.UseVisualStyleBackColor = true;
      this.chkTCMP.CheckedChanged += new System.EventHandler(this.chkTCMP_CheckedChanged);
      // 
      // label8
      // 
      this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
      this.label8.Location = new System.Drawing.Point(6, 57);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(85, 21);
      this.label8.TabIndex = 276;
      this.label8.Text = "Threshold";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cmbAlgorithm
      // 
      this.cmbAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbAlgorithm.FormattingEnabled = true;
      this.cmbAlgorithm.Items.AddRange(new object[] {
            "Motion Detector",
            "REM Detector",
            "Gamma Detector"});
      this.cmbAlgorithm.Location = new System.Drawing.Point(99, 30);
      this.cmbAlgorithm.Name = "cmbAlgorithm";
      this.cmbAlgorithm.Size = new System.Drawing.Size(254, 21);
      this.cmbAlgorithm.TabIndex = 275;
      this.cmbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cmbAlgorithm_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
      this.label2.Location = new System.Drawing.Point(6, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 21);
      this.label2.TabIndex = 271;
      this.label2.Text = "Algorithm";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel3D5
      // 
      this.panel3D5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3D5.BackColor = System.Drawing.Color.SteelBlue;
      this.panel3D5.Controls.Add(this.label3);
      this.panel3D5.Controls.Add(this.label4);
      this.panel3D5.Location = new System.Drawing.Point(0, 0);
      this.panel3D5.Name = "panel3D5";
      this.panel3D5.Size = new System.Drawing.Size(359, 24);
      this.panel3D5.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
      this.label3.Location = new System.Drawing.Point(3, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(19, 19);
      this.label3.TabIndex = 4;
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(24, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(332, 19);
      this.label4.TabIndex = 3;
      this.label4.Text = "Settings";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cmbThreshold
      // 
      this.cmbThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbThreshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbThreshold.FormattingEnabled = true;
      this.cmbThreshold.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
      this.cmbThreshold.Location = new System.Drawing.Point(99, 57);
      this.cmbThreshold.Name = "cmbThreshold";
      this.cmbThreshold.Size = new System.Drawing.Size(254, 21);
      this.cmbThreshold.TabIndex = 33;
      this.cmbThreshold.SelectedIndexChanged += new System.EventHandler(this.cmbThreshold_SelectedIndexChanged);
      // 
      // PortForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSteelBlue;
      this.ClientSize = new System.Drawing.Size(383, 420);
      this.Controls.Add(this.pnlPlugins);
      this.Controls.Add(this.panel3D3);
      this.Font = new System.Drawing.Font("Verdana", 8.25F);
      this.ForeColor = System.Drawing.Color.MidnightBlue;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "PortForm";
      this.Text = "Lucid Scribe - NeuroSky ThinkGear EEG";
      this.Load += new System.EventHandler(this.PortForm_Load);
      this.pnlPlugins.ResumeLayout(false);
      this.mnuPortsList.ResumeLayout(false);
      this.Panel3D4.ResumeLayout(false);
      this.panel3D3.ResumeLayout(false);
      this.panel3D5.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    internal lucidcode.Controls.Panel3D pnlPlugins;
    internal lucidcode.Controls.Panel3D Panel3D4;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.ListView lstPorts;
    internal System.Windows.Forms.ImageList lstImg;
    private System.Windows.Forms.ContextMenuStrip mnuPortsList;
    private System.Windows.Forms.ToolStripMenuItem mnuRefreshPorts;
    internal lucidcode.Controls.Panel3D panel3D3;
    internal System.Windows.Forms.Label label8;
    private System.Windows.Forms.ComboBox cmbAlgorithm;
    internal System.Windows.Forms.Label label2;
    internal lucidcode.Controls.Panel3D panel3D5;
    internal System.Windows.Forms.Label label3;
    internal System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbThreshold;
    private System.Windows.Forms.CheckBox chkTCMP;
  }
}