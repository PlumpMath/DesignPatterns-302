using UnityEngine;
using System.Collections;

class PunchCommand : Command
{
    public override void Execute()
    {
        Punch();
    }

    void Punch()
    {
        System.Console.WriteLine("Call Punch");
    }
}
