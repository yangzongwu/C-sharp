//Queue<T>()	
//Initializes a new instance of the Queue<T> class that is empty and has the default initial capacity.
Queue<string> numbers = new Queue<string>();


//Queue<T>(IEnumerable<T>)	
//Initializes a new instance of the Queue<T> class that contains elements copied from the specified 
//collection and has sufficient capacity to accommodate the number of elements copied.
Queue<string> queueCopy = new Queue<string>(array2);


//Queue<T>(Int32)	
//Initializes a new instance of the Queue<T> class that is empty and has the specified initial capacity.

//属性
//public int Count { get; }
queueCopy.Count

//方法
public void Clear ();


public bool Contains (T item);


public void CopyTo (T[] array, int arrayIndex);
//Copies the Queue<T> elements to an existing one-dimensional Array, starting at the specified array index.

public T Dequeue ();


public void Enqueue (T item);


public T Peek ();
//Returns the object at the beginning of the Queue<T> without removing it.


public T[] ToArray ();
//Copies the Queue<T> elements to a new array.
Queue<string> numbers = new Queue<string>();
Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
