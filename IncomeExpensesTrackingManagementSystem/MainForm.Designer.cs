
namespace IncomeExpensesTrackingManagementSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.expenses_btn = new System.Windows.Forms.Button();
            this.income_btn = new System.Windows.Forms.Button();
            this.addCategory_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greetUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardForm1 = new IncomeExpensesTrackingManagementSystem.DashboardForm();
            this.expensesForm1 = new IncomeExpensesTrackingManagementSystem.ExpensesForm();
            this.incomeForm1 = new IncomeExpensesTrackingManagementSystem.IncomeForm();
            this.categoryForm1 = new IncomeExpensesTrackingManagementSystem.CategoryForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 45);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IncomeExpensesTrackingManagementSystem.Properties.Resources.icons8_budget_22px;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Income and Expenses Tracker";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1353, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(18, 18);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.expenses_btn);
            this.panel2.Controls.Add(this.income_btn);
            this.panel2.Controls.Add(this.addCategory_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greetUser);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 748);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::IncomeExpensesTrackingManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_25px;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(12, 696);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(201, 40);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // expenses_btn
            // 
            this.expenses_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.expenses_btn.FlatAppearance.BorderSize = 0;
            this.expenses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_btn.ForeColor = System.Drawing.Color.White;
            this.expenses_btn.Image = global::IncomeExpensesTrackingManagementSystem.Properties.Resources.icons8_card_in_use_filled_25px1;
            this.expenses_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenses_btn.Location = new System.Drawing.Point(17, 389);
            this.expenses_btn.Name = "expenses_btn";
            this.expenses_btn.Size = new System.Drawing.Size(201, 40);
            this.expenses_btn.TabIndex = 5;
            this.expenses_btn.Text = "Expenses";
            this.expenses_btn.UseVisualStyleBackColor = false;
            this.expenses_btn.Click += new System.EventHandler(this.expenses_btn_Click);
            // 
            // income_btn
            // 
            this.income_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_btn.FlatAppearance.BorderSize = 0;
            this.income_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_btn.ForeColor = System.Drawing.Color.White;
            this.income_btn.Image = global::IncomeExpensesTrackingManagementSystem.Properties.Resources.icons8_stack_of_money_25px;
            this.income_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income_btn.Location = new System.Drawing.Point(17, 334);
            this.income_btn.Name = "income_btn";
            this.income_btn.Size = new System.Drawing.Size(201, 40);
            this.income_btn.TabIndex = 4;
            this.income_btn.Text = "Income";
            this.income_btn.UseVisualStyleBackColor = false;
            this.income_btn.Click += new System.EventHandler(this.income_btn_Click);
            // 
            // addCategory_btn
            // 
            this.addCategory_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.addCategory_btn.FlatAppearance.BorderSize = 0;
            this.addCategory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory_btn.ForeColor = System.Drawing.Color.White;
            this.addCategory_btn.Image = global::IncomeExpensesTrackingManagementSystem.Properties.Resources.icons8_category_25px;
            this.addCategory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategory_btn.Location = new System.Drawing.Point(17, 280);
            this.addCategory_btn.Name = "addCategory_btn";
            this.addCategory_btn.Size = new System.Drawing.Size(201, 40);
            this.addCategory_btn.TabIndex = 3;
            this.addCategory_btn.Text = "Add Category";
            this.addCategory_btn.UseVisualStyleBackColor = false;
            this.addCategory_btn.Click += new System.EventHandler(this.addCategory_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::IncomeExpensesTrackingManagementSystem.Properties.Resources.icons8_dashboard_25px;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(17, 225);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(201, 40);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greetUser
            // 
            this.greetUser.AutoSize = true;
            this.greetUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetUser.ForeColor = System.Drawing.Color.White;
            this.greetUser.Location = new System.Drawing.Point(13, 156);
            this.greetUser.Name = "greetUser";
            this.greetUser.Size = new System.Drawing.Size(78, 19);
            this.greetUser.TabIndex = 1;
            this.greetUser.Text = "Welcome,";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IncomeExpensesTrackingManagementSystem.Properties.Resources.icons8_budget_100px_1;
            this.pictureBox2.Location = new System.Drawing.Point(61, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Controls.Add(this.expensesForm1);
            this.panel3.Controls.Add(this.incomeForm1);
            this.panel3.Controls.Add(this.categoryForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(234, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 748);
            this.panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1145, 748);
            this.dashboardForm1.TabIndex = 3;
            // 
            // expensesForm1
            // 
            this.expensesForm1.Location = new System.Drawing.Point(-3, 0);
            this.expensesForm1.Name = "expensesForm1";
            this.expensesForm1.Size = new System.Drawing.Size(1145, 748);
            this.expensesForm1.TabIndex = 2;
            // 
            // incomeForm1
            // 
            this.incomeForm1.Location = new System.Drawing.Point(0, -3);
            this.incomeForm1.Name = "incomeForm1";
            this.incomeForm1.Size = new System.Drawing.Size(1145, 748);
            this.incomeForm1.TabIndex = 1;
            // 
            // categoryForm1
            // 
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(1145, 748);
            this.categoryForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 793);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label greetUser;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button expenses_btn;
        private System.Windows.Forms.Button income_btn;
        private System.Windows.Forms.Button addCategory_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel3;
        private CategoryForm categoryForm1;
        private IncomeForm incomeForm1;
        private ExpensesForm expensesForm1;
        private DashboardForm dashboardForm1;
    }
}