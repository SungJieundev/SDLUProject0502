using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBase : MonoBehaviour
{
    protected virtual void Dead()
    {
        Debug.Log("????");
        Destroy(gameObject);
    }
}
