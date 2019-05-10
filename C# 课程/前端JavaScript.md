# 课堂补充 
* 前端 JavaScript  (typeScript 微软新出来的，增加类型的限制，JavaScript对于类型无限制)  
* 中间 java,C#(ASP),python(Django) ....  
* 后端SQL  
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

###  前端学习  
重点在框架不是算法  


# JavaScript
https://developer.mozilla.org/en-US/docs/Web/JavaScript  
### 数据类型  
常见数据类型number, string, boolean  
* Type Variable Value    
  * Type不能约束Variable  
  * Variable没有Type  
  * 所有值都是有Type  
  * Type决定了Value的取值范围和行为  
  * JavaScript没有值关系  
  * 所有都是引用关系，没有值关系  
  * 值决定了变量类型  
  * 没有兼容一说  
  * 表达式和值  
  * 表达式的类型也就是其值的类型，和C# 一样   
### 表达式    
  * && || 一样有短路效应   
  * delete  
  * in  
  * instanceof    
```javascript
class Student {
    constructor(id, name) {
        this.id = id;
        this.name = name;
    }
}
let stu = new Student(1, "Tim");
console.log(stu instanceof Student);
```
### 语句statments  
C# function 隶属于class  
javascript function 和class 同一级别  
javascript 没有委托，变量天生是委托  
```javascript
Function sayHello(){
    console.log("hello");
}
let xxx = sayHello;
xxx();
```
```javascript 
let sayHello=function(){//匿名函数
    console.log("hello");
}
```
```javascript
let sayHello=()=>{
    console.log("hello");
}
sayHello();
```
for 和C# 不一样  
```javascript
let names = ["ts", "s", "sd"];
for (let i in names) {
    console.log(i);//0,1,2
    console.log(names[i]);//"ts", "s", "sd"
}
```

cctv.js  export  import // 案例还有问题  
```javascript
export class TV {
    constructor(channel) {
        this.channel = channel;
    }
    play() {
        if (this.channel == 1) {
            console.log("dsdf");
        }
        else if (this.channel == 2) {
            console.log("dsdf");
        }
        else{
            console.log("dsdf");
        }
    }
}
```
hello.js  
```javascript
import { TV } from './cctv';
let tv0 = new TV(1);
tv0.play();
```

### function   
```javascript
function add(a, b) {
    return a + b;
}
console.log(add(100, 200));
console.log(add("sd", "apple"));
```
