using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject redObj;
       
    [SerializeField] 
    private GameObject blueObj;

    void Start()
    {

        Application.targetFrameRate = 60;
        GameObject redInstance = Instantiate(redObj, new Vector3(2f,0f,0f), Quaternion.identity);

        GameObject blueInstance = Instantiate(blueObj, new Vector3(-2f,0f,0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
