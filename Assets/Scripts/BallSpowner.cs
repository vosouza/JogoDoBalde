using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpowner : MonoBehaviour
{

    public float Interval = 2f;
    public float Cooldown = 0f;
    public Vector3 originPoint = new Vector3(0,15,9);
    public List<GameObject> prefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown -= Time.deltaTime;
        if(Cooldown <= 0f){
            Cooldown = Interval;
            SpawnBall();
        }
    }

    private void SpawnBall(){
        var index = Random.Range(0, prefabs.Count);
        GameObject prefab = prefabs[index];

        float gameWidth = GameManager.Instance.GameWidth;
        float xOffset = Random.Range(-gameWidth/2f, gameWidth/2f);

        Vector3 position = originPoint + new Vector3(xOffset, 0,0);
        var rotation = prefab.transform.rotation;

        Instantiate(prefab, position, rotation);
    }
}
