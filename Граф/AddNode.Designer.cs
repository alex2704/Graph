namespace Граф
{
    partial class AddNode
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
            this.btn_AddNode = new System.Windows.Forms.Button();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_AddNode
            // 
            this.btn_AddNode.Location = new System.Drawing.Point(12, 55);
            this.btn_AddNode.Name = "btn_AddNode";
            this.btn_AddNode.Size = new System.Drawing.Size(210, 38);
            this.btn_AddNode.TabIndex = 1;
            this.btn_AddNode.Text = "Добавить";
            this.btn_AddNode.UseVisualStyleBackColor = true;
            this.btn_AddNode.Click += new System.EventHandler(this.btn_AddNode_Click);
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(12, 12);
            this.tb_Input.Multiline = true;
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(210, 37);
            this.tb_Input.TabIndex = 0;
            // 
            // AddNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 105);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.btn_AddNode);
            this.Name = "AddNode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNode;
        private System.Windows.Forms.TextBox tb_Input;
    }
}