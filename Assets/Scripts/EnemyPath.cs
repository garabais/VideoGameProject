﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyPath : MonoBehaviour
{
    /*
    public Node[] path;
    private int actual;
    
    private bool going;
    
    */

    private Node prev;
    public float speed = .5f; 
    public float d = 0.01f;

    private Node current;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] nodes = GameObject.FindGameObjectsWithTag("Node");
        float distance = Mathf.Infinity;
    
        foreach(GameObject g in nodes){
            float curdistance = Vector3.Distance(g.transform.position, transform.position);
            if(curdistance<distance){
                distance = curdistance;
                prev = current;
                current = g.GetComponent<Node>();
            }
        }
    }

    void Update() {
        
        Vector3 x = current.transform.position - transform.position;
        transform.Translate(x.normalized * Time.deltaTime * speed, Space.World);
        if(Vector3.Distance(current.transform.position, transform.position) < d){ 
            int i = Random.Range(0,current.neighbors.Length);
            if(current.neighbors.Length > 0) {
                prev = current;
                current = current.neighbors[i];
            } else {
                current = prev; 
            }
            
        };

    }




    /*
    // Update is called once per frame
    void Update()
    {

        if(actual + 1 >= path.Length && going){
            going = false;
        }


        //    if(actual + 1 < path.Length && going){
           // going = true; 
        // }

        if(actual - 1 < 0 && !going){
            going = true;
        }

        if(going)
        {
            if(Vector3.Distance(path[actual].transform.position, transform.position) < d){ actual++; };
            transform.LookAt(path[actual].transform);
            transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
        }else
        {
            if(Vector3.Distance(path[actual].transform.position, transform.position) < d){ actual--; };
            transform.LookAt(path[actual].transform);
            transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
        }
    }
    */
}
