using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
 
 public class ShowOnKeypress : MonoBehaviour {
 
  public GameObject toShow;

  // Update is called once per frame
  void Update () {
         if (Input.GetKeyDown(KeyCode.Alpha5)) {
             toShow.SetActive(true);
         }
     }
 }
