//初始化
List<T>()	
//Initializes a new instance of the List<T> class that is empty and has the default initial capacity.
//List<T> mList = new List<T>();
List<int> mList = new List<int>() { 1, 2, 3 };

List<T>(IEnumerable<T>)	
//Initializes a new instance of the List<T> class that contains elements copied from the specified 
//collection and has sufficient capacity to accommodate the number of elements copied.
string[] input = { "Brachiosaurus", "Amargasaurus", "Mamenchisaurus" };
List<string> dinosaurs = new List<string>(input);

List<T>(Int32)	
Initializes a new instance of the List<T> class that is empty and has the specified initial capacity.


//add
List.Add(T item);
List.AddRange(IEnumerable<T> collection);
List.Insert(int index, T item);

//遍历
foreach (T element in mList) {};

//delete
List.Remove(T item);
List.RemoveAt(int index);
List.RemoveRange(int index, int count);

//search
List.Contains(T item);

//other
List.Sort(); //默认是元素第一个字母按升序
List.Reverse();
List.Clear();
List.Count;
