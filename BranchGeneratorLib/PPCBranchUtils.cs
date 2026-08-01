using System.Globalization;

namespace BranchGeneratorLib
{
    public class PPCBranchUtils
    {
        /// <summary>
        /// Takes a string of a hex address and converts into a PowerPC compatible address (ulong)
        /// </summary>
        /// <param name="addressStr">The string of your address.</param>
        /// <returns>A unsigned 64-bit integer equivalent to your address string.</returns>
        /// 
        public static ulong ParseHexAddressString(string addressStr)
        {
            if (addressStr != "")
            {
                if (addressStr.StartsWith("0x"))
                {
                    addressStr = addressStr.Substring(2);
                }
                return UInt64.Parse(addressStr, NumberStyles.HexNumber);
            }

            return 0;
        }

        static ulong GenerateBranchForward(ulong baseAddr, ulong branchAddr, bool isBranchLink)
        {
            ulong branchInstruction = 0x48000000; // Base Forward

            branchInstruction += (branchAddr - baseAddr);
            if (isBranchLink) branchInstruction++;


            return branchInstruction;
        }

        static ulong GenerateBranchBackward(ulong baseAddr, ulong branchAddr, bool isBranchLink)
        {
            ulong branchInstruction = 0x4B000000; // Base Backward

            ulong branchDiff = (baseAddr - branchAddr);

            branchInstruction += (0x1000000 - branchDiff);

            if (isBranchLink) branchInstruction++;

            return branchInstruction;
        }

        public static ulong GenerateBranch(ulong baseAddr, ulong branchAddr, bool isBranchLink)
        {
            if (baseAddr > branchAddr)
            {
                return GenerateBranchBackward(baseAddr, branchAddr, isBranchLink);
            }

            return GenerateBranchForward(baseAddr, branchAddr, isBranchLink);
        }
    }
}
