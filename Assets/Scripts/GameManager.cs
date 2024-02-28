using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance {get; private set;}
    public float GameWidth = 40f;

    private int score = 0;

   void Awake(){
        if(Instance != null && Instance != this){
            Destroy(this);
        }else{
            Instance = this;
        }
        
   }

    public void ScorePoint(){
        score++;
        Debug.Log(score);
    }

}
