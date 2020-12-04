# Simple Timer Unity Coroutine

Some examples of how to use `DoAfter()`:

```csharp
// Execute the EndGame() method after a 5 second delay
StartCoroutine(DoAfter(5f, ()=>EndGame()));

// Wait 1 second and instantiate a gameObject
StartCoroutine(DoAfter(1f, ()=>Instantiate(itemDropObject, itemPosition, Quaternion.identity)));

// Prevent game audio from repeating infinitely
StartCoroutine(DoAfter(0.2f, ()=>attackAudioCooldown = false));
```
