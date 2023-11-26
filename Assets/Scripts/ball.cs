using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Burst.Intrinsics.X86.Avx;

public class ball : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tmp;
    [SerializeField] Int16 i = 0;
    [SerializeField] bool startGame = false;
    private void OnCollisionEnter2D(Collision2D obj) { 

        if (obj.gameObject.CompareTag("Block")){
            i++;
            Destroy(obj.gameObject);
            tmp.text = "Score: "+i;
        }
        if(i == 5) {
            SceneManager.LoadScene(1);
        }
    }
    private void Update()
    {
        if (startGame == false) {
            if (Input.GetKeyDown(KeyCode.A)){
                startGame = true;
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 15, 0);
            }
        }

    }
}
