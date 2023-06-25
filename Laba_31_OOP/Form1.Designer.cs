
namespace Laba_31_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.processListView = new System.Windows.Forms.ListView();
            this.infoBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.threadBtn = new System.Windows.Forms.Button();
            this.modylesBtn = new System.Windows.Forms.Button();
            this.addProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processListView
            // 
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(401, 28);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(805, 456);
            this.processListView.TabIndex = 0;
            this.processListView.UseCompatibleStateImageBehavior = false;
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(123, 259);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(138, 66);
            this.infoBtn.TabIndex = 2;
            this.infoBtn.Text = "Інформація про процес";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(123, 356);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(138, 59);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Зупинити процес";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(123, 445);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(138, 63);
            this.exportBtn.TabIndex = 4;
            this.exportBtn.Text = "Експорт";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // threadBtn
            // 
            this.threadBtn.Location = new System.Drawing.Point(123, 533);
            this.threadBtn.Name = "threadBtn";
            this.threadBtn.Size = new System.Drawing.Size(138, 65);
            this.threadBtn.TabIndex = 5;
            this.threadBtn.Text = "Потоки процесу";
            this.threadBtn.UseVisualStyleBackColor = true;
            this.threadBtn.Click += new System.EventHandler(this.threadBtn_Click);
            // 
            // modylesBtn
            // 
            this.modylesBtn.Location = new System.Drawing.Point(123, 630);
            this.modylesBtn.Name = "modylesBtn";
            this.modylesBtn.Size = new System.Drawing.Size(138, 65);
            this.modylesBtn.TabIndex = 6;
            this.modylesBtn.Text = "Модулі процесу";
            this.modylesBtn.UseVisualStyleBackColor = true;
            this.modylesBtn.Click += new System.EventHandler(this.modylesBtn_Click);
            // 
            // addProcessButton
            // 
            this.addProcessButton.Location = new System.Drawing.Point(123, 108);
            this.addProcessButton.Name = "addProcessButton";
            this.addProcessButton.Size = new System.Drawing.Size(138, 82);
            this.addProcessButton.TabIndex = 7;
            this.addProcessButton.Text = "Додати процес";
            this.addProcessButton.UseVisualStyleBackColor = true;
            this.addProcessButton.Click += new System.EventHandler(this.addProcessButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 752);
            this.Controls.Add(this.addProcessButton);
            this.Controls.Add(this.modylesBtn);
            this.Controls.Add(this.threadBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.processListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button threadBtn;
        private System.Windows.Forms.Button modylesBtn;
        private System.Windows.Forms.Button addProcessButton;
    }
}

