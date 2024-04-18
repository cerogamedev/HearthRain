using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour, IShape
{
    [SerializeField] private float minFallSpeed = 8;
    [SerializeField] private float maxFallSpeed = 12;
    private float fallSpeed;
    private Vector2 fallVector;

    private float destroyTime;

    private void Awake()
    {
        destroyTime = 10f;
    }
    public void Initialize()
    {
        fallSpeed = Random.Range(minFallSpeed, maxFallSpeed);
        fallVector = Vector2.down * fallSpeed * Time.deltaTime;
        Destroy(this.gameObject, destroyTime);
    }
    private void Update()
    {
        transform.Translate(fallVector);
    }
}
