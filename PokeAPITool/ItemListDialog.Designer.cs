﻿namespace PokeAPITool
{
	partial class ItemListDialog
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
			this.ItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detailButton = new System.Windows.Forms.Button();
			this.urlData = new System.Windows.Forms.Label();
			this.nameData = new System.Windows.Forms.Label();
			urlCaption = new System.Windows.Forms.Label();
			nameCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.listDataView)).BeginInit();
			this.SuspendLayout();
			// 
			// urlCaption
			// 
			urlCaption.AutoSize = true;
			urlCaption.Location = new System.Drawing.Point(158, 59);
			urlCaption.Name = "urlCaption";
			urlCaption.Size = new System.Drawing.Size(27, 12);
			urlCaption.TabIndex = 8;
			urlCaption.Text = "URL";
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(158, 12);
			nameCaption.Name = "nameCaption";
			nameCaption.Size = new System.Drawing.Size(29, 12);
			nameCaption.TabIndex = 6;
			nameCaption.Text = "名称";
			// 
			// listDataView
			// 
			this.listDataView.AllowUserToAddRows = false;
			this.listDataView.AllowUserToDeleteRows = false;
			this.listDataView.AllowUserToResizeColumns = false;
			this.listDataView.AllowUserToResizeRows = false;
			this.listDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemColumn});
			this.listDataView.Location = new System.Drawing.Point(12, 12);
			this.listDataView.MultiSelect = false;
			this.listDataView.Name = "listDataView";
			this.listDataView.ReadOnly = true;
			this.listDataView.RowHeadersVisible = false;
			this.listDataView.RowTemplate.Height = 21;
			this.listDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listDataView.Size = new System.Drawing.Size(140, 705);
			this.listDataView.TabIndex = 1;
			this.listDataView.SelectionChanged += new System.EventHandler(this.listDataView_SelectionChanged);
			// 
			// ItemColumn
			// 
			this.ItemColumn.HeaderText = "アイテム";
			this.ItemColumn.Name = "ItemColumn";
			this.ItemColumn.ReadOnly = true;
			this.ItemColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ItemColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ItemColumn.Width = 120;
			// 
			// detailButton
			// 
			this.detailButton.Location = new System.Drawing.Point(160, 102);
			this.detailButton.Name = "detailButton";
			this.detailButton.Size = new System.Drawing.Size(50, 23);
			this.detailButton.TabIndex = 10;
			this.detailButton.Text = "詳細";
			this.detailButton.UseVisualStyleBackColor = true;
			// 
			// urlData
			// 
			this.urlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.urlData.Location = new System.Drawing.Point(160, 71);
			this.urlData.Name = "urlData";
			this.urlData.Size = new System.Drawing.Size(836, 19);
			this.urlData.TabIndex = 9;
			// 
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(160, 28);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(836, 19);
			this.nameData.TabIndex = 7;
			// 
			// ItemListDialog
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
			this.Name = "ItemListDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "アイテム(Item)";
			this.Load += new System.EventHandler(this.ItemListDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.listDataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView listDataView;
		private System.Windows.Forms.Button detailButton;
		private System.Windows.Forms.Label urlData;
		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemColumn;
	}
}