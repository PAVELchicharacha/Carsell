namespace Carsell
{
    partial class Cars
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
            System.Windows.Forms.Label dealerLabel;
            System.Windows.Forms.Label bodyLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label coastLabel;
            System.Windows.Forms.Label engineLabel;
            System.Windows.Forms.Label availableLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.label1 = new System.Windows.Forms.Label();
            this.carSellDataSet = new Carsell.CarSellDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new Carsell.CarSellDataSetTableAdapters.CarTableAdapter();
            this.tableAdapterManager = new Carsell.CarSellDataSetTableAdapters.TableAdapterManager();
            this.carBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.carBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dealerTextBox = new System.Windows.Forms.TextBox();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.coastTextBox = new System.Windows.Forms.TextBox();
            this.engineTextBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            dealerLabel = new System.Windows.Forms.Label();
            bodyLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            coastLabel = new System.Windows.Forms.Label();
            engineLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carSellDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).BeginInit();
            this.carBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dealerLabel
            // 
            dealerLabel.AutoSize = true;
            dealerLabel.Location = new System.Drawing.Point(40, 110);
            dealerLabel.Name = "dealerLabel";
            dealerLabel.Size = new System.Drawing.Size(40, 13);
            dealerLabel.TabIndex = 2;
            dealerLabel.Text = "Дилер";
            // 
            // bodyLabel
            // 
            bodyLabel.AutoSize = true;
            bodyLabel.Location = new System.Drawing.Point(40, 149);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new System.Drawing.Size(37, 13);
            bodyLabel.TabIndex = 4;
            bodyLabel.Text = "Кузов";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(40, 183);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(46, 13);
            modelLabel.TabIndex = 6;
            modelLabel.Text = "Модель";
            // 
            // coastLabel
            // 
            coastLabel.AutoSize = true;
            coastLabel.Location = new System.Drawing.Point(40, 225);
            coastLabel.Name = "coastLabel";
            coastLabel.Size = new System.Drawing.Size(33, 13);
            coastLabel.TabIndex = 8;
            coastLabel.Text = "Цена";
            // 
            // engineLabel
            // 
            engineLabel.AutoSize = true;
            engineLabel.Location = new System.Drawing.Point(38, 264);
            engineLabel.Name = "engineLabel";
            engineLabel.Size = new System.Drawing.Size(62, 13);
            engineLabel.TabIndex = 10;
            engineLabel.Text = "Двигатель";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(40, 297);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(56, 13);
            availableLabel.TabIndex = 12;
            availableLabel.Text = "Доступна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица\"Автомобили\"";
            // 
            // carSellDataSet
            // 
            this.carSellDataSet.DataSetName = "CarSellDataSet";
            this.carSellDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.carSellDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BodyTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.DealerTableAdapter = null;
            this.tableAdapterManager.EngineTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Carsell.CarSellDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carBindingNavigator
            // 
            this.carBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carBindingNavigator.BindingSource = this.carBindingSource;
            this.carBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.carBindingNavigatorSaveItem});
            this.carBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carBindingNavigator.Name = "carBindingNavigator";
            this.carBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carBindingNavigator.Size = new System.Drawing.Size(425, 25);
            this.carBindingNavigator.TabIndex = 1;
            this.carBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carBindingNavigatorSaveItem
            // 
            this.carBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carBindingNavigatorSaveItem.Image")));
            this.carBindingNavigatorSaveItem.Name = "carBindingNavigatorSaveItem";
            this.carBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.carBindingNavigatorSaveItem.Click += new System.EventHandler(this.carBindingNavigatorSaveItem_Click);
            // 
            // dealerTextBox
            // 
            this.dealerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Dealer", true));
            this.dealerTextBox.Location = new System.Drawing.Point(104, 103);
            this.dealerTextBox.Name = "dealerTextBox";
            this.dealerTextBox.Size = new System.Drawing.Size(248, 20);
            this.dealerTextBox.TabIndex = 3;
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Body", true));
            this.bodyTextBox.Location = new System.Drawing.Point(104, 142);
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(248, 20);
            this.bodyTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(104, 176);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(248, 20);
            this.modelTextBox.TabIndex = 7;
            // 
            // coastTextBox
            // 
            this.coastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Coast", true));
            this.coastTextBox.Location = new System.Drawing.Point(104, 218);
            this.coastTextBox.Name = "coastTextBox";
            this.coastTextBox.Size = new System.Drawing.Size(248, 20);
            this.coastTextBox.TabIndex = 9;
            // 
            // engineTextBox
            // 
            this.engineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Engine", true));
            this.engineTextBox.Location = new System.Drawing.Point(104, 257);
            this.engineTextBox.Name = "engineTextBox";
            this.engineTextBox.Size = new System.Drawing.Size(248, 20);
            this.engineTextBox.TabIndex = 11;
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.carBindingSource, "Available", true));
            this.availableCheckBox.Location = new System.Drawing.Point(102, 292);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(104, 24);
            this.availableCheckBox.TabIndex = 13;
            this.availableCheckBox.Text = "Да/нет";
            this.availableCheckBox.UseVisualStyleBackColor = true;
            this.availableCheckBox.CheckedChanged += new System.EventHandler(this.availableCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(159, 449);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(277, 449);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(159, 495);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Сохранить";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(53, 495);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "Таблица";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 605);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(availableLabel);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(engineLabel);
            this.Controls.Add(this.engineTextBox);
            this.Controls.Add(coastLabel);
            this.Controls.Add(this.coastTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(bodyLabel);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(dealerLabel);
            this.Controls.Add(this.dealerTextBox);
            this.Controls.Add(this.carBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carSellDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).EndInit();
            this.carBindingNavigator.ResumeLayout(false);
            this.carBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CarSellDataSet carSellDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private CarSellDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private CarSellDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton carBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dealerTextBox;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox coastTextBox;
        private System.Windows.Forms.TextBox engineTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}