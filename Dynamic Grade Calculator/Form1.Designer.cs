
namespace Dynamic_Grade_Calculator
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
            this.components = new System.ComponentModel.Container();
            this.errorProviderPaperNumbers = new System.Windows.Forms.ErrorProvider(this.components);
            this.homePage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.nameOfSubject = new System.Windows.Forms.Label();
            this.nameOfSubjectInput = new System.Windows.Forms.TextBox();
            this.numberOfPapersInput = new System.Windows.Forms.TextBox();
            this.overallGrade = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.generateTable = new System.Windows.Forms.Button();
            this.numberOfPapers = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorProviderSubjectName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPaperNumbers)).BeginInit();
            this.homePage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubjectName)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderPaperNumbers
            // 
            this.errorProviderPaperNumbers.ContainerControl = this;
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.White;
            this.homePage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homePage.Controls.Add(this.label1);
            this.homePage.Controls.Add(this.loadButton);
            this.homePage.Controls.Add(this.nameOfSubject);
            this.homePage.Controls.Add(this.nameOfSubjectInput);
            this.homePage.Controls.Add(this.numberOfPapersInput);
            this.homePage.Controls.Add(this.overallGrade);
            this.homePage.Controls.Add(this.saveButton);
            this.homePage.Controls.Add(this.generateTable);
            this.homePage.Controls.Add(this.numberOfPapers);
            this.homePage.Location = new System.Drawing.Point(4, 22);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3);
            this.homePage.Size = new System.Drawing.Size(792, 422);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home ";
            this.homePage.TextChanged += new System.EventHandler(this.generateTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "Overall Grade";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(31, 37);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(184, 74);
            this.loadButton.TabIndex = 18;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // nameOfSubject
            // 
            this.nameOfSubject.AutoSize = true;
            this.nameOfSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfSubject.Location = new System.Drawing.Point(409, 169);
            this.nameOfSubject.Name = "nameOfSubject";
            this.nameOfSubject.Size = new System.Drawing.Size(325, 46);
            this.nameOfSubject.TabIndex = 25;
            this.nameOfSubject.Text = "Name Of Subject";
            // 
            // nameOfSubjectInput
            // 
            this.nameOfSubjectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfSubjectInput.Location = new System.Drawing.Point(417, 218);
            this.nameOfSubjectInput.MaxLength = 30;
            this.nameOfSubjectInput.Name = "nameOfSubjectInput";
            this.nameOfSubjectInput.Size = new System.Drawing.Size(317, 53);
            this.nameOfSubjectInput.TabIndex = 26;
            this.nameOfSubjectInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameOfSubjectInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameOfSubjectInput_KeyPress);
            this.nameOfSubjectInput.Validating += new System.ComponentModel.CancelEventHandler(this.nameOfSubjectInput_Validating);
            // 
            // numberOfPapersInput
            // 
            this.numberOfPapersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPapersInput.Location = new System.Drawing.Point(417, 351);
            this.numberOfPapersInput.MaxLength = 2;
            this.numberOfPapersInput.Name = "numberOfPapersInput";
            this.numberOfPapersInput.Size = new System.Drawing.Size(70, 53);
            this.numberOfPapersInput.TabIndex = 24;
            this.numberOfPapersInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfPapersInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfPapersInput_KeyPress);
            this.numberOfPapersInput.Validating += new System.ComponentModel.CancelEventHandler(this.numberOfPapersInput_Validating);
            // 
            // overallGrade
            // 
            this.overallGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallGrade.Location = new System.Drawing.Point(417, 91);
            this.overallGrade.Name = "overallGrade";
            this.overallGrade.Size = new System.Drawing.Size(70, 53);
            this.overallGrade.TabIndex = 21;
            this.overallGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(31, 164);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(184, 74);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // generateTable
            // 
            this.generateTable.Location = new System.Drawing.Point(31, 297);
            this.generateTable.Name = "generateTable";
            this.generateTable.Size = new System.Drawing.Size(184, 74);
            this.generateTable.TabIndex = 20;
            this.generateTable.Text = "Create New Table";
            this.generateTable.UseVisualStyleBackColor = true;
            this.generateTable.Click += new System.EventHandler(this.generateTable_Click);
            // 
            // numberOfPapers
            // 
            this.numberOfPapers.AutoSize = true;
            this.numberOfPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPapers.Location = new System.Drawing.Point(409, 302);
            this.numberOfPapers.Name = "numberOfPapers";
            this.numberOfPapers.Size = new System.Drawing.Size(351, 46);
            this.numberOfPapers.TabIndex = 23;
            this.numberOfPapers.Text = "Number Of Papers";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.homePage);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 448);
            this.tabControl1.TabIndex = 27;
            // 
            // errorProviderSubjectName
            // 
            this.errorProviderSubjectName.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "My Grades";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPaperNumbers)).EndInit();
            this.homePage.ResumeLayout(false);
            this.homePage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubjectName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderPaperNumbers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage homePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label nameOfSubject;
        private System.Windows.Forms.TextBox nameOfSubjectInput;
        private System.Windows.Forms.TextBox numberOfPapersInput;
        private System.Windows.Forms.TextBox overallGrade;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button generateTable;
        private System.Windows.Forms.Label numberOfPapers;
        private System.Windows.Forms.ErrorProvider errorProviderSubjectName;
    }
}

