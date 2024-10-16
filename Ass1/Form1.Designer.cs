namespace Ass1
{
    partial class Form1
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
            this.playerGrid = new System.Windows.Forms.DataGridView();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeworkDataSet = new Ass1.HomeworkDataSet();
            this.playersTableAdapter = new Ass1.HomeworkDataSetTableAdapters.PlayersTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.teamGrid = new System.Windows.Forms.DataGridView();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeworkDataSet1 = new Ass1.HomeworkDataSet1();
            this.teamsTableAdapter = new Ass1.HomeworkDataSet1TableAdapters.TeamsTableAdapter();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerGrid
            // 
            this.playerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerGrid.Location = new System.Drawing.Point(473, 60);
            this.playerGrid.Margin = new System.Windows.Forms.Padding(4);
            this.playerGrid.Name = "playerGrid";
            this.playerGrid.RowHeadersWidth = 51;
            this.playerGrid.Size = new System.Drawing.Size(371, 185);
            this.playerGrid.TabIndex = 0;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.homeworkDataSet;
            // 
            // homeworkDataSet
            // 
            this.homeworkDataSet.DataSetName = "HomeworkDataSet";
            this.homeworkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(905, 27);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // teamGrid
            // 
            this.teamGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGrid.Location = new System.Drawing.Point(53, 60);
            this.teamGrid.Name = "teamGrid";
            this.teamGrid.RowHeadersWidth = 51;
            this.teamGrid.RowTemplate.Height = 24;
            this.teamGrid.Size = new System.Drawing.Size(371, 185);
            this.teamGrid.TabIndex = 2;
            this.teamGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamGrid_CellContentClick);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.homeworkDataSet1;
            // 
            // homeworkDataSet1
            // 
            this.homeworkDataSet1.DataSetName = "HomeworkDataSet1";
            this.homeworkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(413, 289);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 554);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.teamGrid);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.playerGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "w";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView playerGrid;
        private HomeworkDataSet homeworkDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private HomeworkDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView teamGrid;
        private HomeworkDataSet1 homeworkDataSet1;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private HomeworkDataSet1TableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.Button editButton;
    }
}

