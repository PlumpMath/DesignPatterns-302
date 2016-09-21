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
        Command command = HandleInput();

        if(command != null)
            command.Execute(this.gameObject);
      
    }

    Command HandleInput()
    {
        if      (Input.GetButtonDown("X Button"))   return button_X;
        else if (Input.GetButtonDown("Y Button"))   return button_Y;
        else if (Input.GetButtonDown("A Button"))   return button_A;
        else if (Input.GetButtonDown("B Button"))   return button_B;

        return null;
    }
}
