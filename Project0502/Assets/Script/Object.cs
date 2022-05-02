using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : EntityBase
{
    Collider2D col2d;
    [SerializeField] LayerMask player;
    private bool d;

    void Start()
    {
        col2d = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsNear())
        {
            Dead();
        }
    }

    //(IsNear() == true) == IsNear() 
    //(IsNear() == false) == !IsNear()
    private bool IsNear()
    {

        //d = Physics2D.OverlapBox(transform.position, col2d.bounds.size, 0, player);
        //return d; 
        return Physics2D.OverlapBox(transform.position, col2d.bounds.size, 0, player);//������Ʈ�� �ݶ��̴��� �÷��̾� ���̾�� �浹���� �� true�� ��ȯ
    }

}
