https://docs.microsoft.com/en-us/dotnet/standard/threading/
Advantage of multithreading:
1.To maintain a responsive user interface
2.To make effient use of processor time while waiting for I/O operations to complete
3.To solit large,CPU-bound tasks to be processed simultaneously on a machine that has multiple processors/cores

Disadcantages of multithreading:
1.On a single processor/core machine threading can affect performance negatively as there is overhead involved with\
context-switching
2.Have to write more lines of code to accomplish the same task
3.Multithreaded applications are difficult to write,understand,debug and maintain

下面再对此进行详细描述.

Thread类的构造函数有2类:

 一种是不带参数(ThreadStart 委托) --

 public Thread(ThreadStart start);

﻿
另一种是带参数(ParameterizedThreadStart 委托) --

public Thread(ParameterizedThreadStart start);

ParameterizedThreadStart 委托签名:

public delegate void ParameterizedThreadStart(Object obj);

示例:

1. 不带参数:

       // 定义线程方法:

        private static void ThreadMain()
        {
            Console.WriteLine("This is other thread main method.");
        }

　　　　// 调用:

            Thread mythread = new Thread(ThreadMain);
            mythread.Start();

2. 带参数:

        // 定义线程方法:

        private static void MainThreadWithParameters(object o)
        {
            Data d = (Data)o;  //类型转换
            Console.WriteLine("Running in a thread, received {0}", d.Message);
        }

    public struct Data
    {
        public string Message;
    }

　　　　// 调用:

            var data = new Data { Message = "Info" };
            Thread t2 = new Thread(MainThreadWithParameters);
            t2.Start(data);  // 传入参数

3. 通过定义类传递参数:

// 定义存放数据和线程方法的类:

    public class MyThread
    {
        private string message;
        public MyThread(string data)
        {
            this.message = data;
        }
        public void ThreadMethod()
        {
            Console.WriteLine("Running in a thread, data: {0}", this.message);  
        }
    }

// 调用

            var obj = new MyThread("info");
            Thread myThread = new Thread(obj.ThreadMethod); //ThreadStart 委托
            mythread.Start(); 
