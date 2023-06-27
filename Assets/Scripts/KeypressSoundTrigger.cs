using System.Collections; 
 using System.Collections.Generic; 
 using UnityEngine;
 
 public class KeypressSoundTrigger : MonoBehaviour {
 
  public AudioSource suggestRecipes1;
  public AudioSource selectionRecipe2;
  public AudioSource confirmationRecipe3;
  public AudioSource groceryOrdering4;

  // Update is called once per frame
  void Update () {
         if (Input.GetKeyDown(KeyCode.Alpha1)) {
             if(!suggestRecipes1.isPlaying &&
                     !selectionRecipe2.isPlaying &&
                     !confirmationRecipe3.isPlaying &&
                     !groceryOrdering4.isPlaying) {
                 suggestRecipes1.Play();
             }
         }
      
         if (Input.GetKeyDown(KeyCode.Alpha2)) {
             if(!suggestRecipes1.isPlaying &&
                     !selectionRecipe2.isPlaying &&
                     !confirmationRecipe3.isPlaying &&
                     !groceryOrdering4.isPlaying) {
                 selectionRecipe2.Play();
             }
         }


         if (Input.GetKeyDown(KeyCode.Alpha3)) {
             if(!suggestRecipes1.isPlaying &&
                     !selectionRecipe2.isPlaying &&
                     !confirmationRecipe3.isPlaying &&
                     !groceryOrdering4.isPlaying) {
                 confirmationRecipe3.Play();
             }
         }

         if (Input.GetKeyDown(KeyCode.Alpha4)) {
             if(!suggestRecipes1.isPlaying &&
                     !selectionRecipe2.isPlaying &&
                     !confirmationRecipe3.isPlaying &&
                     !groceryOrdering4.isPlaying) {
                 groceryOrdering4.Play();
             }
         }
     }
 }
