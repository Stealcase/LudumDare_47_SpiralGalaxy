using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public static Movement hamster; 
        public static int currentLevel = 0;


        public static Spawner spawner;
        public static Timer timer; 
        public void Awake()
        {
            if(instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(this);
                return;
            }
        }

        public void RestartLevel()
        {
            spawner.Respawn();
            timer.ResetTime();
        }
        public void NextLevel()
        {
            currentLevel++;
            SceneManager.LoadScene(currentLevel);
        }
    }
}
