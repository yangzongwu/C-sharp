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
