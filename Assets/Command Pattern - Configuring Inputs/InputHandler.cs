using UnityEngine;
using System.Collections;

class InputHandler : MonoBehaviour
{
    Command button_X = new JumpCommand();
    Command button_Y = new FireCommand();
    Command button_A = new PunchCommand();
    Command button_B = new RollCommand();

    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.GetButtonDown("BUTTON_X"))        button_X.Execute();
        else if (Input.GetButtonDown("BUTTON_Y"))   button_Y.Execute();
        else if (Input.GetButtonDown("BUTTON_A"))   button_A.Execute();
        else if (Input.GetButtonDown("BUTTON_B"))   button_B.Execute();
    }
}
