//初始化
List<T> mList = new List<T>();
List<int> mList = new List<int>() { 1, 2, 3 };

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
List.Count();
