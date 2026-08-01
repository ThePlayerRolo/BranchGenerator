using BranchGeneratorLib; 

namespace BranchGeneratorGUI
{
    public partial class BranchGenWindow : Form
    {
        public BranchGenWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            ulong instructionAddr = PPCBranchUtils.ParseHexAddressString(OGInstructionTextBox.Text);
            ulong branchAddr = PPCBranchUtils.ParseHexAddressString(BranchToAddressTextBox.Text);
            
            ulong branchResult = PPCBranchUtils.GenerateBranch(instructionAddr, branchAddr, LinkInstruction.Checked);

            OutputTxt.Text = branchResult.ToString("X");
        }
    }
}
