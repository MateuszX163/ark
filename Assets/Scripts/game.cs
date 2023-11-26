using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;

    // Use this for initialization
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        float mouseposinunits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlepos = new Vector2(transform.position.x, transform.position.y);
        paddlepos.x = Mathf.Clamp(mouseposinunits, minX, maxX);
        transform.position = paddlepos;
    }
}
