using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemie();
    }

    public void MoveEnemie()
    {
        Vector3 moveDirection = Vector3.left;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
