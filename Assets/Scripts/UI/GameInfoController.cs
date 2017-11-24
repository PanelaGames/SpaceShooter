using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInfoController : MonoBehaviour
{
    private GameObject player;
    private SimpleHull playerHull;
    private float maxHitPoints;
    private GameObject hitPointsText;
    private GameObject hitPointsProgress;
    private float hitPointsProgressMaxWidth;
    private Vector2 hitPointsProgressInitialScale;
    public void Awake()
    {
        player = GameObject.Find("Player");
        playerHull = player.GetComponent<SimpleHull>();
        maxHitPoints = playerHull.hitPoints;
        hitPointsText = GameObject.Find("Hit points text");
        hitPointsProgress = GameObject.Find("Hit points progress");
        hitPointsProgressMaxWidth = hitPointsProgress.GetComponent<RectTransform>().rect.width;
    }
    public void LateUpdate()
    {
        hitPointsText.GetComponent<Text>().text = playerHull.hitPoints.ToString() + "/" + maxHitPoints.ToString();
        hitPointsProgress.GetComponent<RectTransform>().sizeDelta = new Vector2(
            (playerHull.hitPoints / maxHitPoints) * hitPointsProgressMaxWidth,
            hitPointsProgress.GetComponent<RectTransform>().rect.height
        );
    }
}
