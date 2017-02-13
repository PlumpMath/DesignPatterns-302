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
        GenericUIManager.ChangeText(this.GetType().Name);
        GenericUIManager.SetTextColor(Color.red);
    }
}
