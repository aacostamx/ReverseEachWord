# Simple way to reverse each word in a string
Here is a simple way to reverse each word in a string using LINQ or a for loop.

## LINQ
```c#
private static string ReverseLINQ(string text)
{
	return string.Join(" ", text.Split(' ')
		.Select(x => new string(x.Reverse().ToArray())));
}
```

## For loop
```c#
private static string ReverseFor(string text)
{
	string result = string.Empty;

	string[] array = text.Split(' ');

	for (int i = 0; i < array.Length; i++)
	{
		result += new string(array[i].Reverse().ToArray());
		result += i != (array.Length - 1) ? " " : string.Empty;
	}

	return result;
}

```
