using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bagScale : MonoBehaviour
{
    public GameObject bagCorrect;
    public GameObject bagWrong;
    public GameObject currentWeight;

    int weigh = 0;

    bool bagCorrectCollition = false;

    // Start is called before the first frame update
    void Start()
    {
        bagCorrect.SetActive(false);
        bagWrong.SetActive(false);
        bagCorrectCollition = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the passport by checking its name
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "bagCorrect")
        {   
            weigh = 13;
            bagCorrect.SetActive(true);
            bagWrong.SetActive(false);
            setWeight();
        }
        if (collision.gameObject.name == "bag1"){
            weigh = 16;
            bagWrong.SetActive(true);
            bagCorrect.SetActive(false);
            setWeight();
        }
        if (collision.gameObject.name == "bag2"){
            weigh = 18;
            bagWrong.SetActive(true);
            bagCorrect.SetActive(false);
            setWeight();
        }
        if (collision.gameObject.name == "bag3"){
            weigh = 20;
            bagWrong.SetActive(true);
            bagCorrect.SetActive(false);
            setWeight();
        }
       

    }

    private void setWeight(){
        TextMeshProUGUI textMesh = currentWeight.GetComponent<TextMeshProUGUI>();

        if(textMesh != null){
            textMesh.text = weigh.ToString() + " kg";
        }else{
            Debug.Log("textMesh is null");
        }

    }
}
