# 课堂补充 
前端 JavaScript  
中间 java,C#(ASP),python(Django) ....  
后端SQL  
Script解释型语言  逐行执行  结果面向机器，速度快，代码更新，客户没有更新的话没有最新版本，必须解析之后分发给客户（JavaScript python）    
C#，Java 编译型语言  整块执行  执行效率比较低，客户直接拿到最新的版本（C系例，Java）    
* 对于有错的语言    
  * 编译型语言之间报错，无法编译    
  * 解释性语言逐行执行，到错误行报错    
* 运行环境/运行时    
  * C/C++ 编译结果，必须在C/C++环境中运行   
  * Java 编译结果，必须在Java环境中（JVM）  
  * C#  编译结果，必须.NET Framework环境  
  * JavaScript ?脚本语言   他的解析器加载在浏览器里面， 拿不到该解析器
  * Python ? 

* 如何学习 JavaScript  
  * 用node学习  
  * 在浏览器直接编程  

做UI， 需要知道你有什么控件，等等
```html
<html>
<head>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" 
          integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" 
          crossorigin="anonymous">
</head>
<body>
    <h1>Hello Web Client</h1>
    <div class="card" style="width:50%; margin:auto">
        <div class="card-header">
            <div>
                <form action="???">
                    <fieldset>
                        <legend>Please choose</legend>
                        <select name="food">
                            <option value="Apple1">Apple1</option>
                            <option value="Apple2">Apple2</option>
                            <option value="Apple3">Apple3</option>
                        </select>
                        <input type="submit" value="submit" class="btn btn-warning">
                    </fieldset>
                </form>
            </div>
        </div>
    </div>    
</body>
<script>
    //alert("This is a piece of JavaScript code"); 
    //location="http://www.google.com";
</script>
</html>
```

```html
<html>
<head>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" 
          integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" 
          crossorigin="anonymous">
</head>
<body>
    <h1>Hello Web Client</h1>
    <div class="card" style="width:50%; margin:auto">
        <div class="card-header">
            <div>
                <form action="???">
                    <fieldset>
                        <legend>Please choose</legend>
                        <select name="food">
                            <option value="Apple1">Apple1</option>
                            <option value="Apple2">Apple2</option>
                            <option value="Apple3">Apple3</option>
                        </select>
                        <input type="button" value="submit" class="btn btn-warning" onclick="haha()"/>
                    </fieldset>
                </form>
            </div>
        </div>
    </div>    
</body>
<script>
    function haha() {
        location = "http://www.google.com";
        }
</script>
</html>
```


```html
<html>
<head>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" 
          integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" 
          crossorigin="anonymous">
</head>
<body>
    <h1>Hello Web Client</h1>
    <div class="card" style="width:50%; margin:auto">
        <div class="card-header">
            <div>
                我是一个计算器
            </div>
        </div>
        <div>
            <input type="text" id="txt1" /><br/>
            <input type="text" id="txt2" /><br/>
            <input type="text" id="txt3" /><br/>
            <input type="button" value="Add" onclick="DoAdd()"/>
        </div>
    </div>    
</body>
<script>
    function DoAdd() {
        var t1 = document.getElementById('txt1').value;
        var t2 = document.getElementById('txt2').value;
        if (!t1 || !t2) {
            alert('wrong number');
            return;
        }
        var result = parseFloat(t1) + parseFloat(t2)
        document.getElementById('txt3').value = result.toString()
    }
</script>
</html>
```
