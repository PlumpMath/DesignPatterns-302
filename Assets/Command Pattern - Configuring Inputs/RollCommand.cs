using UnityEngine;
using System.Collections;

class RollCommand : Command
{
    public override void Execute()
    {
        Roll();
    }

    void Roll()
    {
        System.Console.WriteLine("Call Roll");
    }
}