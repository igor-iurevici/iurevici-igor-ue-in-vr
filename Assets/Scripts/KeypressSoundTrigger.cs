using System.Collections; 
 using System.Collections.Generic; 
 using UnityEngine;
 
 public class KeypressSoundTrigger : MonoBehaviour {
 
  public AudioSource suggestRecipes1;
  public AudioSource wasteWarning2;
  public AudioSource groceryOrdering3;

  // Update is called once per frame
  void Update () {
         if (Input.GetKeyDown(KeyCode.Alpha1)) {
             if(!suggestRecipes1.isPlaying &&
                     !wasteWarning2.isPlaying &&
                     !groceryOrdering3.isPlaying) {
                 suggestRecipes1.Play();
             }
         }
      
         if (Input.GetKeyDown(KeyCode.Alpha2)) {
             if(!suggestRecipes1.isPlaying &&
                     !wasteWarning2.isPlaying &&
                     !groceryOrdering3.isPlaying) {
                 wasteWarning2.Play();
             }
         }


         if (Input.GetKeyDown(KeyCode.Alpha3)) {
             if(!suggestRecipes1.isPlaying &&
                     !wasteWarning2.isPlaying &&
                     !groceryOrdering3.isPlaying) {
                 groceryOrdering3.Play();
             }
         }
     }
 }
