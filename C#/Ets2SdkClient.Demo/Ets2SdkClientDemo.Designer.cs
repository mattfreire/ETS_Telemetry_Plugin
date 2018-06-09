namespace Ets2SdkClient.Demo
{
    partial class Ets2SdkClientDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ets2SdkClientDemo));
            this.telemetryInfo = new System.Windows.Forms.TabControl();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lbl_export = new System.Windows.Forms.Label();
            this.export_csv = new System.Windows.Forms.Button();
            this.lbGeneral = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDemo = new System.Windows.Forms.Label();
            this.telemetryInfo.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // telemetryInfo
            // 
            this.telemetryInfo.Controls.Add(this.tabAbout);
            this.telemetryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telemetryInfo.Location = new System.Drawing.Point(0, 0);
            this.telemetryInfo.Name = "telemetryInfo";
            this.telemetryInfo.SelectedIndex = 0;
            this.telemetryInfo.Size = new System.Drawing.Size(595, 621);
            this.telemetryInfo.TabIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lbl_export);
            this.tabAbout.Controls.Add(this.export_csv);
            this.tabAbout.Controls.Add(this.lbGeneral);
            this.tabAbout.Controls.Add(this.richTextBox1);
            this.tabAbout.Controls.Add(this.lblDemo);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(587, 595);
            this.tabAbout.TabIndex = 0;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lbl_export
            // 
            this.lbl_export.AutoSize = true;
            this.lbl_export.Location = new System.Drawing.Point(20, 459);
            this.lbl_export.Name = "lbl_export";
            this.lbl_export.Size = new System.Drawing.Size(88, 13);
            this.lbl_export.TabIndex = 4;
            this.lbl_export.Text = "Export File: None";
            // 
            // export_csv
            // 
            this.export_csv.Location = new System.Drawing.Point(494, 459);
            this.export_csv.Name = "export_csv";
            this.export_csv.Size = new System.Drawing.Size(75, 23);
            this.export_csv.TabIndex = 3;
            this.export_csv.Text = "Export CSV";
            this.export_csv.UseVisualStyleBackColor = true;
            this.export_csv.Click += new System.EventHandler(this.export_csv_Click);
            // 
            // lbGeneral
            // 
            this.lbGeneral.Location = new System.Drawing.Point(20, 210);
            this.lbGeneral.Name = "lbGeneral";
            this.lbGeneral.Size = new System.Drawing.Size(549, 243);
            this.lbGeneral.TabIndex = 2;
            this.lbGeneral.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(549, 122);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lblDemo
            // 
            this.lblDemo.AutoSize = true;
            this.lblDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemo.Location = new System.Drawing.Point(132, 33);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(336, 25);
            this.lblDemo.TabIndex = 0;
            this.lblDemo.Text = "ETS2 SDK Telemetry C# Demo";
            // 
            // Ets2SdkClientDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 621);
            this.Controls.Add(this.telemetryInfo);
            this.Name = "Ets2SdkClientDemo";
            this.Text = "Ets2SdkClientDemo 1.4.0";
            this.telemetryInfo.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl telemetryInfo;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblDemo;
        private System.Windows.Forms.RichTextBox lbGeneral;
        private System.Windows.Forms.Button export_csv;
        private System.Windows.Forms.Label lbl_export;
    }
}

