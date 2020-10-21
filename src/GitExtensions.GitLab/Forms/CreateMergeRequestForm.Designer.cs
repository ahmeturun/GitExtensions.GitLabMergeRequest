﻿namespace GitExtensions.GitLab.Forms
{
	partial class CreateMergeRequestForm
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
			this.sourceBranchCB = new System.Windows.Forms.ComboBox();
			this.targetBranchCB = new System.Windows.Forms.ComboBox();
			this.sourceBranchLabel = new System.Windows.Forms.Label();
			this.targetBranchLabel = new System.Windows.Forms.Label();
			this.assigneeCB = new System.Windows.Forms.ComboBox();
			this.assigneeLabel = new System.Windows.Forms.Label();
			this.createMergeRequestBtn = new System.Windows.Forms.Button();
			this.mergeRequestDetailTB = new System.Windows.Forms.TextBox();
			this.mergeRequestDetailLabel = new System.Windows.Forms.Label();
			this.mergeRequestData = new System.Windows.Forms.GroupBox();
			this.squashCommitsChkBox = new System.Windows.Forms.CheckBox();
			this.mergeOptionsGroup = new System.Windows.Forms.Label();
			this.deleteSourceBranchChkBox = new System.Windows.Forms.CheckBox();
			this.mergeRequestTitleTB = new System.Windows.Forms.TextBox();
			this.mergeRequestTitleLbl = new System.Windows.Forms.Label();
			this.sourceBranchGroup = new System.Windows.Forms.GroupBox();
			this.sourceProjectCB = new System.Windows.Forms.ComboBox();
			this.sourceProjectLbl = new System.Windows.Forms.Label();
			this.targetBranchGroup = new System.Windows.Forms.GroupBox();
			this.targetProjectCB = new System.Windows.Forms.ComboBox();
			this.targetProjectLbl = new System.Windows.Forms.Label();
			this.mergeRequestCreateLoading = new GitUI.UserControls.RevisionGrid.LoadingControl();
			this.mergeRequestData.SuspendLayout();
			this.sourceBranchGroup.SuspendLayout();
			this.targetBranchGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// sourceBranchCB
			// 
			this.sourceBranchCB.BackColor = System.Drawing.SystemColors.Window;
			this.sourceBranchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sourceBranchCB.FormattingEnabled = true;
			this.sourceBranchCB.Location = new System.Drawing.Point(99, 46);
			this.sourceBranchCB.Name = "sourceBranchCB";
			this.sourceBranchCB.Size = new System.Drawing.Size(229, 21);
			this.sourceBranchCB.TabIndex = 0;
			// 
			// targetBranchCB
			// 
			this.targetBranchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.targetBranchCB.FormattingEnabled = true;
			this.targetBranchCB.Location = new System.Drawing.Point(99, 46);
			this.targetBranchCB.Name = "targetBranchCB";
			this.targetBranchCB.Size = new System.Drawing.Size(229, 21);
			this.targetBranchCB.TabIndex = 1;
			// 
			// sourceBranchLabel
			// 
			this.sourceBranchLabel.AutoSize = true;
			this.sourceBranchLabel.Location = new System.Drawing.Point(7, 49);
			this.sourceBranchLabel.Name = "sourceBranchLabel";
			this.sourceBranchLabel.Size = new System.Drawing.Size(78, 13);
			this.sourceBranchLabel.TabIndex = 2;
			this.sourceBranchLabel.Text = "Source Branch";
			// 
			// targetBranchLabel
			// 
			this.targetBranchLabel.AutoSize = true;
			this.targetBranchLabel.Location = new System.Drawing.Point(7, 49);
			this.targetBranchLabel.Name = "targetBranchLabel";
			this.targetBranchLabel.Size = new System.Drawing.Size(75, 13);
			this.targetBranchLabel.TabIndex = 3;
			this.targetBranchLabel.Text = "Target Branch";
			// 
			// assigneeCB
			// 
			this.assigneeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.assigneeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.assigneeCB.FormattingEnabled = true;
			this.assigneeCB.Location = new System.Drawing.Point(99, 153);
			this.assigneeCB.Name = "assigneeCB";
			this.assigneeCB.Size = new System.Drawing.Size(229, 21);
			this.assigneeCB.TabIndex = 4;
			this.assigneeCB.Enter += new System.EventHandler(this.assigneeCB_Enter);
			this.assigneeCB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.assigneeCB_KeyUp);
			this.assigneeCB.Leave += new System.EventHandler(this.assigneeCB_Leave);
			this.assigneeCB.Click += AssigneeCB_Click;
			this.assigneeCB.SelectedValueChanged += AssigneeCB_SelectedValueChanged;
			this.assigneeCB.TextChanged += AssigneeCB_TextChanged;
			// 
			// assigneeLabel
			// 
			this.assigneeLabel.AutoSize = true;
			this.assigneeLabel.Location = new System.Drawing.Point(7, 156);
			this.assigneeLabel.Name = "assigneeLabel";
			this.assigneeLabel.Size = new System.Drawing.Size(50, 13);
			this.assigneeLabel.TabIndex = 5;
			this.assigneeLabel.Text = "Assignee";
			// 
			// createMergeRequestBtn
			// 
			this.createMergeRequestBtn.Location = new System.Drawing.Point(606, 386);
			this.createMergeRequestBtn.Name = "createMergeRequestBtn";
			this.createMergeRequestBtn.Size = new System.Drawing.Size(140, 23);
			this.createMergeRequestBtn.TabIndex = 6;
			this.createMergeRequestBtn.Text = "Create Merge Request";
			this.createMergeRequestBtn.UseVisualStyleBackColor = true;
			this.createMergeRequestBtn.Click += new System.EventHandler(this.createMergeRequestBtn_Click);
			// 
			// mergeRequestDetailTB
			// 
			this.mergeRequestDetailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mergeRequestDetailTB.Location = new System.Drawing.Point(99, 51);
			this.mergeRequestDetailTB.Multiline = true;
			this.mergeRequestDetailTB.Name = "mergeRequestDetailTB";
			this.mergeRequestDetailTB.Size = new System.Drawing.Size(600, 96);
			this.mergeRequestDetailTB.TabIndex = 7;
			// 
			// mergeRequestDetailLabel
			// 
			this.mergeRequestDetailLabel.AutoSize = true;
			this.mergeRequestDetailLabel.Location = new System.Drawing.Point(7, 54);
			this.mergeRequestDetailLabel.Name = "mergeRequestDetailLabel";
			this.mergeRequestDetailLabel.Size = new System.Drawing.Size(39, 13);
			this.mergeRequestDetailLabel.TabIndex = 8;
			this.mergeRequestDetailLabel.Text = "Details";
			// 
			// mergeRequestData
			// 
			this.mergeRequestData.BackColor = System.Drawing.SystemColors.Control;
			this.mergeRequestData.Controls.Add(this.squashCommitsChkBox);
			this.mergeRequestData.Controls.Add(this.mergeOptionsGroup);
			this.mergeRequestData.Controls.Add(this.deleteSourceBranchChkBox);
			this.mergeRequestData.Controls.Add(this.mergeRequestTitleTB);
			this.mergeRequestData.Controls.Add(this.mergeRequestTitleLbl);
			this.mergeRequestData.Controls.Add(this.mergeRequestDetailTB);
			this.mergeRequestData.Controls.Add(this.mergeRequestDetailLabel);
			this.mergeRequestData.Controls.Add(this.assigneeLabel);
			this.mergeRequestData.Controls.Add(this.assigneeCB);
			this.mergeRequestData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.mergeRequestData.Location = new System.Drawing.Point(32, 144);
			this.mergeRequestData.Name = "mergeRequestData";
			this.mergeRequestData.Size = new System.Drawing.Size(714, 236);
			this.mergeRequestData.TabIndex = 9;
			this.mergeRequestData.TabStop = false;
			this.mergeRequestData.Text = "Merge Request Data";
			// 
			// squashCommitsChkBox
			// 
			this.squashCommitsChkBox.AutoSize = true;
			this.squashCommitsChkBox.Location = new System.Drawing.Point(99, 205);
			this.squashCommitsChkBox.Name = "squashCommitsChkBox";
			this.squashCommitsChkBox.Size = new System.Drawing.Size(263, 17);
			this.squashCommitsChkBox.TabIndex = 13;
			this.squashCommitsChkBox.Text = "Squash commits when merge request is accepted.";
			this.squashCommitsChkBox.UseVisualStyleBackColor = true;
			// 
			// mergeOptionsGroup
			// 
			this.mergeOptionsGroup.AutoSize = true;
			this.mergeOptionsGroup.Location = new System.Drawing.Point(7, 181);
			this.mergeOptionsGroup.Name = "mergeOptionsGroup";
			this.mergeOptionsGroup.Size = new System.Drawing.Size(74, 13);
			this.mergeOptionsGroup.TabIndex = 12;
			this.mergeOptionsGroup.Text = "Merge options";
			// 
			// deleteSourceBranchChkBox
			// 
			this.deleteSourceBranchChkBox.AutoSize = true;
			this.deleteSourceBranchChkBox.Location = new System.Drawing.Point(99, 181);
			this.deleteSourceBranchChkBox.Name = "deleteSourceBranchChkBox";
			this.deleteSourceBranchChkBox.Size = new System.Drawing.Size(288, 17);
			this.deleteSourceBranchChkBox.TabIndex = 11;
			this.deleteSourceBranchChkBox.Text = "Delete source branch when merge request is accepted.";
			this.deleteSourceBranchChkBox.UseVisualStyleBackColor = true;
			// 
			// mergeRequestTitleTB
			// 
			this.mergeRequestTitleTB.Location = new System.Drawing.Point(99, 25);
			this.mergeRequestTitleTB.Name = "mergeRequestTitleTB";
			this.mergeRequestTitleTB.Size = new System.Drawing.Size(600, 20);
			this.mergeRequestTitleTB.TabIndex = 10;
			this.mergeRequestTitleTB.TextChanged += MergeRequestTitleTB_TextChanged;
			// 
			// mergeRequestTitleLbl
			// 
			this.mergeRequestTitleLbl.AutoSize = true;
			this.mergeRequestTitleLbl.Location = new System.Drawing.Point(7, 28);
			this.mergeRequestTitleLbl.Name = "mergeRequestTitleLbl";
			this.mergeRequestTitleLbl.Size = new System.Drawing.Size(27, 13);
			this.mergeRequestTitleLbl.TabIndex = 9;
			this.mergeRequestTitleLbl.Text = "Title";
			// 
			// sourceBranchGroup
			// 
			this.sourceBranchGroup.BackColor = System.Drawing.SystemColors.Control;
			this.sourceBranchGroup.Controls.Add(this.sourceBranchCB);
			this.sourceBranchGroup.Controls.Add(this.sourceProjectCB);
			this.sourceBranchGroup.Controls.Add(this.sourceProjectLbl);
			this.sourceBranchGroup.Controls.Add(this.sourceBranchLabel);
			this.sourceBranchGroup.Location = new System.Drawing.Point(32, 35);
			this.sourceBranchGroup.Name = "sourceBranchGroup";
			this.sourceBranchGroup.Size = new System.Drawing.Size(343, 79);
			this.sourceBranchGroup.TabIndex = 10;
			this.sourceBranchGroup.TabStop = false;
			this.sourceBranchGroup.Text = "Source";
			// 
			// sourceProjectCB
			// 
			this.sourceProjectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sourceProjectCB.FormattingEnabled = true;
			this.sourceProjectCB.Location = new System.Drawing.Point(99, 19);
			this.sourceProjectCB.Name = "sourceProjectCB";
			this.sourceProjectCB.Size = new System.Drawing.Size(229, 21);
			this.sourceProjectCB.TabIndex = 1;
			this.sourceProjectCB.SelectedIndexChanged += new System.EventHandler(this.sourceProjectCB_SelectedIndexChanged);
			// 
			// sourceProjectLbl
			// 
			this.sourceProjectLbl.AutoSize = true;
			this.sourceProjectLbl.Location = new System.Drawing.Point(7, 22);
			this.sourceProjectLbl.Name = "sourceProjectLbl";
			this.sourceProjectLbl.Size = new System.Drawing.Size(77, 13);
			this.sourceProjectLbl.TabIndex = 3;
			this.sourceProjectLbl.Text = "Source Project";
			// 
			// targetBranchGroup
			// 
			this.targetBranchGroup.BackColor = System.Drawing.SystemColors.Control;
			this.targetBranchGroup.Controls.Add(this.targetBranchCB);
			this.targetBranchGroup.Controls.Add(this.targetBranchLabel);
			this.targetBranchGroup.Controls.Add(this.targetProjectCB);
			this.targetBranchGroup.Controls.Add(this.targetProjectLbl);
			this.targetBranchGroup.Location = new System.Drawing.Point(403, 35);
			this.targetBranchGroup.Name = "targetBranchGroup";
			this.targetBranchGroup.Size = new System.Drawing.Size(343, 79);
			this.targetBranchGroup.TabIndex = 11;
			this.targetBranchGroup.TabStop = false;
			this.targetBranchGroup.Text = "Target";
			// 
			// targetProjectCB
			// 
			this.targetProjectCB.BackColor = System.Drawing.SystemColors.Window;
			this.targetProjectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.targetProjectCB.FormattingEnabled = true;
			this.targetProjectCB.Location = new System.Drawing.Point(99, 19);
			this.targetProjectCB.Name = "targetProjectCB";
			this.targetProjectCB.Size = new System.Drawing.Size(229, 21);
			this.targetProjectCB.TabIndex = 0;
			this.targetProjectCB.SelectedIndexChanged += new System.EventHandler(this.targetProjectCB_SelectedIndexChanged);
			// 
			// targetProjectLbl
			// 
			this.targetProjectLbl.AutoSize = true;
			this.targetProjectLbl.Location = new System.Drawing.Point(7, 22);
			this.targetProjectLbl.Name = "targetProjectLbl";
			this.targetProjectLbl.Size = new System.Drawing.Size(74, 13);
			this.targetProjectLbl.TabIndex = 2;
			this.targetProjectLbl.Text = "Target Project";
			// 
			// mergeRequestCreateLoading
			// 
			this.mergeRequestCreateLoading.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mergeRequestCreateLoading.IsAnimating = true;
			this.mergeRequestCreateLoading.Location = new System.Drawing.Point(0, 0);
			this.mergeRequestCreateLoading.Name = "mergeRequestCreateLoading";
			this.mergeRequestCreateLoading.Size = new System.Drawing.Size(784, 421);
			this.mergeRequestCreateLoading.TabIndex = 12;
			// 
			// CreateMergeRequestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(784, 421);
			this.Controls.Add(this.mergeRequestCreateLoading);
			this.Controls.Add(this.targetBranchGroup);
			this.Controls.Add(this.sourceBranchGroup);
			this.Controls.Add(this.mergeRequestData);
			this.Controls.Add(this.createMergeRequestBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateMergeRequestForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CreateMergeRequestForm";
			this.Load += new System.EventHandler(this.CreateMergeRequestForm_Load);
			this.mergeRequestData.ResumeLayout(false);
			this.mergeRequestData.PerformLayout();
			this.sourceBranchGroup.ResumeLayout(false);
			this.sourceBranchGroup.PerformLayout();
			this.targetBranchGroup.ResumeLayout(false);
			this.targetBranchGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox sourceBranchCB;
		private System.Windows.Forms.ComboBox targetBranchCB;
		private System.Windows.Forms.Label sourceBranchLabel;
		private System.Windows.Forms.Label targetBranchLabel;
		private System.Windows.Forms.ComboBox assigneeCB;
		private System.Windows.Forms.Label assigneeLabel;
		private System.Windows.Forms.Button createMergeRequestBtn;
		private System.Windows.Forms.TextBox mergeRequestDetailTB;
		private System.Windows.Forms.Label mergeRequestDetailLabel;
		private System.Windows.Forms.GroupBox mergeRequestData;
		private System.Windows.Forms.TextBox mergeRequestTitleTB;
		private System.Windows.Forms.Label mergeRequestTitleLbl;
		private System.Windows.Forms.GroupBox sourceBranchGroup;
		private System.Windows.Forms.GroupBox targetBranchGroup;
		private System.Windows.Forms.ComboBox sourceProjectCB;
		private System.Windows.Forms.ComboBox targetProjectCB;
		private System.Windows.Forms.Label targetProjectLbl;
		private System.Windows.Forms.Label sourceProjectLbl;
		private System.Windows.Forms.CheckBox squashCommitsChkBox;
		private System.Windows.Forms.Label mergeOptionsGroup;
		private System.Windows.Forms.CheckBox deleteSourceBranchChkBox;
		private GitUI.UserControls.RevisionGrid.LoadingControl mergeRequestCreateLoading;
	}
}