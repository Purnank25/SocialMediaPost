using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadPost : MonoBehaviour
{
    public TextMeshProUGUI usernameText;
    public Image profilePic;
    public TextMeshProUGUI contentText;
    public Button likeButton;
    public TextMeshProUGUI likeCountText;
    public Sprite likedSprite, unlikedSprite;

    private bool isLiked = false;
    private int likeCount;

   

    public void ToggleLike()
    {
        isLiked = !isLiked;
        likeCount += isLiked ? 1 : -1;
        likeCountText.text = likeCount.ToString();
        likeButton.image.sprite = isLiked ? likedSprite : unlikedSprite;
        Debug.Log("program starrted");
    }
}
