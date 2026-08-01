namespace BranchGeneratorGUI
{
    partial class BranchGenWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LinkInstruction = new CheckBox();
            InstructionAddrLabel = new Label();
            label1 = new Label();
            OGInstructionTextBox = new TextBox();
            BranchToAddressTextBox = new TextBox();
            label2 = new Label();
            OutputTxt = new TextBox();
            GenButton = new Button();
            SuspendLayout();
            // 
            // LinkInstruction
            // 
            LinkInstruction.AutoSize = true;
            LinkInstruction.Location = new Point(12, 70);
            LinkInstruction.Name = "LinkInstruction";
            LinkInstruction.Size = new Size(113, 19);
            LinkInstruction.TabIndex = 0;
            LinkInstruction.Text = "Link Instruction?";
            LinkInstruction.UseVisualStyleBackColor = true;
            // 
            // InstructionAddrLabel
            // 
            InstructionAddrLabel.AutoSize = true;
            InstructionAddrLabel.Location = new Point(12, 9);
            InstructionAddrLabel.Name = "InstructionAddrLabel";
            InstructionAddrLabel.Size = new Size(132, 15);
            InstructionAddrLabel.TabIndex = 1;
            InstructionAddrLabel.Text = "OG Instruction Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Branch To Address:";
            // 
            // OGInstructionTextBox
            // 
            OGInstructionTextBox.Location = new Point(142, 6);
            OGInstructionTextBox.Name = "OGInstructionTextBox";
            OGInstructionTextBox.Size = new Size(107, 23);
            OGInstructionTextBox.TabIndex = 3;
            // 
            // BranchToAddressTextBox
            // 
            BranchToAddressTextBox.Location = new Point(142, 35);
            BranchToAddressTextBox.Name = "BranchToAddressTextBox";
            BranchToAddressTextBox.Size = new Size(107, 23);
            BranchToAddressTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 5;
            label2.Text = "Branch Output:";
            // 
            // OutputTxt
            // 
            OutputTxt.Location = new Point(142, 101);
            OutputTxt.Name = "OutputTxt";
            OutputTxt.Size = new Size(107, 23);
            OutputTxt.TabIndex = 6;
            // 
            // GenButton
            // 
            GenButton.Location = new Point(142, 67);
            GenButton.Name = "GenButton";
            GenButton.Size = new Size(107, 23);
            GenButton.TabIndex = 7;
            GenButton.Text = "Generate";
            GenButton.UseVisualStyleBackColor = true;
            GenButton.Click += GenButton_Click;
            // 
            // BranchGenWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 143);
            Controls.Add(GenButton);
            Controls.Add(OutputTxt);
            Controls.Add(label2);
            Controls.Add(BranchToAddressTextBox);
            Controls.Add(OGInstructionTextBox);
            Controls.Add(label1);
            Controls.Add(InstructionAddrLabel);
            Controls.Add(LinkInstruction);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BranchGenWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Branch Generator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox LinkInstruction;
        private Label InstructionAddrLabel;
        private Label label1;
        private TextBox OGInstructionTextBox;
        private TextBox BranchToAddressTextBox;
        private Label label2;
        private TextBox OutputTxt;
        private Button GenButton;
    }
}
