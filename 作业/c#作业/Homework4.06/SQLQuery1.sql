create procedure sp_studentInsert--增加学生
@StudentGuid varchar(50),
@LoginId nvarchar(10),
@LoginPwd varchar(10),
@UserStateId int,
@StudentNo varchar(10),
@StudentName nvarchar(10),
@Sex nvarchar(10),
@Address nvarchar(50),
@ClassGuid varchar(50)
as
insert into Student (StudentGuid,LoginId,LoginPwd,UserStateId,StudentNo,StudentName,Sex,Address,ClassGuid) values (@StudentGuid,@LoginId,@LoginPwd,@UserStateId,@StudentNo,@StudentName,@Sex,@Address,@ClassGuid)
go

create proc sp_selectClassGuid--查询班级编号
@className nvarchar(10)
as
select ClassGuid from Class where ClassName=@className
go

create proc sp_selectClassName--查询班级名
as
select ClassName from Class
go

create proc sp_selectByStuGuid--通过GUID查询学生信息(删除用)
@StudentGuid varchar(50)
as
select * from Student s inner join Class c on c.ClassGuid = s.ClassGuid where StudentGuid=@StudentGuid
go

create proc sp_delete
@StudentGuid varchar(50)
as
delete  from Student where StudentGuid=@StudentGuid
go

create proc sp_Update--更新
@StudentGuid varchar(50),
@LoginId nvarchar(10),
@UserStateId int,
@StudentNo varchar(10),
@StudentName nvarchar(10),
@Sex nvarchar(10),
@Address nvarchar(50),
@ClassGuid varchar(50)
as
update Student set LoginId=@LoginId,UserStateId=@UserStateId,StudentNo=@StudentNo,StudentName=@StudentName,Sex=@Sex,Address=@Address,ClassGuid=@ClassGuid where StudentGuid=@StudentGuid
go

create proc sp_SelectAll--查询所有信息
@Sex nvarchar(10),
@ClassName nvarchar(10),
@StudentName nvarchar(50)
as
select * from Student s inner join Class c on c.ClassGuid = s.ClassGuid where (LEN(@Sex)=0 or CHARINDEX(@Sex,Sex)>0) and (LEN(@ClassName)=0 or CHARINDEX(@ClassName,ClassName)>0 )and (LEN(@StudentName)=0 or CHARINDEX(@StudentName,StudentName)>0 )
go

create proc sp_selectOldPwd --查询旧密码(改密码用)
@StudentGuid varchar(50)
as
select LoginPwd from Student where StudentGuid=@StudentGuid
go

create proc sp_updatePwd --修改密码(改密码用)
@StudentGuid varchar(50),
@LoginPwd varchar(10)
as
update Student set LoginPwd=@LoginPwd where StudentGuid=@StudentGuid
go