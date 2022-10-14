namespace LightController
{
    partial class Main
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
            this.scrollIntensity = new System.Windows.Forms.HScrollBar();
            this.labelIntensity = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.groupMode = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAutomatic = new System.Windows.Forms.RadioButton();
            this.rbMusic = new System.Windows.Forms.RadioButton();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.labelGreen = new System.Windows.Forms.Label();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.labelBlue = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cbAudioDevices = new System.Windows.Forms.ComboBox();
            this.groupMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollIntensity
            // 
            this.scrollIntensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollIntensity.Location = new System.Drawing.Point(107, 19);
            this.scrollIntensity.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.scrollIntensity.Name = "scrollIntensity";
            this.scrollIntensity.Size = new System.Drawing.Size(427, 21);
            this.scrollIntensity.TabIndex = 0;
            this.scrollIntensity.Value = 100;
            this.scrollIntensity.ValueChanged += new System.EventHandler(this.scrollIntensity_ValueChanged);
            // 
            // labelIntensity
            // 
            this.labelIntensity.AutoSize = true;
            this.labelIntensity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIntensity.Location = new System.Drawing.Point(14, 18);
            this.labelIntensity.Name = "labelIntensity";
            this.labelIntensity.Size = new System.Drawing.Size(90, 22);
            this.labelIntensity.TabIndex = 1;
            this.labelIntensity.Text = "Intensity: ";
            this.labelIntensity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRed
            // 
            this.labelRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRed.Location = new System.Drawing.Point(10, 284);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(45, 22);
            this.labelRed.TabIndex = 5;
            this.labelRed.Text = "R";
            this.labelRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupMode
            // 
            this.groupMode.Controls.Add(this.rbManual);
            this.groupMode.Controls.Add(this.rbAutomatic);
            this.groupMode.Controls.Add(this.rbMusic);
            this.groupMode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupMode.Location = new System.Drawing.Point(231, 61);
            this.groupMode.Name = "groupMode";
            this.groupMode.Size = new System.Drawing.Size(100, 100);
            this.groupMode.TabIndex = 8;
            this.groupMode.TabStop = false;
            this.groupMode.Text = "Mode";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbManual.Location = new System.Drawing.Point(6, 77);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(68, 20);
            this.rbManual.TabIndex = 2;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // rbAutomatic
            // 
            this.rbAutomatic.AutoSize = true;
            this.rbAutomatic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAutomatic.Location = new System.Drawing.Point(6, 51);
            this.rbAutomatic.Name = "rbAutomatic";
            this.rbAutomatic.Size = new System.Drawing.Size(85, 20);
            this.rbAutomatic.TabIndex = 1;
            this.rbAutomatic.Text = "Automatic";
            this.rbAutomatic.UseVisualStyleBackColor = true;
            this.rbAutomatic.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // rbMusic
            // 
            this.rbMusic.AutoSize = true;
            this.rbMusic.Checked = true;
            this.rbMusic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbMusic.Location = new System.Drawing.Point(6, 25);
            this.rbMusic.Name = "rbMusic";
            this.rbMusic.Size = new System.Drawing.Size(61, 20);
            this.rbMusic.TabIndex = 0;
            this.rbMusic.TabStop = true;
            this.rbMusic.Text = "Music";
            this.rbMusic.UseVisualStyleBackColor = true;
            this.rbMusic.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // trackRed
            // 
            this.trackRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackRed.Location = new System.Drawing.Point(18, 61);
            this.trackRed.Maximum = 20;
            this.trackRed.Name = "trackRed";
            this.trackRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackRed.Size = new System.Drawing.Size(45, 212);
            this.trackRed.TabIndex = 9;
            this.trackRed.Value = 10;
            this.trackRed.ValueChanged += new System.EventHandler(this.trackRed_ValueChanged);
            // 
            // trackGreen
            // 
            this.trackGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackGreen.Location = new System.Drawing.Point(86, 61);
            this.trackGreen.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.trackGreen.Maximum = 20;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackGreen.Size = new System.Drawing.Size(45, 212);
            this.trackGreen.TabIndex = 11;
            this.trackGreen.Value = 10;
            this.trackGreen.ValueChanged += new System.EventHandler(this.trackRed_ValueChanged);
            // 
            // labelGreen
            // 
            this.labelGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGreen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGreen.Location = new System.Drawing.Point(78, 284);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(45, 22);
            this.labelGreen.TabIndex = 10;
            this.labelGreen.Text = "G";
            this.labelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBlue
            // 
            this.trackBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBlue.Location = new System.Drawing.Point(154, 61);
            this.trackBlue.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.trackBlue.Maximum = 20;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBlue.Size = new System.Drawing.Size(45, 212);
            this.trackBlue.TabIndex = 13;
            this.trackBlue.Value = 10;
            this.trackBlue.ValueChanged += new System.EventHandler(this.trackRed_ValueChanged);
            // 
            // labelBlue
            // 
            this.labelBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBlue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBlue.Location = new System.Drawing.Point(146, 284);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(45, 22);
            this.labelBlue.TabIndex = 12;
            this.labelBlue.Text = "B";
            this.labelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(231, 256);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(300, 41);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPreview.BackColor = System.Drawing.Color.White;
            this.pbPreview.Location = new System.Drawing.Point(358, 61);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(173, 100);
            this.pbPreview.TabIndex = 15;
            this.pbPreview.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.Location = new System.Drawing.Point(231, 209);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(300, 41);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cbAudioDevices
            // 
            this.cbAudioDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAudioDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioDevices.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbAudioDevices.FormattingEnabled = true;
            this.cbAudioDevices.Location = new System.Drawing.Point(231, 172);
            this.cbAudioDevices.Name = "cbAudioDevices";
            this.cbAudioDevices.Size = new System.Drawing.Size(300, 25);
            this.cbAudioDevices.TabIndex = 17;
            this.cbAudioDevices.SelectedIndexChanged += new System.EventHandler(this.cbAudioDevices_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 315);
            this.Controls.Add(this.cbAudioDevices);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.trackBlue);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.trackGreen);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.trackRed);
            this.Controls.Add(this.groupMode);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.labelIntensity);
            this.Controls.Add(this.scrollIntensity);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Light Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupMode.ResumeLayout(false);
            this.groupMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrollIntensity;
        private System.Windows.Forms.Label labelIntensity;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.GroupBox groupMode;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAutomatic;
        private System.Windows.Forms.RadioButton rbMusic;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ComboBox cbAudioDevices;
    }
}