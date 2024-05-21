using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RandomImageSpawner : MonoBehaviour
{
    [SerializeField] private RawImage rawImage1;
    [SerializeField] private RawImage rawImage2;
    [SerializeField] private RawImage rawImage3;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float displayDuration = 2f;
    [SerializeField] private Vector2 screenSize;
    [SerializeField] private Canvas canvas;

    private int score = 0;
    private RectTransform rawImage1RectTransform;
    private RectTransform rawImage2RectTransform;
    private RectTransform rawImage3RectTransform;
    private RectTransform canvasRectTransform;

    private void Start()
    {
        rawImage1RectTransform = rawImage1.GetComponent<RectTransform>();
        rawImage2RectTransform = rawImage2.GetComponent<RectTransform>();
        rawImage3RectTransform = rawImage3.GetComponent<RectTransform>();
        canvasRectTransform = canvas.GetComponent<RectTransform>();
        rawImage1.gameObject.SetActive(false);
        rawImage2.gameObject.SetActive(false);
        rawImage3.gameObject.SetActive(false);

        Invoke("SpawnImage1", Random.Range(1f, 2f));
        Invoke("SpawnImage2", Random.Range(1f, 2f));
        Invoke("SpawnImage3", Random.Range(1f, 2f));
    }

    private void SpawnImage1()
    {
        SpawnImage(rawImage1RectTransform);
        Invoke("SpawnImage1", Random.Range(1f, 2f));
    }

    private void SpawnImage2()
    {
        SpawnImage(rawImage2RectTransform);
        Invoke("SpawnImage2", Random.Range(1f, 2f));
    }

    private void SpawnImage3()
    {
        SpawnImage(rawImage3RectTransform);
        Invoke("SpawnImage3", Random.Range(1f, 2f));
    }

    private void SpawnImage(RectTransform rawImageRectTransform)
    {
        Vector2 randomPosition = GetRandomPositionWithinCanvas();
        rawImageRectTransform.anchoredPosition = randomPosition;
        rawImageRectTransform.gameObject.SetActive(true);
        Invoke("HideImage", displayDuration);
    }

    private Vector2 GetRandomPositionWithinCanvas()
    {
        Vector2 canvasSize = canvasRectTransform.rect.size;
        Vector2 normalizedScreenSize = new Vector2(screenSize.x / Screen.width, screenSize.y / Screen.height);
        Vector2 canvasScreenSize = new Vector2(canvasSize.x * normalizedScreenSize.x, canvasSize.y * normalizedScreenSize.y);
        float minX = -canvasScreenSize.x / 2;
        float maxX = canvasScreenSize.x / 2;
        float minY = -canvasScreenSize.y / 2;
        float maxY = canvasScreenSize.y / 2;
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }

    private void HideImage()
    {
        rawImage1.gameObject.SetActive(false);
        rawImage2.gameObject.SetActive(false);
        rawImage3.gameObject.SetActive(false);
    }

    public void OnImageClick()
    {
        score++;
        scoreText.text = score.ToString();
        HideImage();
    }
}
