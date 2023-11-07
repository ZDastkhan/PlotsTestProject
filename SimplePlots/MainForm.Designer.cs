
namespace SimplePlots
{
    partial class MainForm
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
            this.btnCreateRandom = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateRandom
            // 
            this.btnCreateRandom.Location = new System.Drawing.Point(13, 26);
            this.btnCreateRandom.Name = "btnCreateRandom";
            this.btnCreateRandom.Size = new System.Drawing.Size(168, 23);
            this.btnCreateRandom.TabIndex = 0;
            this.btnCreateRandom.Text = "Create Random Points";
            this.btnCreateRandom.UseVisualStyleBackColor = true;
            this.btnCreateRandom.Click += new System.EventHandler(this.btnCreateRandom_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.zedGraphControl);
            this.pnlMain.Location = new System.Drawing.Point(13, 66);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(775, 372);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.SizeChanged += new System.EventHandler(this.pnlMain_SizeChanged);
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(769, 366);
            this.zedGraphControl.TabIndex = 0;
            this.zedGraphControl.UseExtendedPrintDialog = true;
            this.zedGraphControl.Resize += new System.EventHandler(this.zedGraphControl_Resize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnCreateRandom);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRandom;
        private System.Windows.Forms.Panel pnlMain;
        private ZedGraph.ZedGraphControl zedGraphControl;
    }
}

