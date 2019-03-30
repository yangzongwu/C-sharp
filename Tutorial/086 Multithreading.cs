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
