using System.Collections;
using System.Collections.Generic;

public static class WaitFor
{
    public static IEnumerator Frames(int frameCount)
    {
        while (frameCount > 0)
        {
            frameCount--;
            yield return null;
        }
    }
}


/*


    public IEnumerator CoroutineAction()
{
    // do some actions here
    yield return WaitFor.Frames(5); // wait for 5 frames
    // do some actions after 5 frames
}
    */
