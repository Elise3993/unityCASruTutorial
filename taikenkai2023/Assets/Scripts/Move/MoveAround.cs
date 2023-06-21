using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    // 円運動を起こすスクリプト

    [SerializeField] private Vector3 _centerPoint = Vector3.zero;

    private Vector3 _axis = Vector3.forward;

    [SerializeField] private float _period = 3;

    private void Update()
    {
        transform.RotateAround(
            _centerPoint,
            _axis,
            360 / _period * Time.deltaTime
        );
    }
}
