using UnityEngine;
using System.Collections;

class FireCommand : Command
{
    public override void Execute(GameObject actor)
    {
        Fire(actor);
    }

    void Fire(GameObject actor)
    {
        Debug.Log(actor.name + " is calling Fire");
    }
}
