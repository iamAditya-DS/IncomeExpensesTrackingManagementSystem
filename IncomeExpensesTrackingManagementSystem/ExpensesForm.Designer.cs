
namespace IncomeExpensesTrackingManagementSystem
{
    partial class ExpensesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expense_clearBtn = new System.Windows.Forms.Button();
            this.expense_deleteBtn = new System.Windows.Forms.Button();
            this.expense_updateBtn = new System.Windows.Forms.Button();
            this.expense_addBtn = new System.Windows.Forms.Button();
            this.expense_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.expense_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expense_cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expense_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expense_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(25, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1423, 359);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // expense_clearBtn
            // 
            this.expense_clearBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.expense_clearBtn.FlatAppearance.BorderSize = 0;
            this.expense_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expense_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expense_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_clearBtn.ForeColor = System.Drawing.Color.Black;
            this.expense_clearBtn.Location = new System.Drawing.Point(959, 294);
            this.expense_clearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_clearBtn.Name = "expense_clearBtn";
            this.expense_clearBtn.Size = new System.Drawing.Size(137, 50);
            this.expense_clearBtn.TabIndex = 14;
            this.expense_clearBtn.Text = "Clear";
            this.expense_clearBtn.UseVisualStyleBackColor = false;
            this.expense_clearBtn.Click += new System.EventHandler(this.expense_clearBtn_Click);
            // 
            // expense_deleteBtn
            // 
            this.expense_deleteBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.expense_deleteBtn.FlatAppearance.BorderSize = 0;
            this.expense_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expense_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expense_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.expense_deleteBtn.Location = new System.Drawing.Point(760, 294);
            this.expense_deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_deleteBtn.Name = "expense_deleteBtn";
            this.expense_deleteBtn.Size = new System.Drawing.Size(137, 50);
            this.expense_deleteBtn.TabIndex = 13;
            this.expense_deleteBtn.Text = "Delete";
            this.expense_deleteBtn.UseVisualStyleBackColor = false;
            this.expense_deleteBtn.Click += new System.EventHandler(this.expense_deleteBtn_Click);
            // 
            // expense_updateBtn
            // 
            this.expense_updateBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.expense_updateBtn.FlatAppearance.BorderSize = 0;
            this.expense_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expense_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expense_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_updateBtn.ForeColor = System.Drawing.Color.Black;
            this.expense_updateBtn.Location = new System.Drawing.Point(477, 294);
            this.expense_updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_updateBtn.Name = "expense_updateBtn";
            this.expense_updateBtn.Size = new System.Drawing.Size(137, 50);
            this.expense_updateBtn.TabIndex = 12;
            this.expense_updateBtn.Text = "Update";
            this.expense_updateBtn.UseVisualStyleBackColor = false;
            this.expense_updateBtn.Click += new System.EventHandler(this.expense_updateBtn_Click);
            // 
            // expense_addBtn
            // 
            this.expense_addBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.expense_addBtn.FlatAppearance.BorderSize = 0;
            this.expense_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expense_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expense_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_addBtn.ForeColor = System.Drawing.Color.Black;
            this.expense_addBtn.Location = new System.Drawing.Point(279, 294);
            this.expense_addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_addBtn.Name = "expense_addBtn";
            this.expense_addBtn.Size = new System.Drawing.Size(137, 50);
            this.expense_addBtn.TabIndex = 11;
            this.expense_addBtn.Text = "Add";
            this.expense_addBtn.UseVisualStyleBackColor = false;
            this.expense_addBtn.Click += new System.EventHandler(this.income_addBtn_Click);
            // 
            // expense_date
            // 
            this.expense_date.Location = new System.Drawing.Point(792, 176);
            this.expense_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_date.Name = "expense_date";
            this.expense_date.Size = new System.Drawing.Size(265, 22);
            this.expense_date.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(721, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date:";
            // 
            // expense_description
            // 
            this.expense_description.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.expense_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_description.Location = new System.Drawing.Point(792, 48);
            this.expense_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_description.Multiline = true;
            this.expense_description.Name = "expense_description";
            this.expense_description.Size = new System.Drawing.Size(576, 89);
            this.expense_description.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(659, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description:";
            // 
            // expense_cost
            // 
            this.expense_cost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.expense_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_cost.Location = new System.Drawing.Point(241, 174);
            this.expense_cost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_cost.Name = "expense_cost";
            this.expense_cost.Size = new System.Drawing.Size(255, 30);
            this.expense_cost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item:";
            // 
            // expense_category
            // 
            this.expense_category.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.expense_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_category.FormattingEnabled = true;
            this.expense_category.Location = new System.Drawing.Point(241, 48);
            this.expense_category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_category.Name = "expense_category";
            this.expense_category.Size = new System.Drawing.Size(255, 33);
            this.expense_category.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.expense_clearBtn);
            this.panel2.Controls.Add(this.expense_deleteBtn);
            this.panel2.Controls.Add(this.expense_updateBtn);
            this.panel2.Controls.Add(this.expense_addBtn);
            this.panel2.Controls.Add(this.expense_date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.expense_description);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.expense_cost);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.expense_item);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.expense_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 516);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1476, 375);
            this.panel2.TabIndex = 4;
            // 
            // expense_item
            // 
            this.expense_item.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.expense_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_item.Location = new System.Drawing.Point(241, 111);
            this.expense_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expense_item.Name = "expense_item";
            this.expense_item.Size = new System.Drawing.Size(255, 30);
            this.expense_item.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenses List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 458);
            this.panel1.TabIndex = 3;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExpensesForm";
            this.Size = new System.Drawing.Size(1527, 921);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button expense_clearBtn;
        private System.Windows.Forms.Button expense_deleteBtn;
        private System.Windows.Forms.Button expense_updateBtn;
        private System.Windows.Forms.Button expense_addBtn;
        private System.Windows.Forms.DateTimePicker expense_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expense_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expense_cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expense_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox expense_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
