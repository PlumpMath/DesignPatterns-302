using UnityEngine;
using System.Collections;

class FireCommand : Command
{
    public override void Execute()
    {
        Fire();
    }

    void Fire()
    {
        System.Console.WriteLine("Call Fire");
    }
}
