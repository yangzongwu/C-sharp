# Introduction in LINQ
### The Benefits of Using LINQ
* Simplify the Code
* Unify the Code
  * use Where to filter the elements
  * use Select to transform the value
  * use Max and Min to find the maximal and minimal value
  * use Sum, Count, Average to get the statistic value
  * use Intersection, Except, Union to do collection operations
  * use GroupBy, OrderBy, Join to do advanced queries
  * ...

### There are two syntaxes for writing LINQ:
* Using standard syntax:
```csharp
var result = array.Where(n => n > 100);
```
* Using query expression syntax:
```csharp
var result = from n in array select n;
```

### LINQ VS SQL
* LINQ
```csharp
from {variable} in {source} where {condition} select {result}
```
* SQL
```SQL
SELECT {result} FROM {source} WHERE {condition}
```
* The clause sequence of SQL syntax is:
  * SELECT->FROM->WHERE->GROUP BY->HAVING->ORDER BY,
* The keywords/clause sequence of LINQ query expression is:
  * from-> variable in source->where->groupby (may have into)->orderby->select matched value(s) to the result.
