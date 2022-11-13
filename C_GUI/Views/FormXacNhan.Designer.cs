namespace C_GUI.Views
{
    partial class FormXacNhan
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
            this.label1 = new System.Windows.Forms.Label();
            this._rjbtnXacNhan = new C_GUI.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn Có Muốn Xác Nhận Dùng Phần Mềm ?";
            // 
            // _rjbtnXacNhan
            // 
            this._rjbtnXacNhan.BackColor = System.Drawing.Color.Turquoise;
            this._rjbtnXacNhan.BackgroundColor = System.Drawing.Color.Turquoise;
            this._rjbtnXacNhan.BorderColor = System.Drawing.Color.Black;
            this._rjbtnXacNhan.BorderRadius = 15;
            this._rjbtnXacNhan.BorderSize = 2;
            this._rjbtnXacNhan.FlatAppearance.BorderSize = 0;
            this._rjbtnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._rjbtnXacNhan.ForeColor = System.Drawing.Color.Black;
            this._rjbtnXacNhan.Location = new System.Drawing.Point(280, 196);
            this._rjbtnXacNhan.Name = "_rjbtnXacNhan";
            this._rjbtnXacNhan.Size = new System.Drawing.Size(188, 39);
            this._rjbtnXacNhan.SizeImage = new System.Drawing.Size(20, 20);
            this._rjbtnXacNhan.TabIndex = 1;
            this._rjbtnXacNhan.Text = "Xác Nhận";
            this._rjbtnXacNhan.TextColor = System.Drawing.Color.Black;
            this._rjbtnXacNhan.UseVisualStyleBackColor = false;
            // 
            // FormXacNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._rjbtnXacNhan);
            this.Controls.Add(this.label1);
            this.Name = "FormXacNhan";
            this.Text = "FormXacNhan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RJControls.RJButton _rjbtnXacNhan;
    }
}