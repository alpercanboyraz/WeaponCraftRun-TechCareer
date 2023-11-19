using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class WindowMovement : MonoBehaviour
{
    public float moveDistance = 3f; // Hareket mesafesi
    public float moveDuration = 2f; // Hareket süresi
    public float leftLimit = -3f; // Sola hareket sınırı
    public float rightLimit = 3f; // Sağa hareket sınırı

    private Vector3 initialPosition;

    void Start()
    {
        //initialPosition = transform.position;
        MoveBackAndForth();
     }

    void MoveBackAndForth()
    {
        // Sağa doğru hareketi oluştur
        Sequence moveRight = DOTween.Sequence();
        moveRight.Append(transform.DOMoveX(initialPosition.x + moveDistance, moveDuration)
            .SetEase(Ease.Linear));
        moveRight.AppendCallback(() => ClampPosition(rightLimit));

        // Sola doğru hareketi oluştur
        Sequence moveLeft = DOTween.Sequence();
        moveLeft.Append(transform.DOMoveX(initialPosition.x - moveDistance, moveDuration)
            .SetEase(Ease.Linear));
        moveLeft.AppendCallback(() => ClampPosition(leftLimit));

        // Hareketleri sonsuz olarak birleştir
        Sequence moveSequence = DOTween.Sequence();
        moveSequence.Append(moveRight);
        moveSequence.Append(moveLeft);
        moveSequence.SetLoops(-1); // Sonsuz döngü için -1 olarak ayarla
    }

    void ClampPosition(float limit)
    {
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, limit, -limit);
        transform.position = clampedPosition;
    }
}
