using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thieve : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;
    [SerializeField] private int _speed;
    private Transform _target;

    private void Start()
    {
        _target = _endPoint;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, Time.deltaTime * _speed);
        if(transform.position == _endPoint.position)
        {
            _target = _startPoint;
        }
        else if (transform.position == _startPoint.position)
        {
            _target = _endPoint;
        }
    }
}
