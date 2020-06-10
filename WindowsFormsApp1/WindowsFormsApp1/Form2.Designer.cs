namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.Label semesterLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label markLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label surnameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ratingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ratingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.fKRatingToRatingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKRatingToRatingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKRatingToRatingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKRatingToRatingBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.groupToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet1();
            this.ratingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ratingTableAdapter = new WindowsFormsApp1.Database1DataSet1TableAdapters.RatingTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSet1TableAdapters.TableAdapterManager();
            this.studentsTableAdapter = new WindowsFormsApp1.Database1DataSet1TableAdapters.StudentsTableAdapter();
            this.fKRatingToRatingBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            semesterLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            markLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingNavigator)).BeginInit();
            this.ratingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource3)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // semesterLabel
            // 
            semesterLabel.AutoSize = true;
            semesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            semesterLabel.Location = new System.Drawing.Point(22, 126);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new System.Drawing.Size(86, 20);
            semesterLabel.TabIndex = 3;
            semesterLabel.Text = "Semester:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            subjectLabel.Location = new System.Drawing.Point(22, 172);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(70, 20);
            subjectLabel.TabIndex = 5;
            subjectLabel.Text = "Subject:";
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            markLabel.Location = new System.Drawing.Point(22, 218);
            markLabel.Name = "markLabel";
            markLabel.Size = new System.Drawing.Size(51, 20);
            markLabel.TabIndex = 7;
            markLabel.Text = "Mark:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.Location = new System.Drawing.Point(22, 264);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(50, 20);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(22, 80);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(81, 20);
            surnameLabel.TabIndex = 11;
            surnameLabel.Text = "Surname:";
            // 
            // ratingBindingNavigator
            // 
            this.ratingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ratingBindingNavigator.BindingSource = this.ratingBindingSource;
            this.ratingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ratingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ratingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ratingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ratingBindingNavigatorSaveItem});
            this.ratingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ratingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ratingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ratingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ratingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ratingBindingNavigator.Name = "ratingBindingNavigator";
            this.ratingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ratingBindingNavigator.Size = new System.Drawing.Size(417, 27);
            this.ratingBindingNavigator.TabIndex = 0;
            this.ratingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ratingBindingNavigatorSaveItem
            // 
            this.ratingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ratingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ratingBindingNavigatorSaveItem.Image")));
            this.ratingBindingNavigatorSaveItem.Name = "ratingBindingNavigatorSaveItem";
            this.ratingBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ratingBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ratingBindingNavigatorSaveItem.Click += new System.EventHandler(this.ratingBindingNavigatorSaveItem_Click);
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "Semester", true));
            this.semesterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.semesterTextBox.Location = new System.Drawing.Point(126, 119);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(172, 27);
            this.semesterTextBox.TabIndex = 4;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "Subject", true));
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectTextBox.Location = new System.Drawing.Point(126, 165);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(172, 27);
            this.subjectTextBox.TabIndex = 6;
            // 
            // markTextBox
            // 
            this.markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "Mark", true));
            this.markTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markTextBox.Location = new System.Drawing.Point(126, 211);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(172, 27);
            this.markTextBox.TabIndex = 8;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ratingBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(126, 257);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(184, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Students";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Surname", true));
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(126, 80);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(172, 27);
            this.surnameTextBox.TabIndex = 12;
            // 
            // fKRatingToRatingBindingSource
            // 
            this.fKRatingToRatingBindingSource.DataMember = "FK_Rating_ToRating";
            this.fKRatingToRatingBindingSource.DataSource = this.studentsBindingSource;
            // 
            // fKRatingToRatingBindingSource1
            // 
            this.fKRatingToRatingBindingSource1.DataMember = "FK_Rating_ToRating";
            this.fKRatingToRatingBindingSource1.DataSource = this.studentsBindingSource;
            // 
            // fKRatingToRatingBindingSource2
            // 
            this.fKRatingToRatingBindingSource2.DataMember = "FK_Rating_ToRating";
            this.fKRatingToRatingBindingSource2.DataSource = this.studentsBindingSource;
            // 
            // fKRatingToRatingBindingSource3
            // 
            this.fKRatingToRatingBindingSource3.DataMember = "FK_Rating_ToRating";
            this.fKRatingToRatingBindingSource3.DataSource = this.studentsBindingSource;
            // 
            // groupToolStripLabel
            // 
            this.groupToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupToolStripLabel.Name = "groupToolStripLabel";
            this.groupToolStripLabel.Size = new System.Drawing.Size(142, 27);
            this.groupToolStripLabel.Text = "Поиск по группе";
            // 
            // groupToolStripTextBox
            // 
            this.groupToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupToolStripTextBox.Name = "groupToolStripTextBox";
            this.groupToolStripTextBox.Size = new System.Drawing.Size(100, 30);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(62, 27);
            this.fillByToolStripButton.Text = "Поиск";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripLabel,
            this.groupToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(417, 30);
            this.fillByToolStrip.TabIndex = 14;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ratingBindingSource
            // 
            this.ratingBindingSource.DataMember = "Rating";
            this.ratingBindingSource.DataSource = this.database1DataSet1;
            // 
            // ratingTableAdapter
            // 
            this.ratingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RatingTableAdapter = this.ratingTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // fKRatingToRatingBindingSource4
            // 
            this.fKRatingToRatingBindingSource4.DataMember = "FK_Rating_ToRating";
            this.fKRatingToRatingBindingSource4.DataSource = this.studentsBindingSource;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(markLabel);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(semesterLabel);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(this.ratingBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingNavigator)).EndInit();
            this.ratingBindingNavigator.ResumeLayout(false);
            this.ratingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource3)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRatingToRatingBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource ratingBindingSource;
        private Database1DataSet1TableAdapters.RatingTableAdapter ratingTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ratingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ratingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox semesterTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button button1;
        private Database1DataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.BindingSource fKRatingToRatingBindingSource;
        private System.Windows.Forms.BindingSource fKRatingToRatingBindingSource1;
        private System.Windows.Forms.BindingSource fKRatingToRatingBindingSource2;
        private System.Windows.Forms.BindingSource fKRatingToRatingBindingSource3;
        private System.Windows.Forms.ToolStripLabel groupToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox groupToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.BindingSource fKRatingToRatingBindingSource4;
    }
}