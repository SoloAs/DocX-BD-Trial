namespace DocXTask
{
    partial class MyForm
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
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.OpenTemplateDialog = new System.Windows.Forms.OpenFileDialog();
            this.ChooseTemplateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(12, 12);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.Size = new System.Drawing.Size(760, 309);
            this.CustomersGrid.TabIndex = 0;
            this.CustomersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGrid_CellClick);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenFileBtn.AutoSize = true;
            this.OpenFileBtn.Location = new System.Drawing.Point(124, 327);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(108, 23);
            this.OpenFileBtn.TabIndex = 1;
            this.OpenFileBtn.Text = "Open file";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // OpenTemplateDialog
            // 
            this.OpenTemplateDialog.FileName = "OpenTemplate";
            // 
            // ChooseTemplateBtn
            // 
            this.ChooseTemplateBtn.Location = new System.Drawing.Point(12, 327);
            this.ChooseTemplateBtn.Name = "ChooseTemplateBtn";
            this.ChooseTemplateBtn.Size = new System.Drawing.Size(106, 23);
            this.ChooseTemplateBtn.TabIndex = 2;
            this.ChooseTemplateBtn.Text = "Choose template";
            this.ChooseTemplateBtn.UseVisualStyleBackColor = true;
            this.ChooseTemplateBtn.Click += new System.EventHandler(this.ChooseTemplateBtn_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.ChooseTemplateBtn);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.CustomersGrid);
            this.Name = "MyForm";
            this.Text = "MyPr";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.OpenFileDialog OpenTemplateDialog;
        private System.Windows.Forms.Button ChooseTemplateBtn;
    }
}

