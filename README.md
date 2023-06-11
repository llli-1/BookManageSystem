# BookManageSystem
图书管理系统
技术栈：使用C#作为主要的编程语言，Windows Forms作为图形用户界面框架，MYSQL作为存储图书信息和用户信息的数据库，ADO.NET作为连接数据库和执行SQL语句的数据访问技术。
# 主要功能模块流程图
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/94123781-1e80-46e8-b10a-070a9af278d8)
# 主要实现功能
**项目设计**：采用C/S模式，模拟实际的图书馆系统，该系统旨在为图书馆提供一个方便快捷的图书借阅、查询和管理功能。 
这里设计了三个不同的身份完成不同的功能：读者可登录进行借还书查看，图书管理员负责管理书籍，系统管理员管理所有人员的数据。  
**工作内容：**  
- 设计和实现图书借阅模块，其中包括图书借阅、归还、逾期罚款等功能。  
- 在数据库设计方面，我使用存储过程和触发器来处理复杂的业务逻辑和数据验证。在界面设计方面，我使用了各种控件，如DataGridView、ListView、ComboBox等来显示图书信息并提供互动选项。在业务逻辑方面，我封装了图书相关的实体类和数据访问对象，并使用参数化查询和事务来确保数据的安全性和一致性。  
- 这个项目的亮点是： 1)  实现了模糊搜索功能，允许不同身份的人员通过关键词或类别搜索图书。2) 实现了一个通知功能，提醒用户借阅状态和到期日期。3) 遵循OOP设计原则，将界面、数据和逻辑层分开，提高代码的可读性和可维护性。  

**总结：**  
通过这个项目，我加深了对C#基本知识和Windows Forms框架使用方法的理解，熟悉了MYSQL数据库的基本操作和一些技巧（如自增等），熟悉了ADO.NET工作原理和常用类库。  
  
## 主要板块
logindata.cs --记录登录用户的id和name  
login.cs --登录界面  
效果：  
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/3f6b747e-494f-49ed-8d2d-6204be00a002)

（以下图形界面截图仅展示部分功能）
### 读者板块-reader
效果：  
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/ffb467af-7cd8-4265-b70e-a30e0a3ca922)
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/70613c58-168c-4ae9-b7ab-1216ea0528ed)
未交罚款不可借书提示：  
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/4cac39ca-212f-4756-96d5-c0aaba42d62f)  
借书成功提示：  
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/57062706-9ae4-4002-be5d-395de64477bc)


### 图书管理者板块-bookmanager
效果：  
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/c07515fe-ca26-4579-8f99-820b53a40857)
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/e1f0854a-3ea6-46ac-91af-fc884bfef980)
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/8ccc3f29-6483-458c-8aca-1e03c5c68f27)


### 系统管理员板块-system_manager
效果：  
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/365cc01e-7e9f-4c40-b12e-61f9f4d53399)
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/5117b89a-4152-4341-bca8-c5940a1792b5)
![image](https://github.com/llli-1/BookManageSystem/assets/102156169/db47be16-81e5-44b5-8c32-099ff45898a4)

  
