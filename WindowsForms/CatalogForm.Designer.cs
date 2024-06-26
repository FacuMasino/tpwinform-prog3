﻿namespace WindowsForms
{
    partial class CatalogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roundPanel3 = new WindowsForms.RoundPanel();
            this.nextImgButton = new System.Windows.Forms.Button();
            this.prevImgButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.roundPanel2 = new WindowsForms.RoundPanel();
            this.chkDeleteUnused = new System.Windows.Forms.CheckBox();
            this.chkShowInvalids = new System.Windows.Forms.CheckBox();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.roundPanel1 = new WindowsForms.RoundPanel();
            this.articlesDataGridView = new System.Windows.Forms.DataGridView();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.roundPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.roundPanel2.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel3
            // 
            this.roundPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel3.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.roundPanel3.BorderWidth = 3F;
            this.roundPanel3.Controls.Add(this.nextImgButton);
            this.roundPanel3.Controls.Add(this.prevImgButton);
            this.roundPanel3.Controls.Add(this.idLabel);
            this.roundPanel3.Controls.Add(this.pictureBox);
            this.roundPanel3.Controls.Add(this.priceLabel);
            this.roundPanel3.Controls.Add(this.nameLabel);
            this.roundPanel3.Controls.Add(this.categoryLabel);
            this.roundPanel3.Controls.Add(this.descriptionLabel);
            this.roundPanel3.Controls.Add(this.brandLabel);
            this.roundPanel3.Location = new System.Drawing.Point(18, 15);
            this.roundPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Radius = 10;
            this.roundPanel3.Size = new System.Drawing.Size(627, 309);
            this.roundPanel3.TabIndex = 11;
            // 
            // nextImgButton
            // 
            this.nextImgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.nextImgButton.FlatAppearance.BorderSize = 2;
            this.nextImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextImgButton.ForeColor = System.Drawing.Color.White;
            this.nextImgButton.Image = global::WindowsForms.Properties.Resources.fi_chevron_right_white;
            this.nextImgButton.Location = new System.Drawing.Point(226, 243);
            this.nextImgButton.Name = "nextImgButton";
            this.nextImgButton.Size = new System.Drawing.Size(52, 54);
            this.nextImgButton.TabIndex = 18;
            this.nextImgButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nextImgButton.UseVisualStyleBackColor = false;
            this.nextImgButton.Click += new System.EventHandler(this.nextImgButton_Click);
            // 
            // prevImgButton
            // 
            this.prevImgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.prevImgButton.FlatAppearance.BorderSize = 2;
            this.prevImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevImgButton.ForeColor = System.Drawing.Color.White;
            this.prevImgButton.Image = global::WindowsForms.Properties.Resources.fi_chevron_left_white;
            this.prevImgButton.Location = new System.Drawing.Point(28, 243);
            this.prevImgButton.Name = "prevImgButton";
            this.prevImgButton.Size = new System.Drawing.Size(52, 54);
            this.prevImgButton.TabIndex = 17;
            this.prevImgButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prevImgButton.UseVisualStyleBackColor = false;
            this.prevImgButton.Click += new System.EventHandler(this.prevImgButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.idLabel.Location = new System.Drawing.Point(306, 28);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(36, 29);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(28, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 209);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.priceLabel.Location = new System.Drawing.Point(306, 248);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(83, 29);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Precio";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.nameLabel.Location = new System.Drawing.Point(306, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(101, 29);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Nombre";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.categoryLabel.Location = new System.Drawing.Point(306, 205);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(118, 29);
            this.categoryLabel.TabIndex = 14;
            this.categoryLabel.Text = "Categoría";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoEllipsis = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.descriptionLabel.Location = new System.Drawing.Point(306, 115);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(296, 29);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Descripción";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.brandLabel.Location = new System.Drawing.Point(306, 160);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(79, 29);
            this.brandLabel.TabIndex = 13;
            this.brandLabel.Text = "Marca";
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel2.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.roundPanel2.BorderWidth = 3F;
            this.roundPanel2.Controls.Add(this.chkDeleteUnused);
            this.roundPanel2.Controls.Add(this.chkShowInvalids);
            this.roundPanel2.Controls.Add(this.newButton);
            this.roundPanel2.Controls.Add(this.editButton);
            this.roundPanel2.Controls.Add(this.deleteButton);
            this.roundPanel2.Controls.Add(this.clearButton);
            this.roundPanel2.Controls.Add(this.filterTextBox);
            this.roundPanel2.Controls.Add(this.filterLabel);
            this.roundPanel2.Location = new System.Drawing.Point(654, 15);
            this.roundPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Radius = 10;
            this.roundPanel2.Size = new System.Drawing.Size(522, 309);
            this.roundPanel2.TabIndex = 10;
            // 
            // chkDeleteUnused
            // 
            this.chkDeleteUnused.AutoSize = true;
            this.chkDeleteUnused.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDeleteUnused.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteUnused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkDeleteUnused.Location = new System.Drawing.Point(34, 248);
            this.chkDeleteUnused.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDeleteUnused.Name = "chkDeleteUnused";
            this.chkDeleteUnused.Size = new System.Drawing.Size(377, 29);
            this.chkDeleteUnused.TabIndex = 16;
            this.chkDeleteUnused.Text = "Eliminar marcas y categorías en desuso";
            this.ttpInfo.SetToolTip(this.chkDeleteUnused, "Si selecciona esta opción, luego de eliminar un Artículo\r\nse verificará si la Mar" +
        "ca y Categoría está siendo utilizada por \r\notro Artículo y de no ser así se elim" +
        "inará de la base de datos.");
            this.chkDeleteUnused.UseVisualStyleBackColor = true;
            // 
            // chkShowInvalids
            // 
            this.chkShowInvalids.AutoSize = true;
            this.chkShowInvalids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShowInvalids.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowInvalids.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkShowInvalids.Location = new System.Drawing.Point(34, 206);
            this.chkShowInvalids.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkShowInvalids.Name = "chkShowInvalids";
            this.chkShowInvalids.Size = new System.Drawing.Size(257, 29);
            this.chkShowInvalids.TabIndex = 15;
            this.chkShowInvalids.Text = "Mostrar artículos inválidos";
            this.ttpInfo.SetToolTip(this.chkShowInvalids, "Seleccione esta opción para ver los Artículos con\r\ninformación incompleta y corre" +
        "girlos.");
            this.chkShowInvalids.UseVisualStyleBackColor = true;
            this.chkShowInvalids.CheckedChanged += new System.EventHandler(this.chkShowInvalids_CheckedChanged);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.newButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Image = global::WindowsForms.Properties.Resources.fi_plus;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(34, 28);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(144, 65);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "Nuevo";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.editButton.FlatAppearance.BorderSize = 2;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.editButton.Image = global::WindowsForms.Properties.Resources.fi_edit_3_primary;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(189, 28);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(144, 65);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Editar";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = global::WindowsForms.Properties.Resources.fi_x;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(344, 28);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(144, 65);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.clearButton.Image = global::WindowsForms.Properties.Resources.fluent__broom_20_regular;
            this.clearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearButton.Location = new System.Drawing.Point(344, 137);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 65);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Limpiar";
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.filterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.Location = new System.Drawing.Point(34, 157);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(275, 31);
            this.filterTextBox.TabIndex = 12;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.BackColor = System.Drawing.Color.Transparent;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.filterLabel.Location = new System.Drawing.Point(30, 120);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(173, 29);
            this.filterLabel.TabIndex = 13;
            this.filterLabel.Text = "Filtrar Artículos";
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel1.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.roundPanel1.BorderWidth = 3F;
            this.roundPanel1.Controls.Add(this.articlesDataGridView);
            this.roundPanel1.Location = new System.Drawing.Point(18, 335);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radius = 10;
            this.roundPanel1.Size = new System.Drawing.Size(1158, 532);
            this.roundPanel1.TabIndex = 9;
            // 
            // articlesDataGridView
            // 
            this.articlesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articlesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.articlesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articlesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.articlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(112)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articlesDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.articlesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.articlesDataGridView.GridColor = System.Drawing.Color.Silver;
            this.articlesDataGridView.Location = new System.Drawing.Point(32, 22);
            this.articlesDataGridView.MultiSelect = false;
            this.articlesDataGridView.Name = "articlesDataGridView";
            this.articlesDataGridView.RowHeadersWidth = 51;
            this.articlesDataGridView.RowTemplate.Height = 24;
            this.articlesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articlesDataGridView.Size = new System.Drawing.Size(1096, 488);
            this.articlesDataGridView.TabIndex = 6;
            this.articlesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.articlesDataGridView_DataBindingComplete);
            this.articlesDataGridView.SelectionChanged += new System.EventHandler(this.articlesDataGridView_SelectionChanged);
            // 
            // ttpInfo
            // 
            this.ttpInfo.AutoPopDelay = 5000;
            this.ttpInfo.InitialDelay = 700;
            this.ttpInfo.IsBalloon = true;
            this.ttpInfo.ReshowDelay = 200;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1196, 886);
            this.Controls.Add(this.roundPanel3);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articlesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView articlesDataGridView;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Button clearButton;
        private RoundPanel roundPanel1;
        private RoundPanel roundPanel2;
        private RoundPanel roundPanel3;
        private System.Windows.Forms.Button nextImgButton;
        private System.Windows.Forms.Button prevImgButton;
        private System.Windows.Forms.CheckBox chkShowInvalids;
        private System.Windows.Forms.CheckBox chkDeleteUnused;
        private System.Windows.Forms.ToolTip ttpInfo;
    }
}