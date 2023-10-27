using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private List<Transform> pathObjects;
    [SerializeField] private float speed;

    private int _numPoints;
    private int _actualPoint;
    // Start is called before the first frame update
    void Start()
    {
        pathObjects.Insert(0, transform);
        _numPoints = pathObjects.Count;
        if (_numPoints == 0) enabled = false;
        _actualPoint = 0;


    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, pathObjects[_actualPoint % _numPoints].position) < 0.1f) _actualPoint++;
        transform.position = Vector3.MoveTowards(transform.position, pathObjects[_actualPoint % _numPoints].position,
            speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) other.gameObject.transform.parent = transform;
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) other.gameObject.transform.parent = null;
    }
}
