namespace CapeTownFestival.PresentationLayer
{
    partial class Festivals
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
            this.FestivalsListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.themeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FestivalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FestivalsListView
            // 
            this.FestivalsListView.BackColor = System.Drawing.Color.White;
            this.FestivalsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.locationHeader,
            this.themeHeader,
            this.dateHeader});
            this.FestivalsListView.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FestivalsListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FestivalsListView.GridLines = true;
            this.FestivalsListView.Location = new System.Drawing.Point(13, 35);
            this.FestivalsListView.Name = "FestivalsListView";
            this.FestivalsListView.Size = new System.Drawing.Size(549, 146);
            this.FestivalsListView.TabIndex = 0;
            this.FestivalsListView.UseCompatibleStateImageBehavior = false;
            this.FestivalsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Festival Name";
            this.nameHeader.Width = 160;
            // 
            // locationHeader
            // 
            this.locationHeader.Text = "Festival Location";
            this.locationHeader.Width = 185;
            // 
            // themeHeader
            // 
            this.themeHeader.Text = "Festival Theme";
            this.themeHeader.Width = 100;
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Festival Date";
            this.dateHeader.Width = 100;
            // 
            // FestivalLabel
            // 
            this.FestivalLabel.AutoSize = true;
            this.FestivalLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FestivalLabel.Location = new System.Drawing.Point(13, 13);
            this.FestivalLabel.Name = "FestivalLabel";
            this.FestivalLabel.Size = new System.Drawing.Size(63, 16);
            this.FestivalLabel.TabIndex = 1;
            this.FestivalLabel.Text = "Festivals";
            // 
            // Festivals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 194);
            this.Controls.Add(this.FestivalLabel);
            this.Controls.Add(this.FestivalsListView);
            this.Name = "Festivals";
            this.Text = "Festivals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Festivals_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView FestivalsListView;
        private System.Windows.Forms.Label FestivalLabel;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader locationHeader;
        private System.Windows.Forms.ColumnHeader themeHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
    }
}