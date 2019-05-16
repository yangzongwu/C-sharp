# a common strategy 
* Identify the bug: describe and document the issue as clear as possible, better with the trigger condition and/or logs.
* Reproduce the bug: verify and confirm the issue by reproducing it, better with the steps and efficient reproducing input.
* Isolate the bugs: sometimes the issue may be caused by multiple bugs tangle together, we have to separate them and then fix them one by one.
* Narrow down the scope: for a single issue, try to narrow down the scope of the bug as small as possible, and then we can focus on the problematic code quickly.
* Debug and fix: leverage the power of the debugger and debugging tools to find the bug and fix it.
* Verify the fix: verify whether the bug is truly fixed and not causing any regression and new bugs. Usually, we do this by writing unit tests and run the continuous integration (CI) system. And before the code can be checked into the code repository, there will be some code reviews.

# Example
input : Hello Debugging World  
output : Hlleo Dniggubeg World  
```csharp
static void ReverseWords(char[] chars) {
    int p = 0, q = 0;
    while (++q < chars.Length) {
        if (chars[q] == ' ') {
            ReverseWord(chars, p, q - 1);
            p = q + 1;
        }
    }
}

static void ReverseWord(char[] chars, int li, int hi) {
    while (li++ < hi--) {
        Swap(chars, li, hi);
    }
}

private static void Swap(char[] chars, int li, int hi) {
    char temp = chars[li];
    chars[li] = chars[hi];
    chars[hi] = temp;
}
```

# Identify the Bugs
* To Identify the bugs, we must observe - observe the input and output as cautious as possible. And, we should ask two questions:  
  * Is the input correct?  
  * What's EXACTLY wrong with the output?    
* With these two questions, let's check the input and output for the application:  
  * The input is a character array generated from words Hello Debugging World. This is no problem. The input is correct.
  * The output is Hlleo Dniggubeg World which is wrong. But if we take a closer look at the output, we can see there are actually two problems in the output. First, it's easy to notice that the last word World is not reversed at all. Second, the word Hello and Debugging is reversed in a weird way.
* Now, we can Identify the bugs as:  
  * Bug 1: The last word is (completely) not reversed.  
  * Bug 2: Except the last word, other words are not reversed completely. The position of the first and the last characters are not reversed.  
  
# Reproduce and Isolate the Bugs  
To simplify the input data, we won't use the words Hello, Debugging, and World. We will just use ABCDE and ABCDEF.   
* Input	ABCDE ABCDEF	;  
* Output  ADCBE ABCDEF ;  
Comparing the inputs and the outputs, we found:  
* We can confirm that the last word is always not reversed
* The problem of the reverse of other words is more complicated than what we thought - when the length of the input word is odd, only the first and last characters are not reversed (ABCDE -> ADCBE); when the length is even, the pattern is more confusing (ABCDEF -> AECDBF).

# Narrow Down  
* void Swap(char[] chars, int li, int hi) swaps two characters' position in a character array
* void ReverseWord(char[] chars, int li, int hi) reverses a single word in a character array
* void ReverseWords(char[] chars) reverses all words in a character array

# debug
* Step Over: I trust this line. No matter how many function are called in this line, they won't introduce bugs.
* Step Into: I don't (completely) trust this line. The bug(s) may be introduced by one of the call to other functions. I want to drill down to the next level function calls.

* Locals window
* Immediate window
* Call Stack window 
