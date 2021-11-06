using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerID{
    Player0,
    Player1,
    Player2,
    Player3

}

public class WinnitronDirectionalInput : DirectionalInput {

    public PlayerID playerSelected = PlayerID.Player0;


    // Update is called once per frame
    void Update() {
        if( playerSelected == PlayerID.Player0){
            inputVector.x = Input.GetAxis("Winn_Horizontal_P0");
            inputVector.y = Input.GetAxis("Winn_Vertical_P0");
        }else if(playerSelected == PlayerID.Player1) {
            inputVector.x = Input.GetAxis("Winn_Horizontal_P1");
            inputVector.y = Input.GetAxis("Winn_Vertical_P1");
        } else if (playerSelected == PlayerID.Player2) {
            inputVector.x = Input.GetAxis("Winn_Horizontal_P2");
            inputVector.y = Input.GetAxis("Winn_Vertical_P2");
        } else if (playerSelected == PlayerID.Player3) {
            inputVector.x = Input.GetAxis("Winn_Horizontal_P3");
            inputVector.y = Input.GetAxis("Winn_Vertical_P3");
        }
    }
}
