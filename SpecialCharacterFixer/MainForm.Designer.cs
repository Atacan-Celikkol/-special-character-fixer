namespace SpecialCharacterFixer
{
    partial class MainForm
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
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.FileNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dropList = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();


            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            //this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 421);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(370, 23);
            this.progressBar.Style = this.Style;
            this.progressBar.TabIndex = 1;
            this.progressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressBar.Theme = this.Theme;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.Text = "File Name";
            this.FileNameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FileNameColumn.Width = 370;
            // 
            // dropList
            // 
            this.dropList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.dropList.AllowDrop = true;
            this.dropList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.dropList.CheckBoxes = true;
            this.dropList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameColumn});
            this.dropList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dropList.ForeColor = System.Drawing.SystemColors.Window;
            this.dropList.FullRowSelect = true;
            this.dropList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dropList.Location = new System.Drawing.Point(15, 65);
            this.dropList.Name = "dropList";
            this.dropList.OwnerDraw = true;
            this.dropList.Scrollable = false;
            this.dropList.Size = new System.Drawing.Size(370, 350);
            this.dropList.Style = this.Style;
            this.dropList.TabIndex = 0;
            this.dropList.Theme = this.Theme;
            this.dropList.UseCompatibleStateImageBehavior = false;
            this.dropList.UseCustomBackColor = true;
            this.dropList.UseCustomForeColor = true;
            this.dropList.UseSelectable = true;
            this.dropList.UseStyleColors = true;
            this.dropList.View = System.Windows.Forms.View.Details;
            this.dropList.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropList_DragDrop);
            this.dropList.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropList_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 459);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dropList);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 83, 27, 28);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Special Character Fixer";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private System.Windows.Forms.ColumnHeader FileNameColumn;
        private MetroFramework.Controls.MetroListView dropList;
    }
}

