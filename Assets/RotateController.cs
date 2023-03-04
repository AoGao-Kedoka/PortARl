using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class RotateController : MonoBehaviour
{
    private void FixedUpdate()
    {
        this.gameObject.transform.Rotate(new Vector3(0, -0.5f, 0));
    }
}
