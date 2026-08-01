using System.Globalization;
using BranchGeneratorLib;

namespace branchgen_cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("TODO: Help text");
                return;
            }

            ulong instructionAddr = PPCBranchUtils.ParseHexAddressString(args[0]);
            ulong branchAddr = PPCBranchUtils.ParseHexAddressString(args[1]);
            bool vebrose = false;
            bool branchLink = false;

            if (args.Length >= 3)
            {
                for (int i = 0; i < args.Length - 2; i++)
                {
                    string curArg = args[i + 2];

                    if (curArg == "-v" || curArg == "--verbrose")
                    {
                        vebrose = true;
                    }

                    if (curArg == "-bl" || curArg == "--link")
                    {
                        branchLink = true;
                    }
                }
            }


            if (vebrose)
            {
                Console.WriteLine("Branch Info:");
                Console.WriteLine("Instruction Address: " + instructionAddr.ToString("X"));
                Console.WriteLine("Branch Location Address: " + branchAddr.ToString("X"));

                string branchDirection = (instructionAddr > branchAddr) ? "Backward" : "Forward";

                Console.WriteLine("Branch Direction: " + branchDirection);
                Console.WriteLine("Is Branch with Link? " + branchLink);
                Console.WriteLine("");
            }

            ulong branchInstruction = PPCBranchUtils.GenerateBranch(instructionAddr, branchAddr, branchLink);


            string branchInstructionStr = branchInstruction.ToString("X");

            if (vebrose) branchInstructionStr = "Branch Instruction: " + branchInstructionStr;

            Console.WriteLine(branchInstructionStr);
        }
    }
}
