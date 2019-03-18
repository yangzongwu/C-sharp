//初始化
//Stack<T>()	
//Initializes a new instance of the Stack<T> class that is empty and has the default initial capacity.
Stack<T> numbers = new Stack<T>();
Stack<string> numbers = new Stack<string>();

//Stack<T>(IEnumerable<T>)	
//Initializes a new instance of the Stack<T> class that contains elements copied from the specified 
collection and has sufficient capacity to accommodate the number of elements copied.
Stack<string> stack2 = new Stack<string>(numbers.ToArray());
Stack<string> stack3 = new Stack<string>(array2);

//Stack<T>(Int32)	
//Initializes a new instance of the Stack<T> class that is empty and has the specified initial capacity 
//or the default initial capacity, whichever is greater.


//属性
//Count，获取堆栈中包含的元素数量。
stack.Count;

//方法
//1	public void Clear ();; 
//从 Stack 中移除所有的元素。
stack.Clear();

//2 public bool Contains (T item);;
//判断某个元素是否在 Stack 中。
stack.Contains("four");

//3	public T Peek ();;
//返回在 Stack 的顶部的对象，但不移除它。
stack.Peek();

//4	public T Pop ();
//移除并返回在 Stack 的顶部的对象。
stack.Pop();

//5	public void Push (T item);
//向 Stack 的顶部添加一个对象。
numbers.Push("one");

/*6	public T[] ToArray ();;
Copies the Stack<T> to a new array.
Returns
T[]
A new array containing copies of the elements of the Stack<T>.*/
Stack<string> numbers = new Stack<string>();
Stack<string> stack2 = new Stack<string>(numbers.ToArray());


//7 public void CopyTo (T[] array, int arrayIndex);
//Copies the Stack<T> to an existing one-dimensional Array, starting at the specified array index.
Stack<string> numbers = new Stack<string>();
string[] array2 = new string[numbers.Count * 2];
numbers.CopyTo(array2, numbers.Count);
