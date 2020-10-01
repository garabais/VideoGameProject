using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    public Node[] neighbors;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos(){
        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(transform.position, 0.4f);  

        Gizmos.color = Color.yellow;
        for(int i=0; i<neighbors.Length; i++){
            if(neighbors[i] == null){
                continue;
            }
            Gizmos.DrawLine(transform.position, neighbors[i].transform.position);
        }
    }
}
