using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    [SerializeField] private float _fireRate = 1f;
    [SerializeField] private float _fireRange = 1f;

    public void Init()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rate"))
        {
            _fireRate++;
            // Debug.Log("fireRate :" + _fireRate);
            SceneController.Instance.moveBullet._moveSpeed *= 2;
            EventManager.Instance.SetRateIncrease(_fireRate);

        }

        if (other.CompareTag("Range"))
        {
            _fireRange++;
            EventManager.Instance.SetRangeIncrease(_fireRange);
        }

        if (other.CompareTag("Prize"))
        {
           
            //SceneController.Instance.getPrize.control = true;
            EventManager.Instance.SetGetPrize();
        }
    }
}
