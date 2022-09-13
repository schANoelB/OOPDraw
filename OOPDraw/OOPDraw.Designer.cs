
namespace OOPDraw
{
    partial class OOPDraw
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.LineWidth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Shape = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.Window;
            this.Canvas.Location = new System.Drawing.Point(287, 17);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1076, 656);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // LineWidth
            // 
            this.LineWidth.FormattingEnabled = true;
            this.LineWidth.Items.AddRange(new object[] {
            "Thin",
            "Medium",
            "Thick"});
            this.LineWidth.Location = new System.Drawing.Point(12, 35);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(121, 23);
            this.LineWidth.TabIndex = 1;
            this.LineWidth.SelectedIndexChanged += new System.EventHandler(this.LineWidth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Line Width";
            // 
            // Colour
            // 
            this.Colour.FormattingEnabled = true;
            this.Colour.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.Colour.Location = new System.Drawing.Point(160, 35);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(121, 23);
            this.Colour.TabIndex = 3;
            this.Colour.SelectedIndexChanged += new System.EventHandler(this.Colour_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shape";
            // 
            // Shape
            // 
            this.Shape.FormattingEnabled = true;
            this.Shape.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Ellipse",
            "Circle"});
            this.Shape.Location = new System.Drawing.Point(12, 99);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(121, 23);
            this.Shape.TabIndex = 6;
            this.Shape.SelectedIndexChanged += new System.EventHandler(this.Shape_SelectedIndexChanged);
            // 
            // OOPDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 685);
            this.Controls.Add(this.Shape);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LineWidth);
            this.Controls.Add(this.Canvas);
            this.Name = "OOPDraw";
            this.Text = "OOPDraw";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.ComboBox LineWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Colour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Shape;
    }
}

