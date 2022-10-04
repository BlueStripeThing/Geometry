--������
SELECT Products.product, Categories.category from Products 
Left Join Product_categories on Products.id=product_id 
Left Join Categories on Product_categories.category_id = Categories.id


----�������� ��
--Create Table Products (id int, product varchar(10),Primary key (id))

--Create Table Categories (id int, category varchar(10),Primary key (id))

--Create Table Product_categories (id int, product_id int, category_id int, 
--FOREIGN KEY (product_id) references Products(id), 
--FOREIGN KEY (category_id) references Categories(id))

--Insert into Products values (1,'��������'),(2,'������'),(3,'���������'),(4,'����');
--Insert into Categories values (1,'����������'),(2,'���������'),(3,'������');
--Insert into Product_categories values (1,1,1),(2,2,2),(3,3,1),(4,3,3);






