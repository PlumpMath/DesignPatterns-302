using UnityEngine;
using System.Collections;

class JumpCommand : Command
{
    public override void Execute(GameObject actor)
    {
        Jump(actor);
    }

    void Jump(GameObject actor)
    {
       Debug.Log(actor.name + " is calling Jump");
    }
}
