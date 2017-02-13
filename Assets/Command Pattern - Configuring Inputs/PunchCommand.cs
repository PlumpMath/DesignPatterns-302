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
        GenericUIManager.ChangeText(this.GetType().Name);
        GenericUIManager.SetTextColor(Color.cyan);
    }
}
