using UnityEngine;
using System.Collections;

private Animator anim;
public float speed = 1.5f;
private Vector3 target;
private Vector3 MousePosition;
private Vector3 PlayerPosition;
void Start()
{
    anim = GetComponent<Animator>();
    target = transform.position;
}
void Update()
{
    if (Input.GetMouseButtonDown(0))
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = transform.position.x;
        Debug.Log("traaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" + target.z);
        if (target.x <= target.z)
        {
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetInteger("Direction", 1);
        }
        else if (target.x >= target.z)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetInteger("Direction", 1);
        }
    }
    transform.position = Vector3.MoveTowards(transform.position, target, speedTime.deltaTime);
}
     }