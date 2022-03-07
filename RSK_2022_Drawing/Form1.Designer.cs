
namespace RSK_2022_Drawing
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawEllipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complexSignalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTestSignalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveSignalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateSignalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.complexSignalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.Controls.Add(this.pbCanvas, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1100, 540);
            this.tlpMain.TabIndex = 1;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCanvas.Location = new System.Drawing.Point(3, 3);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(874, 534);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawEllipseToolStripMenuItem,
            this.drawGridToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // drawEllipseToolStripMenuItem
            // 
            this.drawEllipseToolStripMenuItem.Name = "drawEllipseToolStripMenuItem";
            this.drawEllipseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawEllipseToolStripMenuItem.Text = "DrawEllipse";
            this.drawEllipseToolStripMenuItem.Click += new System.EventHandler(this.drawEllipseToolStripMenuItem_Click);
            // 
            // drawGridToolStripMenuItem
            // 
            this.drawGridToolStripMenuItem.Name = "drawGridToolStripMenuItem";
            this.drawGridToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawGridToolStripMenuItem.Text = "DrawGrid";
            this.drawGridToolStripMenuItem.Click += new System.EventHandler(this.drawGridToolStripMenuItem_Click);
            // 
            // complexSignalToolStripMenuItem
            // 
            this.complexSignalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTestSignalToolStripMenuItem,
            this.moveSignalToolStripMenuItem,
            this.rotateSignalToolStripMenuItem});
            this.complexSignalToolStripMenuItem.Name = "complexSignalToolStripMenuItem";
            this.complexSignalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.complexSignalToolStripMenuItem.Text = "ComplexSignal";
            // 
            // createTestSignalToolStripMenuItem
            // 
            this.createTestSignalToolStripMenuItem.Name = "createTestSignalToolStripMenuItem";
            this.createTestSignalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createTestSignalToolStripMenuItem.Text = "CreateTestSignal";
            this.createTestSignalToolStripMenuItem.Click += new System.EventHandler(this.createTestSignalToolStripMenuItem_Click);
            // 
            // moveSignalToolStripMenuItem
            // 
            this.moveSignalToolStripMenuItem.Name = "moveSignalToolStripMenuItem";
            this.moveSignalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moveSignalToolStripMenuItem.Text = "MoveSignal";
            this.moveSignalToolStripMenuItem.Click += new System.EventHandler(this.moveSignalToolStripMenuItem_Click);
            // 
            // rotateSignalToolStripMenuItem
            // 
            this.rotateSignalToolStripMenuItem.Name = "rotateSignalToolStripMenuItem";
            this.rotateSignalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotateSignalToolStripMenuItem.Text = "RotateSignal";
            this.rotateSignalToolStripMenuItem.Click += new System.EventHandler(this.rotateSignalToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 564);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawEllipseToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.ToolStripMenuItem drawGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complexSignalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTestSignalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveSignalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateSignalToolStripMenuItem;
    }
}

