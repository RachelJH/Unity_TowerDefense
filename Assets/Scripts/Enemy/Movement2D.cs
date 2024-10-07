using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0.0f;
    [SerializeField]
    private Vector3 moveDrirection = Vector3.zero;
    private float baseMoveSpeed;
   
    public float MoveSpeed
    {
        set =>moveSpeed = Mathf.Max(0,value);
        get => moveSpeed;
    }

    private void Awake()
    {
        baseMoveSpeed = moveSpeed;
    }
    private void Update()
    {
        transform.position += moveDrirection * moveSpeed * Time.deltaTime;
    }

    public void MoveTo(Vector3 directrion)
    {
        moveDrirection = directrion;
    }

    public void ResetMoveSpeed()
    {
        moveSpeed = baseMoveSpeed;
    }

}
