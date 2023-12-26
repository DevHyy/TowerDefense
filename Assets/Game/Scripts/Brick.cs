using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
   [SerializeField] private BrickType brickType;
   private enum BrickType
   {
      Use,
      CantUse
   }


   private void Update()
   {
      CheckDataBrick();
   }
   
   private bool CheckDataBrick()
   {
      RaycastHit raycastHit;
      if(Physics.Raycast(transform.position, Vector3.up, out raycastHit, 1f))
      {
         if(raycastHit.collider.gameObject.CompareTag(Constans.Tag_Player))
         {
            return true;
         } else if (raycastHit.collider.gameObject.CompareTag(Constans.Tag_Tower))
         {
            return true;
         }
      }
      return false;
   }
}
