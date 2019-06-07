namespace ThomasM_PayrollProgram
{
    partial class FormEmpInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_required = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.lbl_workhours = new System.Windows.Forms.Label();
            this.lbl_social = new System.Windows.Forms.Label();
            this.lbl_insurance = new System.Windows.Forms.Label();
            this.grpBox_paysummary = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.lblx_netpay = new System.Windows.Forms.Label();
            this.lbl_netpay = new System.Windows.Forms.Label();
            this.lblx_ttlDeductions = new System.Windows.Forms.Label();
            this.lbl_ttlDeductions = new System.Windows.Forms.Label();
            this.lblx_ins = new System.Windows.Forms.Label();
            this.lbl_ins = new System.Windows.Forms.Label();
            this.lblx_SocialSecurity = new System.Windows.Forms.Label();
            this.lbl_socialSecurity = new System.Windows.Forms.Label();
            this.lblx_fedTax = new System.Windows.Forms.Label();
            this.lbl_fedTax = new System.Windows.Forms.Label();
            this.lbl_deductions = new System.Windows.Forms.Label();
            this.lbx_totalGrossPay = new System.Windows.Forms.Label();
            this.lbl_totalGross = new System.Windows.Forms.Label();
            this.lblx_totalOvertimeEarnings = new System.Windows.Forms.Label();
            this.lbl_totalOvertimeEarnings = new System.Windows.Forms.Label();
            this.lblx_othours = new System.Windows.Forms.Label();
            this.lbl_othours = new System.Windows.Forms.Label();
            this.lblx_overtimerate = new System.Windows.Forms.Label();
            this.lbl_overtimerate = new System.Windows.Forms.Label();
            this.lbl_overtimeearnings = new System.Windows.Forms.Label();
            this.lblx_totalreg = new System.Windows.Forms.Label();
            this.lbl_totalreg = new System.Windows.Forms.Label();
            this.lblx_grp_workhours = new System.Windows.Forms.Label();
            this.lbl_grp_workhours = new System.Windows.Forms.Label();
            this.lblx_grp_rate = new System.Windows.Forms.Label();
            this.lbl_grp_rate = new System.Windows.Forms.Label();
            this.lbl_regearnings = new System.Windows.Forms.Label();
            this.lblx_ss = new System.Windows.Forms.Label();
            this.lbl_ss = new System.Windows.Forms.Label();
            this.lblx_empName = new System.Windows.Forms.Label();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.tb_rate = new System.Windows.Forms.TextBox();
            this.tb_workhours = new System.Windows.Forms.TextBox();
            this.tb_social = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.grpBox_insurance = new System.Windows.Forms.GroupBox();
            this.rdo_premium = new System.Windows.Forms.RadioButton();
            this.rdo_basic = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_viewList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.textHiddenEmployeeID = new System.Windows.Forms.TextBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_regularList = new System.Windows.Forms.Button();
            this.btn_ContractList = new System.Windows.Forms.Button();
            this.grpBox_paysummary.SuspendLayout();
            this.grpBox_insurance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_required
            // 
            this.lbl_required.AutoSize = true;
            this.lbl_required.BackColor = System.Drawing.Color.Transparent;
            this.lbl_required.ForeColor = System.Drawing.Color.White;
            this.lbl_required.Location = new System.Drawing.Point(71, 23);
            this.lbl_required.Name = "lbl_required";
            this.lbl_required.Size = new System.Drawing.Size(179, 13);
            this.lbl_required.TabIndex = 0;
            this.lbl_required.Text = "Please enter the required information";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fname.ForeColor = System.Drawing.Color.White;
            this.lbl_fname.Location = new System.Drawing.Point(71, 57);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(60, 13);
            this.lbl_fname.TabIndex = 1;
            this.lbl_fname.Text = "First Name:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lname.ForeColor = System.Drawing.Color.White;
            this.lbl_lname.Location = new System.Drawing.Point(318, 57);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(61, 13);
            this.lbl_lname.TabIndex = 2;
            this.lbl_lname.Text = "Last Name:";
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rate.ForeColor = System.Drawing.Color.White;
            this.lbl_rate.Location = new System.Drawing.Point(71, 90);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(53, 13);
            this.lbl_rate.TabIndex = 3;
            this.lbl_rate.Text = "Rate / hr:";
            // 
            // lbl_workhours
            // 
            this.lbl_workhours.AutoSize = true;
            this.lbl_workhours.BackColor = System.Drawing.Color.Transparent;
            this.lbl_workhours.ForeColor = System.Drawing.Color.White;
            this.lbl_workhours.Location = new System.Drawing.Point(318, 90);
            this.lbl_workhours.Name = "lbl_workhours";
            this.lbl_workhours.Size = new System.Drawing.Size(62, 13);
            this.lbl_workhours.TabIndex = 4;
            this.lbl_workhours.Text = "Work hours";
            // 
            // lbl_social
            // 
            this.lbl_social.AutoSize = true;
            this.lbl_social.BackColor = System.Drawing.Color.Transparent;
            this.lbl_social.ForeColor = System.Drawing.Color.White;
            this.lbl_social.Location = new System.Drawing.Point(71, 124);
            this.lbl_social.Name = "lbl_social";
            this.lbl_social.Size = new System.Drawing.Size(77, 13);
            this.lbl_social.TabIndex = 5;
            this.lbl_social.Text = "Social Security";
            // 
            // lbl_insurance
            // 
            this.lbl_insurance.AutoSize = true;
            this.lbl_insurance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_insurance.ForeColor = System.Drawing.Color.White;
            this.lbl_insurance.Location = new System.Drawing.Point(318, 124);
            this.lbl_insurance.Name = "lbl_insurance";
            this.lbl_insurance.Size = new System.Drawing.Size(54, 13);
            this.lbl_insurance.TabIndex = 6;
            this.lbl_insurance.Text = "Insurance";
            // 
            // grpBox_paysummary
            // 
            this.grpBox_paysummary.BackColor = System.Drawing.Color.SteelBlue;
            this.grpBox_paysummary.Controls.Add(this.label39);
            this.grpBox_paysummary.Controls.Add(this.lblx_netpay);
            this.grpBox_paysummary.Controls.Add(this.lbl_netpay);
            this.grpBox_paysummary.Controls.Add(this.lblx_ttlDeductions);
            this.grpBox_paysummary.Controls.Add(this.lbl_ttlDeductions);
            this.grpBox_paysummary.Controls.Add(this.lblx_ins);
            this.grpBox_paysummary.Controls.Add(this.lbl_ins);
            this.grpBox_paysummary.Controls.Add(this.lblx_SocialSecurity);
            this.grpBox_paysummary.Controls.Add(this.lbl_socialSecurity);
            this.grpBox_paysummary.Controls.Add(this.lblx_fedTax);
            this.grpBox_paysummary.Controls.Add(this.lbl_fedTax);
            this.grpBox_paysummary.Controls.Add(this.lbl_deductions);
            this.grpBox_paysummary.Controls.Add(this.lbx_totalGrossPay);
            this.grpBox_paysummary.Controls.Add(this.lbl_totalGross);
            this.grpBox_paysummary.Controls.Add(this.lblx_totalOvertimeEarnings);
            this.grpBox_paysummary.Controls.Add(this.lbl_totalOvertimeEarnings);
            this.grpBox_paysummary.Controls.Add(this.lblx_othours);
            this.grpBox_paysummary.Controls.Add(this.lbl_othours);
            this.grpBox_paysummary.Controls.Add(this.lblx_overtimerate);
            this.grpBox_paysummary.Controls.Add(this.lbl_overtimerate);
            this.grpBox_paysummary.Controls.Add(this.lbl_overtimeearnings);
            this.grpBox_paysummary.Controls.Add(this.lblx_totalreg);
            this.grpBox_paysummary.Controls.Add(this.lbl_totalreg);
            this.grpBox_paysummary.Controls.Add(this.lblx_grp_workhours);
            this.grpBox_paysummary.Controls.Add(this.lbl_grp_workhours);
            this.grpBox_paysummary.Controls.Add(this.lblx_grp_rate);
            this.grpBox_paysummary.Controls.Add(this.lbl_grp_rate);
            this.grpBox_paysummary.Controls.Add(this.lbl_regearnings);
            this.grpBox_paysummary.Controls.Add(this.lblx_ss);
            this.grpBox_paysummary.Controls.Add(this.lbl_ss);
            this.grpBox_paysummary.Controls.Add(this.lblx_empName);
            this.grpBox_paysummary.Controls.Add(this.lbl_empName);
            this.grpBox_paysummary.Location = new System.Drawing.Point(39, 174);
            this.grpBox_paysummary.Name = "grpBox_paysummary";
            this.grpBox_paysummary.Size = new System.Drawing.Size(779, 349);
            this.grpBox_paysummary.TabIndex = 7;
            this.grpBox_paysummary.TabStop = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(27, 11);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(0, 13);
            this.label39.TabIndex = 16;
            // 
            // lblx_netpay
            // 
            this.lblx_netpay.AutoSize = true;
            this.lblx_netpay.Location = new System.Drawing.Point(635, 326);
            this.lblx_netpay.Name = "lblx_netpay";
            this.lblx_netpay.Size = new System.Drawing.Size(37, 13);
            this.lblx_netpay.TabIndex = 30;
            this.lblx_netpay.Text = "$ 0.00";
            // 
            // lbl_netpay
            // 
            this.lbl_netpay.AutoSize = true;
            this.lbl_netpay.Location = new System.Drawing.Point(392, 326);
            this.lbl_netpay.Name = "lbl_netpay";
            this.lbl_netpay.Size = new System.Drawing.Size(53, 13);
            this.lbl_netpay.TabIndex = 29;
            this.lbl_netpay.Text = "NET PAY";
            // 
            // lblx_ttlDeductions
            // 
            this.lblx_ttlDeductions.AutoSize = true;
            this.lblx_ttlDeductions.Location = new System.Drawing.Point(516, 299);
            this.lblx_ttlDeductions.Name = "lblx_ttlDeductions";
            this.lblx_ttlDeductions.Size = new System.Drawing.Size(37, 13);
            this.lblx_ttlDeductions.TabIndex = 28;
            this.lblx_ttlDeductions.Text = "$ 0.00";
            // 
            // lbl_ttlDeductions
            // 
            this.lbl_ttlDeductions.AutoSize = true;
            this.lbl_ttlDeductions.Location = new System.Drawing.Point(71, 299);
            this.lbl_ttlDeductions.Name = "lbl_ttlDeductions";
            this.lbl_ttlDeductions.Size = new System.Drawing.Size(88, 13);
            this.lbl_ttlDeductions.TabIndex = 27;
            this.lbl_ttlDeductions.Text = "Total Deductions";
            // 
            // lblx_ins
            // 
            this.lblx_ins.AutoSize = true;
            this.lblx_ins.Location = new System.Drawing.Point(253, 277);
            this.lblx_ins.Name = "lblx_ins";
            this.lblx_ins.Size = new System.Drawing.Size(37, 13);
            this.lblx_ins.TabIndex = 26;
            this.lblx_ins.Text = "$ 0.00";
            // 
            // lbl_ins
            // 
            this.lbl_ins.AutoSize = true;
            this.lbl_ins.Location = new System.Drawing.Point(71, 277);
            this.lbl_ins.Name = "lbl_ins";
            this.lbl_ins.Size = new System.Drawing.Size(54, 13);
            this.lbl_ins.TabIndex = 25;
            this.lbl_ins.Text = "Insurance";
            // 
            // lblx_SocialSecurity
            // 
            this.lblx_SocialSecurity.AutoSize = true;
            this.lblx_SocialSecurity.Location = new System.Drawing.Point(253, 264);
            this.lblx_SocialSecurity.Name = "lblx_SocialSecurity";
            this.lblx_SocialSecurity.Size = new System.Drawing.Size(37, 13);
            this.lblx_SocialSecurity.TabIndex = 24;
            this.lblx_SocialSecurity.Text = "$ 0.00";
            // 
            // lbl_socialSecurity
            // 
            this.lbl_socialSecurity.AutoSize = true;
            this.lbl_socialSecurity.Location = new System.Drawing.Point(71, 264);
            this.lbl_socialSecurity.Name = "lbl_socialSecurity";
            this.lbl_socialSecurity.Size = new System.Drawing.Size(77, 13);
            this.lbl_socialSecurity.TabIndex = 23;
            this.lbl_socialSecurity.Text = "Social Security";
            // 
            // lblx_fedTax
            // 
            this.lblx_fedTax.AutoSize = true;
            this.lblx_fedTax.Location = new System.Drawing.Point(253, 251);
            this.lblx_fedTax.Name = "lblx_fedTax";
            this.lblx_fedTax.Size = new System.Drawing.Size(37, 13);
            this.lblx_fedTax.TabIndex = 22;
            this.lblx_fedTax.Text = "$ 0.00";
            // 
            // lbl_fedTax
            // 
            this.lbl_fedTax.AutoSize = true;
            this.lbl_fedTax.Location = new System.Drawing.Point(71, 251);
            this.lbl_fedTax.Name = "lbl_fedTax";
            this.lbl_fedTax.Size = new System.Drawing.Size(66, 13);
            this.lbl_fedTax.TabIndex = 21;
            this.lbl_fedTax.Text = "Federal Tax:";
            // 
            // lbl_deductions
            // 
            this.lbl_deductions.AutoSize = true;
            this.lbl_deductions.Location = new System.Drawing.Point(27, 233);
            this.lbl_deductions.Name = "lbl_deductions";
            this.lbl_deductions.Size = new System.Drawing.Size(81, 13);
            this.lbl_deductions.TabIndex = 20;
            this.lbl_deductions.Text = "DEDUCTIONS:";
            // 
            // lbx_totalGrossPay
            // 
            this.lbx_totalGrossPay.AutoSize = true;
            this.lbx_totalGrossPay.Location = new System.Drawing.Point(635, 204);
            this.lbx_totalGrossPay.Name = "lbx_totalGrossPay";
            this.lbx_totalGrossPay.Size = new System.Drawing.Size(37, 13);
            this.lbx_totalGrossPay.TabIndex = 19;
            this.lbx_totalGrossPay.Text = "$ 0.00";
            // 
            // lbl_totalGross
            // 
            this.lbl_totalGross.AutoSize = true;
            this.lbl_totalGross.Location = new System.Drawing.Point(25, 204);
            this.lbl_totalGross.Name = "lbl_totalGross";
            this.lbl_totalGross.Size = new System.Drawing.Size(82, 13);
            this.lbl_totalGross.TabIndex = 18;
            this.lbl_totalGross.Text = "Total Gross Pay";
            // 
            // lblx_totalOvertimeEarnings
            // 
            this.lblx_totalOvertimeEarnings.AutoSize = true;
            this.lblx_totalOvertimeEarnings.Location = new System.Drawing.Point(516, 183);
            this.lblx_totalOvertimeEarnings.Name = "lblx_totalOvertimeEarnings";
            this.lblx_totalOvertimeEarnings.Size = new System.Drawing.Size(37, 13);
            this.lblx_totalOvertimeEarnings.TabIndex = 17;
            this.lblx_totalOvertimeEarnings.Text = "$ 0.00";
            // 
            // lbl_totalOvertimeEarnings
            // 
            this.lbl_totalOvertimeEarnings.AutoSize = true;
            this.lbl_totalOvertimeEarnings.Location = new System.Drawing.Point(71, 183);
            this.lbl_totalOvertimeEarnings.Name = "lbl_totalOvertimeEarnings";
            this.lbl_totalOvertimeEarnings.Size = new System.Drawing.Size(120, 13);
            this.lbl_totalOvertimeEarnings.TabIndex = 16;
            this.lbl_totalOvertimeEarnings.Text = "Total Overtime Earnings";
            // 
            // lblx_othours
            // 
            this.lblx_othours.AutoSize = true;
            this.lblx_othours.Location = new System.Drawing.Point(253, 168);
            this.lblx_othours.Name = "lblx_othours";
            this.lblx_othours.Size = new System.Drawing.Size(34, 13);
            this.lblx_othours.TabIndex = 15;
            this.lblx_othours.Text = "  0.00";
            // 
            // lbl_othours
            // 
            this.lbl_othours.AutoSize = true;
            this.lbl_othours.Location = new System.Drawing.Point(71, 168);
            this.lbl_othours.Name = "lbl_othours";
            this.lbl_othours.Size = new System.Drawing.Size(81, 13);
            this.lbl_othours.TabIndex = 14;
            this.lbl_othours.Text = "Overtime hours:";
            // 
            // lblx_overtimerate
            // 
            this.lblx_overtimerate.AutoSize = true;
            this.lblx_overtimerate.Location = new System.Drawing.Point(253, 152);
            this.lblx_overtimerate.Name = "lblx_overtimerate";
            this.lblx_overtimerate.Size = new System.Drawing.Size(37, 13);
            this.lblx_overtimerate.TabIndex = 13;
            this.lblx_overtimerate.Text = "$ 0.00";
            // 
            // lbl_overtimerate
            // 
            this.lbl_overtimerate.AutoSize = true;
            this.lbl_overtimerate.Location = new System.Drawing.Point(71, 152);
            this.lbl_overtimerate.Name = "lbl_overtimerate";
            this.lbl_overtimerate.Size = new System.Drawing.Size(73, 13);
            this.lbl_overtimerate.TabIndex = 12;
            this.lbl_overtimerate.Text = "Overtime rate:";
            // 
            // lbl_overtimeearnings
            // 
            this.lbl_overtimeearnings.AutoSize = true;
            this.lbl_overtimeearnings.Location = new System.Drawing.Point(25, 132);
            this.lbl_overtimeearnings.Name = "lbl_overtimeearnings";
            this.lbl_overtimeearnings.Size = new System.Drawing.Size(125, 13);
            this.lbl_overtimeearnings.TabIndex = 11;
            this.lbl_overtimeearnings.Text = "OVERTIME EARNINGS:";
            // 
            // lblx_totalreg
            // 
            this.lblx_totalreg.AutoSize = true;
            this.lblx_totalreg.Location = new System.Drawing.Point(516, 110);
            this.lblx_totalreg.Name = "lblx_totalreg";
            this.lblx_totalreg.Size = new System.Drawing.Size(37, 13);
            this.lblx_totalreg.TabIndex = 10;
            this.lblx_totalreg.Text = "$ 0.00";
            // 
            // lbl_totalreg
            // 
            this.lbl_totalreg.AutoSize = true;
            this.lbl_totalreg.Location = new System.Drawing.Point(71, 110);
            this.lbl_totalreg.Name = "lbl_totalreg";
            this.lbl_totalreg.Size = new System.Drawing.Size(115, 13);
            this.lbl_totalreg.TabIndex = 9;
            this.lbl_totalreg.Text = "Total Regular Earnings";
            // 
            // lblx_grp_workhours
            // 
            this.lblx_grp_workhours.AutoSize = true;
            this.lblx_grp_workhours.Location = new System.Drawing.Point(253, 94);
            this.lblx_grp_workhours.Name = "lblx_grp_workhours";
            this.lblx_grp_workhours.Size = new System.Drawing.Size(34, 13);
            this.lblx_grp_workhours.TabIndex = 8;
            this.lblx_grp_workhours.Text = "  0.00";
            // 
            // lbl_grp_workhours
            // 
            this.lbl_grp_workhours.AutoSize = true;
            this.lbl_grp_workhours.Location = new System.Drawing.Point(71, 94);
            this.lbl_grp_workhours.Name = "lbl_grp_workhours";
            this.lbl_grp_workhours.Size = new System.Drawing.Size(65, 13);
            this.lbl_grp_workhours.TabIndex = 7;
            this.lbl_grp_workhours.Text = "Work hours:";
            // 
            // lblx_grp_rate
            // 
            this.lblx_grp_rate.AutoSize = true;
            this.lblx_grp_rate.Location = new System.Drawing.Point(253, 79);
            this.lblx_grp_rate.Name = "lblx_grp_rate";
            this.lblx_grp_rate.Size = new System.Drawing.Size(37, 13);
            this.lblx_grp_rate.TabIndex = 6;
            this.lblx_grp_rate.Text = "$ 0.00";
            // 
            // lbl_grp_rate
            // 
            this.lbl_grp_rate.AutoSize = true;
            this.lbl_grp_rate.Location = new System.Drawing.Point(71, 79);
            this.lbl_grp_rate.Name = "lbl_grp_rate";
            this.lbl_grp_rate.Size = new System.Drawing.Size(33, 13);
            this.lbl_grp_rate.TabIndex = 5;
            this.lbl_grp_rate.Text = "Rate:";
            // 
            // lbl_regearnings
            // 
            this.lbl_regearnings.AutoSize = true;
            this.lbl_regearnings.Location = new System.Drawing.Point(25, 60);
            this.lbl_regearnings.Name = "lbl_regearnings";
            this.lbl_regearnings.Size = new System.Drawing.Size(121, 13);
            this.lbl_regearnings.TabIndex = 4;
            this.lbl_regearnings.Text = "REGULAR EARNINGS:";
            // 
            // lblx_ss
            // 
            this.lblx_ss.AutoSize = true;
            this.lblx_ss.Location = new System.Drawing.Point(516, 24);
            this.lblx_ss.Name = "lblx_ss";
            this.lblx_ss.Size = new System.Drawing.Size(47, 13);
            this.lblx_ss.TabIndex = 3;
            this.lblx_ss.Text = "xxxxxxxx";
            // 
            // lbl_ss
            // 
            this.lbl_ss.AutoSize = true;
            this.lbl_ss.Location = new System.Drawing.Point(412, 24);
            this.lbl_ss.Name = "lbl_ss";
            this.lbl_ss.Size = new System.Drawing.Size(80, 13);
            this.lbl_ss.TabIndex = 2;
            this.lbl_ss.Text = "Social Security:";
            // 
            // lblx_empName
            // 
            this.lblx_empName.AutoSize = true;
            this.lblx_empName.Location = new System.Drawing.Point(139, 24);
            this.lblx_empName.Name = "lblx_empName";
            this.lblx_empName.Size = new System.Drawing.Size(52, 13);
            this.lblx_empName.TabIndex = 1;
            this.lblx_empName.Text = "xxxxxxxxx";
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Location = new System.Drawing.Point(25, 24);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(94, 13);
            this.lbl_empName.TabIndex = 0;
            this.lbl_empName.Text = "Employee\'s Name:";
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(154, 54);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(135, 20);
            this.tb_fname.TabIndex = 8;
            // 
            // tb_lname
            // 
            this.tb_lname.Location = new System.Drawing.Point(399, 54);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(135, 20);
            this.tb_lname.TabIndex = 9;
            // 
            // tb_rate
            // 
            this.tb_rate.Location = new System.Drawing.Point(154, 87);
            this.tb_rate.Name = "tb_rate";
            this.tb_rate.Size = new System.Drawing.Size(135, 20);
            this.tb_rate.TabIndex = 10;
            this.tb_rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // tb_workhours
            // 
            this.tb_workhours.Location = new System.Drawing.Point(400, 87);
            this.tb_workhours.Name = "tb_workhours";
            this.tb_workhours.Size = new System.Drawing.Size(135, 20);
            this.tb_workhours.TabIndex = 11;
            this.tb_workhours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // tb_social
            // 
            this.tb_social.Location = new System.Drawing.Point(154, 121);
            this.tb_social.Name = "tb_social";
            this.tb_social.Size = new System.Drawing.Size(135, 20);
            this.tb_social.TabIndex = 12;
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calc.ForeColor = System.Drawing.Color.White;
            this.btn_calc.Location = new System.Drawing.Point(694, 60);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(168, 43);
            this.btn_calc.TabIndex = 14;
            this.btn_calc.Text = "Calculate Pay";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBox_insurance
            // 
            this.grpBox_insurance.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_insurance.Controls.Add(this.rdo_premium);
            this.grpBox_insurance.Controls.Add(this.rdo_basic);
            this.grpBox_insurance.Location = new System.Drawing.Point(400, 113);
            this.grpBox_insurance.Name = "grpBox_insurance";
            this.grpBox_insurance.Size = new System.Drawing.Size(244, 33);
            this.grpBox_insurance.TabIndex = 15;
            this.grpBox_insurance.TabStop = false;
            // 
            // rdo_premium
            // 
            this.rdo_premium.AutoSize = true;
            this.rdo_premium.BackColor = System.Drawing.Color.Transparent;
            this.rdo_premium.ForeColor = System.Drawing.Color.White;
            this.rdo_premium.Location = new System.Drawing.Point(84, 11);
            this.rdo_premium.Name = "rdo_premium";
            this.rdo_premium.Size = new System.Drawing.Size(65, 17);
            this.rdo_premium.TabIndex = 1;
            this.rdo_premium.TabStop = true;
            this.rdo_premium.Text = "Premium";
            this.rdo_premium.UseVisualStyleBackColor = false;
            // 
            // rdo_basic
            // 
            this.rdo_basic.AutoSize = true;
            this.rdo_basic.BackColor = System.Drawing.Color.Transparent;
            this.rdo_basic.ForeColor = System.Drawing.Color.White;
            this.rdo_basic.Location = new System.Drawing.Point(7, 11);
            this.rdo_basic.Name = "rdo_basic";
            this.rdo_basic.Size = new System.Drawing.Size(51, 17);
            this.rdo_basic.TabIndex = 0;
            this.rdo_basic.TabStop = true;
            this.rdo_basic.Text = "Basic";
            this.rdo_basic.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(694, 114);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(168, 33);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_viewList
            // 
            this.btn_viewList.BackColor = System.Drawing.Color.Green;
            this.btn_viewList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewList.Location = new System.Drawing.Point(39, 553);
            this.btn_viewList.Name = "btn_viewList";
            this.btn_viewList.Size = new System.Drawing.Size(137, 33);
            this.btn_viewList.TabIndex = 17;
            this.btn_viewList.Text = "View Records";
            this.btn_viewList.UseVisualStyleBackColor = false;
            this.btn_viewList.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(39, 592);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(707, 181);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Green;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Location = new System.Drawing.Point(772, 610);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(90, 33);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Location = new System.Drawing.Point(772, 661);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 33);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Location = new System.Drawing.Point(772, 713);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(90, 33);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // textHiddenEmployeeID
            // 
            this.textHiddenEmployeeID.Location = new System.Drawing.Point(509, 20);
            this.textHiddenEmployeeID.Name = "textHiddenEmployeeID";
            this.textHiddenEmployeeID.Size = new System.Drawing.Size(135, 20);
            this.textHiddenEmployeeID.TabIndex = 22;
            this.textHiddenEmployeeID.Visible = false;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(534, 567);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(131, 20);
            this.tb_search.TabIndex = 23;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Green;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(671, 566);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 20);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_regularList
            // 
            this.btn_regularList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_regularList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regularList.Location = new System.Drawing.Point(205, 553);
            this.btn_regularList.Name = "btn_regularList";
            this.btn_regularList.Size = new System.Drawing.Size(133, 33);
            this.btn_regularList.TabIndex = 25;
            this.btn_regularList.Text = "Regular List";
            this.btn_regularList.UseVisualStyleBackColor = false;
            this.btn_regularList.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_ContractList
            // 
            this.btn_ContractList.BackColor = System.Drawing.Color.Silver;
            this.btn_ContractList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ContractList.Location = new System.Drawing.Point(370, 553);
            this.btn_ContractList.Name = "btn_ContractList";
            this.btn_ContractList.Size = new System.Drawing.Size(133, 33);
            this.btn_ContractList.TabIndex = 26;
            this.btn_ContractList.Text = "Contract List";
            this.btn_ContractList.UseVisualStyleBackColor = false;
            this.btn_ContractList.Click += new System.EventHandler(this.button9_Click);
            // 
            // FormEmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ThomasM_PayrollProgram.Properties.Resources._99BJx;
            this.ClientSize = new System.Drawing.Size(893, 799);
            this.Controls.Add(this.btn_ContractList);
            this.Controls.Add(this.btn_regularList);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.textHiddenEmployeeID);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_viewList);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grpBox_insurance);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.tb_social);
            this.Controls.Add(this.tb_workhours);
            this.Controls.Add(this.tb_rate);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.grpBox_paysummary);
            this.Controls.Add(this.lbl_insurance);
            this.Controls.Add(this.lbl_social);
            this.Controls.Add(this.lbl_workhours);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_required);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormEmpInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            this.grpBox_paysummary.ResumeLayout(false);
            this.grpBox_paysummary.PerformLayout();
            this.grpBox_insurance.ResumeLayout(false);
            this.grpBox_insurance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_required;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.Label lbl_workhours;
        private System.Windows.Forms.Label lbl_social;
        private System.Windows.Forms.Label lbl_insurance;
        private System.Windows.Forms.GroupBox grpBox_paysummary;
        private System.Windows.Forms.Label lblx_netpay;
        private System.Windows.Forms.Label lbl_netpay;
        private System.Windows.Forms.Label lblx_ttlDeductions;
        private System.Windows.Forms.Label lbl_ttlDeductions;
        private System.Windows.Forms.Label lblx_ins;
        private System.Windows.Forms.Label lbl_ins;
        private System.Windows.Forms.Label lblx_SocialSecurity;
        private System.Windows.Forms.Label lbl_socialSecurity;
        private System.Windows.Forms.Label lblx_fedTax;
        private System.Windows.Forms.Label lbl_fedTax;
        private System.Windows.Forms.Label lbl_deductions;
        private System.Windows.Forms.Label lbx_totalGrossPay;
        private System.Windows.Forms.Label lbl_totalGross;
        private System.Windows.Forms.Label lblx_totalOvertimeEarnings;
        private System.Windows.Forms.Label lbl_totalOvertimeEarnings;
        private System.Windows.Forms.Label lblx_othours;
        private System.Windows.Forms.Label lbl_othours;
        private System.Windows.Forms.Label lblx_overtimerate;
        private System.Windows.Forms.Label lbl_overtimerate;
        private System.Windows.Forms.Label lbl_overtimeearnings;
        private System.Windows.Forms.Label lblx_totalreg;
        private System.Windows.Forms.Label lbl_totalreg;
        private System.Windows.Forms.Label lblx_grp_workhours;
        private System.Windows.Forms.Label lbl_grp_workhours;
        private System.Windows.Forms.Label lblx_grp_rate;
        private System.Windows.Forms.Label lbl_grp_rate;
        private System.Windows.Forms.Label lbl_regearnings;
        private System.Windows.Forms.Label lblx_ss;
        private System.Windows.Forms.Label lbl_ss;
        private System.Windows.Forms.Label lblx_empName;
        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.TextBox tb_rate;
        private System.Windows.Forms.TextBox tb_workhours;
        private System.Windows.Forms.TextBox tb_social;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.GroupBox grpBox_insurance;
        private System.Windows.Forms.RadioButton rdo_premium;
        private System.Windows.Forms.RadioButton rdo_basic;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_viewList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox textHiddenEmployeeID;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_regularList;
        private System.Windows.Forms.Button btn_ContractList;
    }
}