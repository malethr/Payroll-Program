namespace ThomasM_PayrollProgram
{
    partial class FormMenu
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
            this.lbl_menu = new System.Windows.Forms.Label();
            this.grpBx_menu = new System.Windows.Forms.GroupBox();
            this.rdo_regular = new System.Windows.Forms.RadioButton();
            this.rdo_contract = new System.Windows.Forms.RadioButton();
            this.btn_entermenu = new System.Windows.Forms.Button();
            this.grpBx_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.Color.Silver;
            this.lbl_menu.Location = new System.Drawing.Point(168, 43);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(272, 25);
            this.lbl_menu.TabIndex = 0;
            this.lbl_menu.Text = "PAYROLL PROGRAM MENU";
            // 
            // grpBx_menu
            // 
            this.grpBx_menu.BackColor = System.Drawing.Color.SlateGray;
            this.grpBx_menu.Controls.Add(this.rdo_regular);
            this.grpBx_menu.Controls.Add(this.rdo_contract);
            this.grpBx_menu.Location = new System.Drawing.Point(159, 101);
            this.grpBx_menu.Name = "grpBx_menu";
            this.grpBx_menu.Size = new System.Drawing.Size(304, 190);
            this.grpBx_menu.TabIndex = 1;
            this.grpBx_menu.TabStop = false;
            // 
            // rdo_regular
            // 
            this.rdo_regular.AutoSize = true;
            this.rdo_regular.BackColor = System.Drawing.Color.SteelBlue;
            this.rdo_regular.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_regular.ForeColor = System.Drawing.Color.White;
            this.rdo_regular.Location = new System.Drawing.Point(76, 111);
            this.rdo_regular.Name = "rdo_regular";
            this.rdo_regular.Size = new System.Drawing.Size(154, 19);
            this.rdo_regular.TabIndex = 1;
            this.rdo_regular.TabStop = true;
            this.rdo_regular.Text = "Add Regular Employee";
            this.rdo_regular.UseVisualStyleBackColor = false;
            // 
            // rdo_contract
            // 
            this.rdo_contract.AutoSize = true;
            this.rdo_contract.BackColor = System.Drawing.Color.SteelBlue;
            this.rdo_contract.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_contract.ForeColor = System.Drawing.Color.White;
            this.rdo_contract.Location = new System.Drawing.Point(76, 48);
            this.rdo_contract.Name = "rdo_contract";
            this.rdo_contract.Size = new System.Drawing.Size(161, 19);
            this.rdo_contract.TabIndex = 0;
            this.rdo_contract.TabStop = true;
            this.rdo_contract.Text = "Add Contract Employee";
            this.rdo_contract.UseVisualStyleBackColor = false;
            // 
            // btn_entermenu
            // 
            this.btn_entermenu.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_entermenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entermenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entermenu.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entermenu.ForeColor = System.Drawing.Color.White;
            this.btn_entermenu.Location = new System.Drawing.Point(252, 334);
            this.btn_entermenu.Name = "btn_entermenu";
            this.btn_entermenu.Size = new System.Drawing.Size(102, 41);
            this.btn_entermenu.TabIndex = 2;
            this.btn_entermenu.Text = "Enter";
            this.btn_entermenu.UseVisualStyleBackColor = false;
            this.btn_entermenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ThomasM_PayrollProgram.Properties.Resources._99BJx;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.btn_entermenu);
            this.Controls.Add(this.grpBx_menu);
            this.Controls.Add(this.lbl_menu);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.grpBx_menu.ResumeLayout(false);
            this.grpBx_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.GroupBox grpBx_menu;
        private System.Windows.Forms.RadioButton rdo_regular;
        private System.Windows.Forms.RadioButton rdo_contract;
        private System.Windows.Forms.Button btn_entermenu;
    }
}