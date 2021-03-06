﻿namespace PokeAPITool
{
	partial class NamedAPIResourceListForm
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
			if(disposing && (components != null)) {
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
			System.Windows.Forms.Label urlCaption;
			System.Windows.Forms.Label nameCaption;
			this.listDataView = new System.Windows.Forms.DataGridView();
			this.detailButton = new System.Windows.Forms.Button();
			this.urlData = new System.Windows.Forms.Label();
			this.nameData = new System.Windows.Forms.Label();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			urlCaption = new System.Windows.Forms.Label();
			nameCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.listDataView)).BeginInit();
			this.SuspendLayout();
			// 
			// urlCaption
			// 
			urlCaption.AutoSize = true;
			urlCaption.Location = new System.Drawing.Point(363, 59);
			urlCaption.Name = "urlCaption";
			urlCaption.Size = new System.Drawing.Size(57, 12);
			urlCaption.TabIndex = 3;
			urlCaption.Text = "URL(URL)";
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(363, 12);
			nameCaption.Name = "nameCaption";
			nameCaption.Size = new System.Drawing.Size(66, 12);
			nameCaption.TabIndex = 1;
			nameCaption.Text = "名称(Name)";
			// 
			// listDataView
			// 
			this.listDataView.AllowUserToAddRows = false;
			this.listDataView.AllowUserToDeleteRows = false;
			this.listDataView.AllowUserToResizeColumns = false;
			this.listDataView.AllowUserToResizeRows = false;
			this.listDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn});
			this.listDataView.Location = new System.Drawing.Point(12, 12);
			this.listDataView.MultiSelect = false;
			this.listDataView.Name = "listDataView";
			this.listDataView.ReadOnly = true;
			this.listDataView.RowHeadersVisible = false;
			this.listDataView.RowTemplate.Height = 21;
			this.listDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listDataView.Size = new System.Drawing.Size(345, 705);
			this.listDataView.TabIndex = 0;
			this.listDataView.SelectionChanged += new System.EventHandler(this.listDataView_SelectionChanged);
			// 
			// detailButton
			// 
			this.detailButton.Location = new System.Drawing.Point(365, 102);
			this.detailButton.Name = "detailButton";
			this.detailButton.Size = new System.Drawing.Size(50, 23);
			this.detailButton.TabIndex = 5;
			this.detailButton.Text = "詳細";
			this.detailButton.UseVisualStyleBackColor = true;
			this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
			// 
			// urlData
			// 
			this.urlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.urlData.Location = new System.Drawing.Point(365, 71);
			this.urlData.Name = "urlData";
			this.urlData.Size = new System.Drawing.Size(631, 19);
			this.urlData.TabIndex = 4;
			// 
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(365, 28);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(631, 19);
			this.nameData.TabIndex = 2;
			// 
			// NameColumn
			// 
			this.NameColumn.HeaderText = "XXXXX";
			this.NameColumn.Name = "NameColumn";
			this.NameColumn.ReadOnly = true;
			this.NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.NameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.NameColumn.Width = 300;
			// 
			// NamedAPIResourceListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.detailButton);
			this.Controls.Add(this.urlData);
			this.Controls.Add(urlCaption);
			this.Controls.Add(this.nameData);
			this.Controls.Add(nameCaption);
			this.Controls.Add(this.listDataView);
			this.Name = "NamedAPIResourceListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NamedAPIResourceListDialog";
			this.Load += new System.EventHandler(this.NamedAPIResourceListDialog_Load);
			this.Shown += new System.EventHandler(this.NamedAPIResourceListForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.listDataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView listDataView;
		private System.Windows.Forms.Button detailButton;
		private System.Windows.Forms.Label urlData;
		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
	}
}