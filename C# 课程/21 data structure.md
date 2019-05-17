# 引入  
* 算法(algorithm)与数据结构(data structure)关系  
  * 数据结构用来表达算法  数据结构决定了行为  
  * 比如 DFS，用递归，或者用queue  
  * 比如 BFS，用递归，用array, list,queue...  
    * 算法可以用数据结构  
    * 算法也可以不用数据结构  
    * 某些算法必须用数据结构  
  * 脱离数据结构的算法
    * 可以离开数据结构  循环，递归，贪心，动态规划   
    * 一般可以O(1) memory 可以脱离数据结构 

### 直观概念
   * 排序--二分  
   * O(1) memory--O(n)  
   * tree/map  BFS,DFS
   * muti array -- map
   * single array-- tree  

# 数据结构转换关系  
最基本的数据结构  --- variable（特别是无符号整型变量）    
最基本的algorithm ---- operatoers

variable--array--list--(D)linkedList--Stack,Queue,DQ,PQ,  SET,Map/Dictionary(当讨论ADT的时候只有Map,没有Dictionary)  tree Graph
从list开始都是ADT  
Array: 是编译器支持，连续，长度不变，可以直接选址  
ADT(algorithm data type)： 定义的某一种数据的行为  
ADT represent by interface，实现impelemnted 数据结构  
数据结构  represent by class  
list: Add,Remove,Count,GetElement,Insert,RemoveAt  

* 数据结构关系
  * array vs list : 
    * array 长度固定，元素一样，list 长度不固定，也叫动态array
    * array可以实现list 
    * index 找O（1）
    * 插入删除 O(N)
  * dictionary  vs array
    * 什么时候可以用array代替dictionary    
    * keys.size固定   
    * 用index代替key  
  * list vs linkedList
  * array implement list,stack,queue,Double Queue
  * stack vs queue 
  * LinkedList implement stack,queue,Double Queue
  * Arrary，Tree implement Priority Queue（array as tree）
  * Arrary,Tree implement HashSet
  * set as map
  * set, tree implement map
  * Graph 几乎都有关系  
* 数据结构方法
  * 循环 tree(search tree除外)/graph 不支持循环
  * 排序 set,map不支持排序，排序一般考虑二分  
  
数据结构决定了只能用这些算法，给出一道题，首先想是什么数据结构，然后决定用什么算法  

