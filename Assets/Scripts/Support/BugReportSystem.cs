using UnityEngine;


public class BugReportSystem : MonoBehaviour
{

    public void ReportBug(string bug)
    {
        Debug.Log(
        "Bug reported: "
        + bug);
    }

}