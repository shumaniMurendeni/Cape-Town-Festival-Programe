namespace CapeTownFestival.PresentationLayer
{
    partial class StallOwnerForm
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
            this.StallOwnerListView = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CultureHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.CultureLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CultureTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.RichTextBox();
            this.SaleItemsListView = new System.Windows.Forms.ListView();
            this.ItemNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CostHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StallOwnerLabel = new System.Windows.Forms.Label();
            this.SaleItemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StallOwnerListView
            // 
            this.StallOwnerListView.BackColor = System.Drawing.Color.White;
            this.StallOwnerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.AgeHeader,
            this.GenderHeader,
            this.CultureHeader,
            this.AddressHeader});
            this.StallOwnerListView.Font = new System.Drawing.Font("Arial", 9F);
            this.StallOwnerListView.GridLines = true;
            this.StallOwnerListView.Location = new System.Drawing.Point(13, 26);
            this.StallOwnerListView.Name = "StallOwnerListView";
            this.StallOwnerListView.Size = new System.Drawing.Size(618, 176);
            this.StallOwnerListView.TabIndex = 0;
            this.StallOwnerListView.UseCompatibleStateImageBehavior = false;
            this.StallOwnerListView.View = System.Windows.Forms.View.Details;
            this.StallOwnerListView.SelectedIndexChanged += new System.EventHandler(this.StallOwnerListView_SelectedIndexChanged);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 170;
            // 
            // AgeHeader
            // 
            this.AgeHeader.Text = "Age";
            this.AgeHeader.Width = 59;
            // 
            // GenderHeader
            // 
            this.GenderHeader.Text = "Gender";
            this.GenderHeader.Width = 59;
            // 
            // CultureHeader
            // 
            this.CultureHeader.Text = "Culture";
            this.CultureHeader.Width = 100;
            // 
            // AddressHeader
            // 
            this.AddressHeader.Text = "Address";
            this.AddressHeader.Width = 226;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRadioButton.Location = new System.Drawing.Point(13, 219);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FemaleRadioButton.TabIndex = 1;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.MaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRadioButton.Location = new System.Drawing.Point(104, 219);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(52, 17);
            this.MaleRadioButton.TabIndex = 2;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(10, 253);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(10, 280);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(29, 13);
            this.AgeLabel.TabIndex = 5;
            this.AgeLabel.Text = "Age";
            // 
            // CultureLabel
            // 
            this.CultureLabel.AutoSize = true;
            this.CultureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CultureLabel.Location = new System.Drawing.Point(10, 308);
            this.CultureLabel.Name = "CultureLabel";
            this.CultureLabel.Size = new System.Drawing.Size(47, 13);
            this.CultureLabel.TabIndex = 6;
            this.CultureLabel.Text = "Culture";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(10, 353);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 13);
            this.AddressLabel.TabIndex = 8;
            this.AddressLabel.Text = "Address";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Font = new System.Drawing.Font("Arial", 9F);
            this.NameTextBox.Location = new System.Drawing.Point(104, 253);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(226, 21);
            this.NameTextBox.TabIndex = 9;
            // 
            // CultureTextBox
            // 
            this.CultureTextBox.BackColor = System.Drawing.Color.White;
            this.CultureTextBox.Font = new System.Drawing.Font("Arial", 9F);
            this.CultureTextBox.Location = new System.Drawing.Point(104, 308);
            this.CultureTextBox.Name = "CultureTextBox";
            this.CultureTextBox.Size = new System.Drawing.Size(226, 21);
            this.CultureTextBox.TabIndex = 10;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.BackColor = System.Drawing.Color.White;
            this.AgeTextBox.Font = new System.Drawing.Font("Arial", 9F);
            this.AgeTextBox.Location = new System.Drawing.Point(104, 280);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(69, 21);
            this.AgeTextBox.TabIndex = 11;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.Color.White;
            this.AddressTextBox.Font = new System.Drawing.Font("Arial", 9F);
            this.AddressTextBox.Location = new System.Drawing.Point(104, 349);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(226, 69);
            this.AddressTextBox.TabIndex = 13;
            this.AddressTextBox.Text = "";
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // SaleItemsListView
            // 
            this.SaleItemsListView.BackColor = System.Drawing.Color.White;
            this.SaleItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemNameHeader,
            this.CostHeader});
            this.SaleItemsListView.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleItemsListView.Location = new System.Drawing.Point(365, 239);
            this.SaleItemsListView.Name = "SaleItemsListView";
            this.SaleItemsListView.Size = new System.Drawing.Size(266, 179);
            this.SaleItemsListView.TabIndex = 16;
            this.SaleItemsListView.UseCompatibleStateImageBehavior = false;
            this.SaleItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // ItemNameHeader
            // 
            this.ItemNameHeader.Text = "Item Name";
            this.ItemNameHeader.Width = 180;
            // 
            // CostHeader
            // 
            this.CostHeader.Text = "Cost";
            this.CostHeader.Width = 82;
            // 
            // StallOwnerLabel
            // 
            this.StallOwnerLabel.AutoSize = true;
            this.StallOwnerLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StallOwnerLabel.Location = new System.Drawing.Point(13, 8);
            this.StallOwnerLabel.Name = "StallOwnerLabel";
            this.StallOwnerLabel.Size = new System.Drawing.Size(80, 15);
            this.StallOwnerLabel.TabIndex = 17;
            this.StallOwnerLabel.Text = "Stall Owners";
            // 
            // SaleItemLabel
            // 
            this.SaleItemLabel.AutoSize = true;
            this.SaleItemLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleItemLabel.Location = new System.Drawing.Point(362, 221);
            this.SaleItemLabel.Name = "SaleItemLabel";
            this.SaleItemLabel.Size = new System.Drawing.Size(67, 15);
            this.SaleItemLabel.TabIndex = 18;
            this.SaleItemLabel.Text = "Sale Items";
            // 
            // StallOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.SaleItemLabel);
            this.Controls.Add(this.StallOwnerLabel);
            this.Controls.Add(this.SaleItemsListView);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.CultureTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CultureLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.StallOwnerListView);
            this.Name = "StallOwnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stall Owners";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StallOwnerForm_FormClosed);
            this.Load += new System.EventHandler(this.StallOwnerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView StallOwnerListView;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label CultureLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CultureTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.RichTextBox AddressTextBox;
        private System.Windows.Forms.ListView SaleItemsListView;
        private System.Windows.Forms.Label StallOwnerLabel;
        private System.Windows.Forms.Label SaleItemLabel;
        private System.Windows.Forms.ColumnHeader ItemNameHeader;
        private System.Windows.Forms.ColumnHeader CostHeader;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader AgeHeader;
        private System.Windows.Forms.ColumnHeader GenderHeader;
        private System.Windows.Forms.ColumnHeader CultureHeader;
        private System.Windows.Forms.ColumnHeader AddressHeader;
    }
}