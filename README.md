# Branch Generator
A tool for generating PowerPC branch instructions (b and bl).

Contains a Winforms and command line variant.


## Command Line Usage:
``` 
branchgen [Instruction Address] [Branch Address]

Instruction Address: The address where the instruction is.
Branch Address: The address you want to branch to.

Options:
-v or --vebrose: Gives you more detail on your command.

-bl or --link: Sets if the branch instruction is a bl (Set the link register).
```


## Gui Usage:
![GUI Image](/img/GUIExample.png "GUI Image.")

- Instruction Address: The address where the instruction is.
- Branch Address: The address you want to branch to.
- Link Instruction?: Sets if the branch instruction is a bl (Set the link register).
- Generate: Generates your instruction.
- Branch Output: Your outputed instruction in hex.