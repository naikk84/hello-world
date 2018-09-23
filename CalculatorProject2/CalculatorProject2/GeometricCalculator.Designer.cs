namespace CalculatorProject2
{
    partial class GeometricCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAreaTrapezoid = new System.Windows.Forms.Button();
            this.txtAreaRectangle = new System.Windows.Forms.Button();
            this.txtAreaTriangle = new System.Windows.Forms.Button();
            this.txtAreaCylinder = new System.Windows.Forms.Button();
            this.txtAreaParallelogram = new System.Windows.Forms.Button();
            this.txtAreaEllipse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerimeterRectangle = new System.Windows.Forms.Button();
            this.txtPerimeterTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area Of Geometric Shape";
            // 
            // txtAreaTrapezoid
            // 
            this.txtAreaTrapezoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaTrapezoid.Location = new System.Drawing.Point(289, 75);
            this.txtAreaTrapezoid.Margin = new System.Windows.Forms.Padding(2);
            this.txtAreaTrapezoid.Name = "txtAreaTrapezoid";
            this.txtAreaTrapezoid.Size = new System.Drawing.Size(238, 30);
            this.txtAreaTrapezoid.TabIndex = 1;
            this.txtAreaTrapezoid.Text = "Area of trapezoid ";
            this.txtAreaTrapezoid.UseVisualStyleBackColor = true;
            this.txtAreaTrapezoid.Click += new System.EventHandler(this.txtAreaTrapezoid_Click);
            // 
            // txtAreaRectangle
            // 
            this.txtAreaRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaRectangle.Location = new System.Drawing.Point(289, 110);
            this.txtAreaRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.txtAreaRectangle.Name = "txtAreaRectangle";
            this.txtAreaRectangle.Size = new System.Drawing.Size(238, 29);
            this.txtAreaRectangle.TabIndex = 2;
            this.txtAreaRectangle.Text = "Area of rectangle ";
            this.txtAreaRectangle.UseVisualStyleBackColor = true;
            // 
            // txtAreaTriangle
            // 
            this.txtAreaTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaTriangle.Location = new System.Drawing.Point(289, 144);
            this.txtAreaTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.txtAreaTriangle.Name = "txtAreaTriangle";
            this.txtAreaTriangle.Size = new System.Drawing.Size(238, 28);
            this.txtAreaTriangle.TabIndex = 3;
            this.txtAreaTriangle.Text = "Area of triangle ";
            this.txtAreaTriangle.UseVisualStyleBackColor = true;
            // 
            // txtAreaCylinder
            // 
            this.txtAreaCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaCylinder.Location = new System.Drawing.Point(289, 176);
            this.txtAreaCylinder.Margin = new System.Windows.Forms.Padding(2);
            this.txtAreaCylinder.Name = "txtAreaCylinder";
            this.txtAreaCylinder.Size = new System.Drawing.Size(238, 28);
            this.txtAreaCylinder.TabIndex = 4;
            this.txtAreaCylinder.Text = "Area of cylinder ";
            this.txtAreaCylinder.UseVisualStyleBackColor = true;
            // 
            // txtAreaParallelogram
            // 
            this.txtAreaParallelogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaParallelogram.Location = new System.Drawing.Point(289, 210);
            this.txtAreaParallelogram.Margin = new System.Windows.Forms.Padding(2);
            this.txtAreaParallelogram.Name = "txtAreaParallelogram";
            this.txtAreaParallelogram.Size = new System.Drawing.Size(238, 34);
            this.txtAreaParallelogram.TabIndex = 5;
            this.txtAreaParallelogram.Text = "Area of parallelogram ";
            this.txtAreaParallelogram.UseVisualStyleBackColor = true;
            // 
            // txtAreaEllipse
            // 
            this.txtAreaEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaEllipse.Location = new System.Drawing.Point(289, 249);
            this.txtAreaEllipse.Margin = new System.Windows.Forms.Padding(2);
            this.txtAreaEllipse.Name = "txtAreaEllipse";
            this.txtAreaEllipse.Size = new System.Drawing.Size(238, 32);
            this.txtAreaEllipse.TabIndex = 6;
            this.txtAreaEllipse.Text = "Area of ellipse ";
            this.txtAreaEllipse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Perimeter of Geometric Shapes";
            // 
            // txtPerimeterRectangle
            // 
            this.txtPerimeterRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimeterRectangle.Location = new System.Drawing.Point(289, 326);
            this.txtPerimeterRectangle.Name = "txtPerimeterRectangle";
            this.txtPerimeterRectangle.Size = new System.Drawing.Size(238, 35);
            this.txtPerimeterRectangle.TabIndex = 8;
            this.txtPerimeterRectangle.Text = "Perimeter of Rectangle";
            this.txtPerimeterRectangle.UseVisualStyleBackColor = true;
            this.txtPerimeterRectangle.Click += new System.EventHandler(this.txtPerimeterRectangle_Click);
            // 
            // txtPerimeterTriangle
            // 
            this.txtPerimeterTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimeterTriangle.Location = new System.Drawing.Point(289, 367);
            this.txtPerimeterTriangle.Name = "txtPerimeterTriangle";
            this.txtPerimeterTriangle.Size = new System.Drawing.Size(238, 32);
            this.txtPerimeterTriangle.TabIndex = 9;
            this.txtPerimeterTriangle.Text = "Perimeter of Triangle";
            this.txtPerimeterTriangle.UseVisualStyleBackColor = true;
            this.txtPerimeterTriangle.Click += new System.EventHandler(this.txtPerimeterTriangle_Click);
            // 
            // GeometricCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPerimeterTriangle);
            this.Controls.Add(this.txtPerimeterRectangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAreaEllipse);
            this.Controls.Add(this.txtAreaParallelogram);
            this.Controls.Add(this.txtAreaCylinder);
            this.Controls.Add(this.txtAreaTriangle);
            this.Controls.Add(this.txtAreaRectangle);
            this.Controls.Add(this.txtAreaTrapezoid);
            this.Controls.Add(this.label1);
            this.Name = "GeometricCalculator";
            this.Text = "Geometric Calculator";
            this.Load += new System.EventHandler(this.GeometricCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtAreaTrapezoid;
        private System.Windows.Forms.Button txtAreaRectangle;
        private System.Windows.Forms.Button txtAreaTriangle;
        private System.Windows.Forms.Button txtAreaCylinder;
        private System.Windows.Forms.Button txtAreaParallelogram;
        private System.Windows.Forms.Button txtAreaEllipse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtPerimeterRectangle;
        private System.Windows.Forms.Button txtPerimeterTriangle;
    }
}