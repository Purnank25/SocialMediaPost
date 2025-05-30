using UnityEngine;
using UnityEngine.UIElements;

public class ToggleLike : MonoBehaviour
{
    public Sprite liked;
    public Sprite unliked;
    public Image buttonImage;
    public bool isLiked = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LikeButtonController()
    {
        isLiked = !isLiked;
        buttonImage.sprite = isLiked ?  liked :  unliked;  
    }
}
