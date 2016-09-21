using UnityEngine;
using System.Collections;

class JumpCommand : Command
{
    public override void Execute()
    {
        Jump();
    }

    void Jump()
    {
        System.Console.WriteLine("Call Jump");
    }
}
