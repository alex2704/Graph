namespace Граф
{
    partial class FormGraph
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
            this.btn_AddNode = new System.Windows.Forms.Button();
            this.pb_Graph = new System.Windows.Forms.PictureBox();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            this.btn_DeleteNode = new System.Windows.Forms.Button();
            this.btn_AddEdge = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.cb_GoOnNode = new System.Windows.Forms.CheckBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_DeleteEdge = new System.Windows.Forms.Button();
            this.lb_Instruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddNode
            // 
            this.btn_AddNode.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddNode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AddNode.Location = new System.Drawing.Point(720, 267);
            this.btn_AddNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddNode.Name = "btn_AddNode";
            this.btn_AddNode.Size = new System.Drawing.Size(139, 38);
            this.btn_AddNode.TabIndex = 0;
            this.btn_AddNode.Text = "Добавить узел";
            this.btn_AddNode.UseVisualStyleBackColor = false;
            this.btn_AddNode.Click += new System.EventHandler(this.btn_AddNode_Click);
            // 
            // pb_Graph
            // 
            this.pb_Graph.Location = new System.Drawing.Point(12, 10);
            this.pb_Graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Graph.Name = "pb_Graph";
            this.pb_Graph.Size = new System.Drawing.Size(1008, 503);
            this.pb_Graph.TabIndex = 1;
            this.pb_Graph.TabStop = false;
            this.pb_Graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_Graph_MouseClick);
            this.pb_Graph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Graph_MouseDown);
            this.pb_Graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Graph_MouseMove);
            this.pb_Graph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_Graph_MouseUp);
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_LoadFromFile.Location = new System.Drawing.Point(720, 27);
            this.btn_LoadFromFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(284, 80);
            this.btn_LoadFromFile.TabIndex = 4;
            this.btn_LoadFromFile.Text = "Открыть граф из файла";
            this.btn_LoadFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadFromFile.Click += new System.EventHandler(this.btn_LoadFromFile_Click);
            // 
            // btn_DeleteNode
            // 
            this.btn_DeleteNode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_DeleteNode.Location = new System.Drawing.Point(879, 267);
            this.btn_DeleteNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteNode.Name = "btn_DeleteNode";
            this.btn_DeleteNode.Size = new System.Drawing.Size(139, 38);
            this.btn_DeleteNode.TabIndex = 1;
            this.btn_DeleteNode.Text = "Удалить узел";
            this.btn_DeleteNode.UseVisualStyleBackColor = true;
            this.btn_DeleteNode.Click += new System.EventHandler(this.btn_DeleteNode_Click);
            // 
            // btn_AddEdge
            // 
            this.btn_AddEdge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AddEdge.Location = new System.Drawing.Point(720, 330);
            this.btn_AddEdge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddEdge.Name = "btn_AddEdge";
            this.btn_AddEdge.Size = new System.Drawing.Size(139, 38);
            this.btn_AddEdge.TabIndex = 2;
            this.btn_AddEdge.Text = "Добавить ребро";
            this.btn_AddEdge.UseVisualStyleBackColor = true;
            this.btn_AddEdge.Click += new System.EventHandler(this.btn_AddEdge_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Check.Location = new System.Drawing.Point(722, 126);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(283, 80);
            this.btn_Check.TabIndex = 5;
            this.btn_Check.Text = "Проверка на опосредованные знакомства";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // cb_GoOnNode
            // 
            this.cb_GoOnNode.AutoSize = true;
            this.cb_GoOnNode.Checked = true;
            this.cb_GoOnNode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_GoOnNode.Location = new System.Drawing.Point(722, 213);
            this.cb_GoOnNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_GoOnNode.Name = "cb_GoOnNode";
            this.cb_GoOnNode.Size = new System.Drawing.Size(268, 21);
            this.cb_GoOnNode.TabIndex = 6;
            this.cb_GoOnNode.Text = "Вкл/Выкл режим перемещения узла";
            this.cb_GoOnNode.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Clear.Location = new System.Drawing.Point(720, 388);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(283, 38);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Очистить граф";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_DeleteEdge
            // 
            this.btn_DeleteEdge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_DeleteEdge.Location = new System.Drawing.Point(879, 330);
            this.btn_DeleteEdge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteEdge.Name = "btn_DeleteEdge";
            this.btn_DeleteEdge.Size = new System.Drawing.Size(139, 38);
            this.btn_DeleteEdge.TabIndex = 7;
            this.btn_DeleteEdge.Text = "Удалить ребро";
            this.btn_DeleteEdge.UseVisualStyleBackColor = true;
            this.btn_DeleteEdge.Click += new System.EventHandler(this.btn_DeleteEdge_Click);
            // 
            // lb_Instruction
            // 
            this.lb_Instruction.AutoSize = true;
            this.lb_Instruction.BackColor = System.Drawing.Color.White;
            this.lb_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Instruction.ForeColor = System.Drawing.Color.Lime;
            this.lb_Instruction.Location = new System.Drawing.Point(737, 247);
            this.lb_Instruction.Name = "lb_Instruction";
            this.lb_Instruction.Size = new System.Drawing.Size(0, 18);
            this.lb_Instruction.TabIndex = 8;
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 522);
            this.Controls.Add(this.lb_Instruction);
            this.Controls.Add(this.btn_DeleteEdge);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.cb_GoOnNode);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_AddNode);
            this.Controls.Add(this.btn_AddEdge);
            this.Controls.Add(this.btn_DeleteNode);
            this.Controls.Add(this.btn_LoadFromFile);
            this.Controls.Add(this.pb_Graph);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Граф";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            this.Load += new System.EventHandler(this.FormGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNode;
        private System.Windows.Forms.PictureBox pb_Graph;
        private System.Windows.Forms.Button btn_LoadFromFile;
        private System.Windows.Forms.Button btn_DeleteNode;
        private System.Windows.Forms.Button btn_AddEdge;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.CheckBox cb_GoOnNode;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_DeleteEdge;
        private System.Windows.Forms.Label lb_Instruction;
    }
}

