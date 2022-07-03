using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public TMP_Text _appleCounter;
    public int _treePrice = 5;
    int _appleCount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (hit.collider.gameObject == null)
                    return;
                Debug.Log("Hit = " + hit.collider.gameObject.name);

                if (hit.collider.name.Contains("Apple"))
                {
                    _appleCount++;
                    _appleCounter.text = _appleCount.ToString();
                    Destroy(hit.collider.gameObject);
                    
                }

                //if(hit.collider.name.Contains("Floor") && _appleCount >= _treePrice)
                //{
                //    _appleCount -= _treePrice;
                //    Vector3 pointPosition = hit.point;
                //    GameObject tree = Instantiate(Resources.Load("Tree"), pointPosition, Quaternion.identity) as GameObject;
                //}
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit1;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit1))
            {
                if (hit1.collider.gameObject == null)
                    return;
                Debug.Log("Hit1 = " + hit1.collider.gameObject.name);

                if (hit1.collider.name.Contains("Floor") && _appleCount >= _treePrice)
                {
                    _appleCount -= _treePrice;
                    _appleCounter.text = _appleCount.ToString();
                    Vector3 pointPosition = hit1.point;
                    GameObject tree = Instantiate(Resources.Load("Tree"), pointPosition, Quaternion.identity) as GameObject;
                }
            }
        }
    }
}
