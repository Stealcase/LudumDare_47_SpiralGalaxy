using Assets.Scripts;
using Events.GameEvents;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{

    public Transform spawnPoint;
    // Start is called before the first frame update

    public void OnEnable()
    {
        GameManager.spawner = this;
    }

    public void Respawn()
    {
        GameManager.hamster.rb.position = spawnPoint.position;
        StartCoroutine(TurnOffPhysics());
    }

    public IEnumerator TurnOffPhysics()
    {
        GameManager.hamster.rb.isKinematic = true;
        yield return new WaitForFixedUpdate();
        GameManager.hamster.rb.isKinematic = false;
    }





}
