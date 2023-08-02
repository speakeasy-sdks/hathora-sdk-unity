## Unity notes

- this initial implementation is using UnityWebRequest
- DateOnly is polyfilled as it is part of .NET 6; Unity is using the .NET framework which does not include it nor TimeOnly
- the generated SDK makes use of the NewtonSoft JSON package which can be installed in the Unity package manager using `com.unity.nuget.newtonsoft-json `
- an extension has been added in the Utilities class to allow the use of `await` when making `async` requests

```
public static class ExtensionMethods
{
	///<summmary>
	/// This extension to allow using await with async web requests
	///</summmary>
	public static TaskAwaiter GetAwaiter(this AsyncOperation asyncOp)
	{
		var tcs = new TaskCompletionSource<object>();
		asyncOp.completed += obj => { tcs.SetResult(null); };
		return ((Task)tcs.Task).GetAwaiter();
	}
}
```