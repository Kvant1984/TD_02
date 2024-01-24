using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrelControl : MonoBehaviour
{


    Transform _target;
    [SerializeField] public float _speedRotate;
    [SerializeField] public float _range;
    private float _dist;
    private Vector3 _newTarget;
    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        _dist = Vector3.Distance(_target.position, transform.position);

        if (_dist <= _range)
        {
            _newTarget = Vector3.Lerp(_newTarget, _target.transform.position, Time.deltaTime * _speedRotate);
            gameObject.transform.LookAt(_newTarget);
        }


    }

}
