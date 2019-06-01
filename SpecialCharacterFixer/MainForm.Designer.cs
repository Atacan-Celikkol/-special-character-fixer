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
            this.dropList = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // dropList
            // 
            this.dropList.AllowDrop = true;
            this.dropList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dropList.FullRowSelect = true;
            this.dropList.Location = new System.Drawing.Point(30, 86);
            this.dropList.Name = "dropList";
            this.dropList.OwnerDraw = true;
            this.dropList.Size = new System.Drawing.Size(407, 298);
            this.dropList.Style = MetroFramework.MetroColorStyle.Lime;
            this.dropList.TabIndex = 0;
            this.dropList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dropList.UseCompatibleStateImageBehavior = false;
            this.dropList.UseSelectable = true;
            this.dropList.UseStyleColors = true;
            this.dropList.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropList_DragDrop);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(467, 415);
            this.Controls.Add(this.dropList);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 83, 27, 28);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Special Character Fixer";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView dropList;
    }
}

