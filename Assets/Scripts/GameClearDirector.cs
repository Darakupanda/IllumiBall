using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDirector : MonoBehaviour
{
    public Hole holeRed;
    public Hole holeBule;
    public Hole holeGreen;
    public GameObject msg;

    void Update() {
        if(holeRed.IsHolding() && holeBule.IsHolding() && holeGreen.IsHolding()){
            msg.SetActive(true);
        }else{
            msg.SetActive(false);
        }
    }
}
