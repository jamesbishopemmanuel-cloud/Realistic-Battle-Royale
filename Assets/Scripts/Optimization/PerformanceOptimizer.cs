using UnityEngine;


public class PerformanceOptimizer : MonoBehaviour
{

    public int targetFPS = 60;


    void Start()
    {
        Application.targetFrameRate =
        targetFPS;


        QualitySettings.vSyncCount = 0;


        Debug.Log(
        "Performance Optimized");
    }

}