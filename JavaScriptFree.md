#FreeCodeCamp

# 学习方法
1. GitHub
2. 解决问题

Read --->search ---->ask

## HTML_CSS


###  I 基本结构
1. 常用标签


2. 输入控件

  `<input type="text" name="indoor-outdoor">Text1`

  `<input type="radio" name="indoor-outdoor">Text2`

  `<button></button>`

  `class="target"` :
### II Bootstrap
响应式编程--responsive
可以很方便的扩展到移动端，源自Twitter

1)库连接

`class="container-fluid"` :内容自动调整

2) Icons库连接Font Awesome

  `<link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css"/>`：保存的都是矢量图形，.svg格式

1. Button

  直接在Class中引用Bootstrap中的属性

  `class="btn btn-block"` ：占据整行

  `class ="btn btn-default"`

  `class="btn btn-danger"` :危险按钮

2. Bootstrap Grid

  class="row"

  `class= "col-xs-4"` :xs =extremly small,4 columns in Grid layout

`clas="well"` :深度的视觉
3. Text 控制

  `class="text-danger"` :警示Text

  `class = "text-primary"` : 页面主题颜色

  `text-center` : Bootsrap Class,显示位置控制

  `class= "img-responsive"`:跟随页面自动调整

4. Font Awesone ICon的引用

 `<i class="fa fa-info-circle"></i>` :添加info小图标

 `<i class="fa fa-thumbs-up"></i>`

 `<i class="fa fa-trash"></i>`
## JQuery--Animate.css

 jQuery library :

 Animate.css :动画特效

1. document ready

 `$(document).ready(function(){})` :等HTML渲染后Load
 $ :

2. 定位元素的方法

`"HtmlType"` :Html 类型名

`.myClass` :类名

`#myId` : 元素ID名

3. 特效

`animated shake` :晃动

4. addClass removeClass

5. CSS 操作

`$("#target").css("color","red")` :设置元素CSS

6. Disable

`$("#target1").prop("disabled", true);` :Disable an Elment

## JavaScript学习----From FreeCodeCam



HTML的疑问

### I. 我的疑问
1. Margin 的配置margin-top 为什么可以设置成负值，设置成负值的作用是什么？
2. JavaScript的 “\r” 和”\n"的区别是什么？

### II.学习路线
1. 变量

  var定义；
  可以是：string;float;integer;Boolean
2. 算术运算

 “+” - * / % += -= /= "** =" "/="  


3. 字符串运算

  字符串字面值的不可以Index修改；字符串变量

  length属性；index运算；

  +运算

4. 数组运算

  Index运算；多维数组

  push --- pop 数组尾后操作

  unshift--shift 数组头部删加操作

  ~ 数组高级操作 --- 使用CallBackFunction

  * `.map(function(val){return operate});` ----> 遍历元素，单独操作
  * `.reduce(function(previousVal,currentVal){return +-opera});`--> 遍历元素，加减运算,返回计算值
  * `.filter(function(val){retrun logic});` -----> 删除其中的Logic False的元素
  * `.sort(function(a,b){return a-b});` :-----> 排序
  * `.reverse()`:---->元素反转
  * `oldArray.concat(otherArray)` :------> 数组连接

  * `split('s')` :--->字符串分割成数组
  * `join('s')` :---->数组连接成字符串

  参考ＭＤＮ：
  https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
5. 函数

  函数的定义格式；参数；返回值；变量的Scope，local 和Global

6. 逻辑运算

&& || ！

\> <= === ==(strict equality)

7. 条件语句 if switch

switch 中的匹配是strict equality(===)

8. JavaScript Oject对象

属性的访问，`.`和 `[]` ---dot and bracket notation
属性的测试：hasOwnProperty()

数组：可以包含JSON对象

构造函数 -->也可以是含参构造函数
`var MotorBike = function(wheels){
  var speed =0;
  this.wheels = wheels;
  this.seats= 2;//属性
  this.accelerate = function(change){
    speed +=change;//方法
  }
};
`
私有变量：
公有变量：




9. For循环语句、while

10. Random Fractions

Math.random() Function
Math.floor() 向下近似的整数

11. Regular Expressions

语法：string.match(expression)
Regular expression:  /the/gi

/:is the start

/:is the end

/gi :is the parameter,"g" means global ,"i" means ignore the case;

\s ---------> 匹配空格 \S ------->匹配非空字符
\+ -------> 匹配一个或者多个
\d ---------->匹配数字
