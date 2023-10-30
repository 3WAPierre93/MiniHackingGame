using UnityEngine;

#region Script shoot
public class Shooting : MonoBehaviour
{
    //gameObject qui servira de projectile 
    public GameObject bulletPreFab;
    //Un transform utilis� pour localiser l'endroit d'apparition du projectile
    public Transform newBulletPositionTransform;
    //Un transform pour regrouper les projectiles ensemble 
    public Transform newBulletGroupTransform;
    void Update()
    {
       bool shootPressed = Input.GetButtonDown("Shoot");
       if (shootPressed)
       {
        Debug.Log("Shoot ! ");

            //1 Cr�ation du clone
            GameObject newBulletRef = Object.Instantiate(bulletPreFab);

            //2 le parent est un transform qui sera utilis� pour la position
            newBulletRef.transform.parent = newBulletPositionTransform;

            //3 La position est mise � 0 0 0, par rapport � son parent 
            //localPosition est la position relative au parent 
            newBulletRef.transform.localPosition = Vector3.zero;

            //3.5 on s'aligne par rapport au parent 
            newBulletRef.transform.rotation = transform.rotation;

            //4 on enl�ve le parent pour ne plus l'avoir dans le "player"
            //(sinon le projectile en m�me temps que le parent)
            newBulletRef.transform.parent = newBulletGroupTransform;

        }
    }
}
#endregion




















