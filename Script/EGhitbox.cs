using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EGhitbox : MonoBehaviour
{
    public float radius = 3f;
    public Transform player;
    public Transform ghost;
    bool hasIneract = false;

    public GameObject redscreen;
    


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    private void Update()
    {
    }

    /*private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(ghost.position, radius);
    }*/
}
