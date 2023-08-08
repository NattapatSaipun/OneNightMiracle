using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractObject : MonoBehaviour
{
    public float radius = 3f;
    public Transform player;
    public Transform interactItem;
    bool hasIneract = false;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, interactItem.position);
        if(distance <= radius && !hasIneract)
        {
            text.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                text.enabled = false;
                hasIneract = true;
                Interact();
            }
            
        }else text.enabled = false;
    }
    public virtual void Interact()
    {

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactItem.position, radius);
    }
}
