/* =============================================================================
 * RegexRenamer                                               Copyright (c) 2023
 * https://github.com/joshg253/RegexRenamer
 * 
 * This program is free software; you can redistribute it and/or modify it under
 * the terms of the GNU General Public License v2, as published by the Free
 * Software Foundation.
 * 
 * This program is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 * =============================================================================
 */


namespace RegexRenamer
{
  partial class About
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnOK = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.linkHomepage = new System.Windows.Forms.LinkLabel();
            this.lblStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(207, 182);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(16, 16);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(291, 55);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "RegexRenamer v0.0\r\nCopyright © 2023\r\nGNU General Public License\r\n";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkHomepage
            // 
            this.linkHomepage.AutoSize = true;
            this.linkHomepage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkHomepage.Location = new System.Drawing.Point(16, 80);
            this.linkHomepage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkHomepage.Name = "linkHomepage";
            this.linkHomepage.Size = new System.Drawing.Size(269, 16);
            this.linkHomepage.TabIndex = 3;
            this.linkHomepage.TabStop = true;
            this.linkHomepage.Text = "https://github.com/joshg253/RegexRenamer";
            this.linkHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHomepage_LinkClicked);
            // 
            // lblStats
            // 
            this.lblStats.Location = new System.Drawing.Point(16, 120);
            this.lblStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(291, 32);
            this.lblStats.TabIndex = 5;
            this.lblStats.Text = "RegexRenamer has been run ___ times and renamed a total of ___ files.";
            // 
            // About
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(323, 225);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.linkHomepage);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About RegexRenamer";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.LinkLabel linkHomepage;
    private System.Windows.Forms.Label lblStats;
  }
}