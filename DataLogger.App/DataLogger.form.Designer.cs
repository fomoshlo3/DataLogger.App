namespace DataLogger.App
{
    partial class MainForm
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
            this.btn_CSVLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CSVLoad
            // 
            this.btn_CSVLoad.Location = new System.Drawing.Point(92, 354);
            this.btn_CSVLoad.Name = "btn_CSVLoad";
            this.btn_CSVLoad.Size = new System.Drawing.Size(107, 38);
            this.btn_CSVLoad.TabIndex = 0;
            this.btn_CSVLoad.Text = "Lade CSV";
            this.btn_CSVLoad.UseVisualStyleBackColor = true;
            this.btn_CSVLoad.Click += new System.EventHandler(this.btn_CSVLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.btn_CSVLoad);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_CSVLoad;
    }
}