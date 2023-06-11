# BookManageSystem
图书管理系统
技术栈：C#、Mysql(Navicat)
# 主要功能模块流程图
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/94123781-1e80-46e8-b10a-070a9af278d8)
# 主要实现功能
**项目设计**：采用C/S模式，模拟实际的图书馆系统，全部的功能可看上面的流程图。  
这里设计了三个不同的身份完成不同的功能：读者可登录进行借还书查看，图书管理员负责管理书籍，系统管理员管理所有人员的数据。  
**工作内容：**  
1.独立完成系统的需求分析、系统设计、数据库设计。提供了学生、图书管理员和系统管理员三种身份切换以管理不同信息。
2.实现了对学生信息、图书管理员信息、书籍记录、借还书记录的增删改查操作。
3.参照真实的图书管理系统进行设计：比如利用了MySQL的自增功能，使得增加图书时，其记录号是自增的；设置了读者的最长借书时间和最多借阅书籍数量，利用sql语句控制后台数据，超时未还书籍的读者将会被处以罚款，未还罚款不能继续借书。系统管理员后台可看到全部读者的借还情况（包括罚款情况），也可更新罚款情况。

## 主要板块
logindata.cs --记录登录用户的id和name  
login.cs --登录界面

### 读者板块-reader

### 图书管理者板块-bookmanager

### 系统管理员板块-system_manager

  
