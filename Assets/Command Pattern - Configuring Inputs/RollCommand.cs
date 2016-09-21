using UnityEngine;
using System.Collections;

class RollCommand : Command
{
    public override void Execute(GameObject actor)
    {
        Roll(actor);
    }

    void Roll(GameObject actor)
    {
        Debug.Log(actor.name + " is calling Roll");
    }
}