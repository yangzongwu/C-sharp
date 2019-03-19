Dictionary<TKey,TValue>()
Dictionary<string, string> openWith = new Dictionary<string, string>();
openWith.Add("txt", "notepad.exe");

// The Add method throws an exception if the new key is 
// already in the dictionary.
try
{
    openWith.Add("txt", "winword.exe");
}
catch (ArgumentException)
{
    Console.WriteLine("An element with Key = \"txt\" already exists.");
}


// Create a Dictionary of strings with string keys, and 
// initialize it with the contents of the sorted dictionary.
Dictionary<string, string> copy = new Dictionary<string, string>(openWith);


//属性
//Gets the number of key/value pairs contained in the Dictionary<TKey,TValue>.
public int Count { get; }


//方法
// Create a new dictionary of strings, with string keys.
Dictionary<string, string> openWith = new Dictionary<string, string>();


//public void Add (TKey key, TValue value);O(1)
/ Add some elements to the dictionary. There are no 
// duplicate keys, but some of the values are duplicates.
openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");


//public void Clear ();O(n)
//Removes all keys and values from the Dictionary<TKey,TValue>.


//public bool ContainsKey (TKey key);O(1)
//Determines whether the Dictionary<TKey,TValue> contains the specified key.
// ContainsKey can be used to test keys before inserting them.
if (!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
}


//public bool ContainsValue (TValue value);O(n)
//Determines whether the Dictionary<TKey,TValue> contains a specific value.



//public bool Remove (TKey key);
//Removes the value with the specified key from the Dictionary<TKey,TValue>
openWith.Remove("doc");
if (!openWith.ContainsKey("doc"))
{
    Console.WriteLine("Key \"doc\" is not found.");
}

