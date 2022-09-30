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
            this.components = new System.ComponentModel.Container();
            this.btn_CSVLoad = new System.Windows.Forms.Button();
            this.lblDaten = new System.Windows.Forms.Label();
            this.ListBoxWeather = new System.Windows.Forms.ListBox();
            this.ListBoxTemperature = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btn_CSVLoad
            // 
            this.btn_CSVLoad.Location = new System.Drawing.Point(12, 430);
            this.btn_CSVLoad.Name = "btn_CSVLoad";
            this.btn_CSVLoad.Size = new System.Drawing.Size(107, 38);
            this.btn_CSVLoad.TabIndex = 0;
            this.btn_CSVLoad.Text = "Lade CSV";
            this.btn_CSVLoad.UseVisualStyleBackColor = true;
            this.btn_CSVLoad.Click += new System.EventHandler(this.btn_CSVLoad_Click);
            // 
            // lblDaten
            // 
            this.lblDaten.AutoSize = true;
            this.lblDaten.Location = new System.Drawing.Point(12, 18);
            this.lblDaten.Name = "lblDaten";
            this.lblDaten.Size = new System.Drawing.Size(38, 15);
            this.lblDaten.TabIndex = 1;
            this.lblDaten.Text = "Daten";
            // 
            // ListBoxWeather
            // 
            this.ListBoxWeather.FormattingEnabled = true;
            this.ListBoxWeather.ItemHeight = 15;
            this.ListBoxWeather.Location = new System.Drawing.Point(12, 48);
            this.ListBoxWeather.Name = "ListBoxWeather";
            this.ListBoxWeather.Size = new System.Drawing.Size(277, 364);
            this.ListBoxWeather.TabIndex = 2;
            // 
            // ListBoxTemperature
            // 
            this.ListBoxTemperature.FormattingEnabled = true;
            this.ListBoxTemperature.ItemHeight = 15;
            this.ListBoxTemperature.Location = new System.Drawing.Point(321, 47);
            this.ListBoxTemperature.Name = "ListBoxTemperature";
            this.ListBoxTemperature.Size = new System.Drawing.Size(287, 364);
            this.ListBoxTemperature.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.ListBoxTemperature);
            this.Controls.Add(this.ListBoxWeather);
            this.Controls.Add(this.lblDaten);
            this.Controls.Add(this.btn_CSVLoad);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_CSVLoad;
        private Label lblDaten;
        private ListBox ListBoxWeather;
        private ListBox ListBoxTemperature;
        private ContextMenuStrip contextMenuStrip1;
    }
}