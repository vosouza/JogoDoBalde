using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 10f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool inputA = Input.GetKey(KeyCode.A);
        bool inputB = Input.GetKey(KeyCode.D);

        if(inputA == inputB) return;

        float movement = Speed * Time.deltaTime;
        if(inputA == true){
            movement *= -1f;
        }
        transform.position += new Vector3(movement, 0, 0);

        float movementLimit = GameManager.Instance.GameWidth / 2f;
        if(transform.position.x < -movementLimit){
            transform.position = new Vector3(-movementLimit,transform.position.y,transform.position.z);
        }else if(transform.position.x > movementLimit){
            transform.position = new Vector3(movementLimit,transform.position.y,transform.position.z);    
        }
    }
}
