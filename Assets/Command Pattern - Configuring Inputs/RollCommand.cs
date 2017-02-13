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
        GenericUIManager.ChangeText(this.GetType().Name);
        GenericUIManager.SetTextColor(Color.yellow);
    }
}