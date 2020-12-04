using System.Collections;
using System.Collections.Generic;

public static class Utilities {
  /*
   * Simple way to start functions after a timer runs out
   *
   * StartCoroutine(DoAfter(5f, ()=>EndGame()));
   */
  private IEnumerator DoAfter(float delay, System.Action operation) {
    yield return new WaitForSeconds(delay);
    operation();
  }
}
