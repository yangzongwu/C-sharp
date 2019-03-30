/*
C# 多线程
线程 被定义为程序的执行路径。每个线程都定义了一个独特的控制流。如果您的应用程序涉及到复杂的和耗时的操作，
那么设置不同的线程执行路径往往是有益的，每个线程执行特定的工作。

线程是轻量级进程。一个使用线程的常见实例是现代操作系统中并行编程的实现。使用线程节省了 CPU 周期的浪费，
同时提高了应用程序的效率。

到目前为止我们编写的程序是一个单线程作为应用程序的运行实例的单一的过程运行的。但是，这样子应用程序同时只
能执行一个任务。为了同时执行多个任务，它可以被划分为更小的线程。

线程生命周期
线程生命周期开始于 System.Threading.Thread 类的对象被创建时，结束于线程被终止或完成执行时。

下面列出了线程生命周期中的各种状态：

未启动状态：当线程实例被创建但 Start 方法未被调用时的状况。
就绪状态：当线程准备好运行并等待 CPU 周期时的状况。
不可运行状态：下面的几种情况下线程是不可运行的：
已经调用 Sleep 方法
已经调用 Wait 方法
通过 I/O 操作阻塞
死亡状态：当线程已完成执行或已中止时的状况。
主线程
在 C# 中，System.Threading.Thread 类用于线程的工作。它允许创建并访问多线程应用程序中的单个线程。进程中第一个被执行的线程称为主线程。

当 C# 程序开始执行时，主线程自动创建。使用 Thread 类创建的线程被主线程的子线程调用。您可以使用 Thread 类的 CurrentThread 属性访问线程。

using System;
using System.Threading;

namespace MultithreadingApplication
{
    class MainThreadProgram
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("This is {0}", th.Name);
            Console.ReadKey();
        }
    }
}

This is MainThread

using System;
using System.Threading;

namespace MultithreadingApplication
{
    class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
        }
        
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}

In Main: Creating the Child thread
Child thread starts
*/


//pic https://photos.google.com/search/_tra_/photo/AF1QipPkmMmeH3zj-Mm_eH2q0FNGm6ZNPxEg8yadU3h-

//==========================================================================================
Private void btnTimeConsumingWork(object sender,EventArgs e)
{
  btnTimeComsumingWork.Enable=false;
  btnPrintNumbers.Enable=false;
  
  DoTimeConsumingWork();
  
  btnTimeComsumingWork.Enable=true;
  btnPrintNumbers.Enable=true;
}

private void DoTimeConsumingWork()
{
  Thread.Sleep(5000);
}

private void btnPrintNumbers_Click(object sender,EventArgs e){
{
  for(int i=0;i<=10;i++){
    listBoxNumbers.Items.Add(i);
  }
}

//==========================================================================================
/*
when deal with btnTimeConsumingWork
need to wait 50000ms
do btnPrintNumbers_Click
*/
Private void btnTimeConsumingWork(object sender,EventArgs e)
{
  DoTimeConsumingWork();
}
private void DoTimeConsumingWork()
{
  Thread.Sleep(5000);
}
private void btnPrintNumbers_Click(object sender,EventArgs e){
{
  for(int i=0;i<=10;i++){
    listBoxNumbers.Items.Add(i);
  }
}
//==========================================================================================
/*
when deal with btnTimeConsumingWork
no need to wait 50000ms
do btnPrintNumbers_Click
*/
Private void btnTimeConsumingWork(object sender,EventArgs e)
{
  btnTimeComsumingWork.Enable=false;
  btnPrintNumbers.Enable=false;
  
  Thread workerThread=new Thread(DoTimeConsumingWork);
  workerThread.Start();
  //DoTimeConsumingWork();
  
  btnTimeComsumingWork.Enable=true;
  btnPrintNumbers.Enable=true;
}
private void DoTimeConsumingWork()
{
  Thread.Sleep(5000);
}
private void btnPrintNumbers_Click(object sender,EventArgs e){
{
  for(int i=0;i<=10;i++){
    listBoxNumbers.Items.Add(i);
  }
}
