/*
1.All the parts spread across different files, must use the partial keyword;
2.All the parts spread across different files, must have same acceess modifiers;
3.If any of the parts are declared abstract, then the entire type is considered abstract;
4.If any of the parts are declared sealed,then the entire type is considered sealed;
5.If any of the parts inherit a class, then the entire type inherits that class;
6. C# dose not support multiple class inheritance.Different parts of the partial class,
must not specify different base classes;
7. Different parts of the partial class can specify different base interfaces , and the
final type implements all of the interfaces listed by all of the partial declarations.
8.Any members that are declared in a partial definition are available to all of the other
parts of hte partial class.

*/
