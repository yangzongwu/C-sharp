# a common strategy 
* Identify the bug: describe and document the issue as clear as possible, better with the trigger condition and/or logs.
* Reproduce the bug: verify and confirm the issue by reproducing it, better with the steps and efficient reproducing input.
* Isolate the bugs: sometimes the issue may be caused by multiple bugs tangle together, we have to separate them and then fix them one by one.
* Narrow down the scope: for a single issue, try to narrow down the scope of the bug as small as possible, and then we can focus on the problematic code quickly.
* Debug and fix: leverage the power of the debugger and debugging tools to find the bug and fix it.
* Verify the fix: verify whether the bug is truly fixed and not causing any regression and new bugs. Usually, we do this by writing unit tests and run the continuous integration (CI) system. And before the code can be checked into the code repository, there will be some code reviews.
