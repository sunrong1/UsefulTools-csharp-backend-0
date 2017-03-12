# 我的C# 学习仓库使用总结--版本控制工具

##1. C#学习工具

### 1.1 版本控制工具
最常用的两大版本控制工具：SVN与GIT。他们的Widows版本都有相应的界面配置版本：TortoiseSVN,和TortoiseGit版本。

### 1.2 Github 专业而强大的社区
windows下的带界面Git工具是torisegit，具体的安装和使用方法，已经有前辈做了详细总结：
[TortoiseGit安装与配置](http://blog.csdn.net/renfufei/article/details/41647937)；
[Git与TortoiseGit基本操作](http://blog.csdn.net/renfufei/article/details/41647973)；

> 根据教程，我简单的创建了[我的C#学习仓库](https://github.com/sunrong1990/Csharp-Projects)

### 1.3 Visual Studio 2015
我使用的是免费的社区版本，因为这个版本的缘故，我还将我电脑的系统升级到Windows 10.


## 2. Git 使用技巧

### 2.1 设置版本控制忽略的文件：.gitignore文件
实用文件，告诉Git 需要忽略的文件，通常的形式如下：

> #User-specific files
>
| *.bin
|*.obj
| *.suo
|*.user
|*.userosscache
|*.sln.docstates


### 2.2 设置torisegit的免密码上传

Git的设置中，点击 “编辑全局 .git/config(O)”按钮,在全局配置文件中,在后面加上下面的内容，保存输入的密码:

> [credential]

>helper = store

## 3. 代码的冲突合并

更新代码后，发现有文件冲突，是很正常的事情，通常的做法是先将自己改动的文件备份，然后再将文件还原，最后用比对工具合并解决冲突。

比对工具有很多妙用，不同版本之间的改动一目了然，注意以后要善于利用。

>代码更新中，有可能会对我们的代码，在不经意间被修改，需要留意版本的提交日志。
