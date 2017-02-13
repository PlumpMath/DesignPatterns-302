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
        GenericUIManager.ChangeText(this.GetType().Name);
        GenericUIManager.SetTextColor(Color.green);
    }
}
