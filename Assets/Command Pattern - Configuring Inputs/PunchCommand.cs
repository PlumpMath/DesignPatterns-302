using UnityEngine;
using System.Collections;

class PunchCommand : Command
{
    public override void Execute(GameObject actor)
    {
        Punch(actor);
    }

    void Punch(GameObject actor)
    {
       Debug.Log(actor.name + " is calling Punch");
    }
}
